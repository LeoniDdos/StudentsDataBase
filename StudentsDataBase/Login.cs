using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDataBase
{
    public partial class Login : Form
    {

        int UserID;
        string LoginName;
        bool root = false;

        public Login()
        {
            InitializeComponent();
        }

        private static void InsertToTable()
        {
            SqlConnection conn = new SqlConnection(@"Server=LAPTOP-8BSFAANR\SQLEXPRESS;Database=Students;Trusted_Connection=Yes;");
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Users" +
                        "(Name,Password,Level) Values (@Name,@Password,@Level)", conn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Name"; param.Value = "admin"; param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@Password"; param.Value = "admin"; param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@Level"; param.Value = 1; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);

                Console.WriteLine("Вставляем запись");
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Ошибка подключения: {0}", se.Message);
                    return;
                }
            }
            conn.Close();
        }

        private static void CreateNewTable()
        {
            SqlConnection conn = new SqlConnection(@"Server=LAPTOP-8BSFAANR\SQLEXPRESS;Database=Students;Trusted_Connection=Yes;");
            conn.Open();

            string CreateOtdels = "CREATE TABLE Otdels (OtdelID int IDENTITY(1,1) PRIMARY KEY, Manager VarChar(30) not null, Telephone VarChar(30) not null); ";
            string CreateGroups = "CREATE TABLE Groups (GroupID int IDENTITY(1,1) PRIMARY KEY, Name VarChar(30) not null, Faculty VarChar(30) not null, Curator VarChar(30) not null, StudCount int not null, OtdelID int FOREIGN KEY REFERENCES Otdels(OtdelID)); ";
            string CreateUsers = "CREATE TABLE Users (UserID int IDENTITY(1,1) PRIMARY KEY, Name VarChar(30) not null, Password VarChar(30) not null, Level int not null); ";
            string CreateStudents = "CREATE TABLE Students (StudentID int IDENTITY(1,1) PRIMARY KEY, Surname VarChar(30) not null, Name VarChar(30) not null, Patronymic VarChar(30), Birthday VarChar(30), GroupID int FOREIGN KEY REFERENCES Groups(GroupID))";


            using (SqlCommand cmdCreateTable = new SqlCommand(CreateOtdels + CreateGroups + CreateUsers + CreateStudents, conn))
            {
                Console.WriteLine("Создаем таблицы");
                try
                {
                    cmdCreateTable.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Ошибка подключения: {0}", se.Message);
                    return;
                }
            }
            conn.Close();
        }

        public void Init()
        {
            string connStr = @"Data Source=LAPTOP-8BSFAANR\SQLEXPRESS;
                            Initial Catalog=Students;
                            Integrated Security=True";
            SqlConnection connection = new SqlConnection(connStr);
            try
            {
                connection.Open();
            }
            catch (SqlException se)
            {
                if (se.Number == 4060)
                {
                    connection = new SqlConnection(@"Data Source=LAPTOP-8BSFAANR\SQLEXPRESS;Integrated Security=True");
                    SqlCommand cmdCreateDataBase = new SqlCommand(string.Format("CREATE DATABASE [{0}]", "Students"), connection);
                    connection.Open();
                    Console.WriteLine("Создаем Базу Данных");
                    cmdCreateDataBase.ExecuteNonQuery();
                    connection.Close();
                    Thread.Sleep(5000);
                    
                    CreateNewTable();
                    InsertToTable();
                }
            }
            finally
            {
                Console.WriteLine("Соединение успешно произведено");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Server=LAPTOP-8BSFAANR\SQLEXPRESS;Database=Students;Trusted_Connection=Yes;");
            if (textBoxLogin.Text.ToString() != "" && textBoxPassword.Text.ToString() != "")
            {
                SqlConnection conn = new SqlConnection(@"Server=LAPTOP-8BSFAANR\SQLEXPRESS; Database=Students; integrated security = True; User ID = " + textBoxLogin.Text.ToString() + "; Password = " + textBoxPassword.ToString() + ";");

                /*string Name = textBoxLogin.Text.ToString();
                string pass = "";
                string Level = "";
                string getP = "SELECT Password, Level, UserID FROM Users WHERE Name = @Name";

                SqlCommand commandBrands = new SqlCommand(getP, conn);

                commandBrands.Parameters.AddWithValue("@Name", Name);

                using (SqlDataReader reader = commandBrands.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pass = reader["Password"].ToString();
                        Level = reader["Level"].ToString();
                        UserID = Convert.ToInt32(reader["UserID"]);
                    }
                }*/
                /*if (pass == textBoxPassword.Text.ToString())
                {
                    LoginName = textBoxLogin.Text;

                    this.Size = new System.Drawing.Size(1105, 469);
                    this.MaximumSize = new System.Drawing.Size(1105, 469);
                    this.MinimumSize = new System.Drawing.Size(1105, 469);

                    if (Level == "0") root = false;
                    else root = true;
                    */
                Hide();
                MainForm mainForm = new MainForm(true, 1, conn);
                    mainForm.ShowDialog();
                this.Close();
                //}
                //else MessageBox.Show("Что-то введено не так!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=LAPTOP-8BSFAANR\SQLEXPRESS;Database=Students;Trusted_Connection=Yes;");
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("sp_addlogin", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@loginame"; param.Value = textBoxLogin.Text.ToString(); param.SqlDbType = SqlDbType.Text; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@passwd"; param.Value = textBoxPassword.Text.ToString(); param.SqlDbType = SqlDbType.Text; cmd.Parameters.Add(param);
                
                Console.WriteLine("Вставляем запись");
                try
                {
                    cmd.ExecuteNonQuery();

                    //LoginName = textBoxLogin.Text;
                }
                catch (Exception se)
                {
                    Console.WriteLine("Ошибка подключения: {0}", se.Message);
                    return;
                }
            }

            conn.Close();
            /*bool flag = false;

            conn.Open();
            if (textBoxLogin.Text.ToString() != "" && textBoxPassword.Text.ToString() != "")
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Users" +
                    "(Name,Password,Level) Values (@Name,@Password,@Level)", conn))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Name"; param.Value = textBoxLogin.Text.ToString(); param.SqlDbType = SqlDbType.Text; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Password"; param.Value = textBoxPassword.Text.ToString(); param.SqlDbType = SqlDbType.Text; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Level"; param.Value = 0; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);

                    Console.WriteLine("Вставляем запись");
                    try
                    {
                        cmd.ExecuteNonQuery();
                        flag = true;

                        LoginName = textBoxLogin.Text;
                    }
                    catch (Exception se)
                    {
                        Console.WriteLine("Ошибка подключения: {0}", se.Message);
                        return;
                    }
                }
            else MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (flag == true)
                using (SqlCommand sqlout = new SqlCommand("SELECT UserID FROM Users WHERE Name = @Name", conn))
                {
                    SqlParameter param2 = new SqlParameter();
                    param2.ParameterName = "@Name"; param2.Value = textBoxLogin.Text.ToString(); param2.SqlDbType = SqlDbType.VarChar; sqlout.Parameters.Add(param2);

                    try
                    {
                        sqlout.ExecuteNonQuery();
                    }
                    catch (Exception se)
                    {
                        Console.WriteLine("Ошибка подключения: {0}", se.Message);
                        return;
                    }
                    UserID = (int)sqlout.ExecuteScalar();

                    Hide();
                    MainForm mainForm = new MainForm(root, 1);
                    mainForm.ShowDialog();
                    this.Close();
                }*/
        }
    }
}