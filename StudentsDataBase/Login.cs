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
        bool root = false;

        public Login()
        {
            InitializeComponent();
        }

        private static void CreateNewTable()
        {
            SqlConnection conn = new SqlConnection(@"Server=LAPTOP-8BSFAANR\SQLEXPRESS;Database=Students;Trusted_Connection=Yes;");
            conn.Open();

            string CreateOtdels = "CREATE TABLE Otdels (OtdelID int IDENTITY(1,1) PRIMARY KEY, Manager VarChar(30) not null, Telephone VarChar(30) not null); ";
            string CreateGroups = "CREATE TABLE Groups (GroupID int IDENTITY(1,1) PRIMARY KEY, Name VarChar(30) not null, Faculty VarChar(30) not null, Curator VarChar(30) not null, StudCount int not null, OtdelID int FOREIGN KEY REFERENCES Otdels(OtdelID)); ";
            string CreateStudents = "CREATE TABLE Students (StudentID int IDENTITY(1,1) PRIMARY KEY, Surname VarChar(30) not null, Name VarChar(30) not null, Patronymic VarChar(30), Birthday VarChar(30), GroupID int FOREIGN KEY REFERENCES Groups(GroupID))";
            string CreateLogs = "CREATE TABLE Logs (LogID int IDENTITY(1,1) PRIMARY KEY, UserName VarChar(30) not null, ActionName VarChar(30) not null, TableName VarChar(30) not null, ObjectID int not null, NewData VarChar(30) not null, ActDate DateTime not null)";
            string CreateComLogs = "CREATE TABLE CompessionLogs (LogID int IDENTITY(1,1) PRIMARY KEY, UserName VarChar(30) not null, ActionName VarChar(30) not null, TableName VarChar(30) not null, IDs VarChar(MAX) not null, LogData VarChar(MAX))";


            using (SqlCommand cmdCreateTable = new SqlCommand(CreateOtdels + CreateGroups + CreateStudents + CreateLogs, conn))
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
            if (textBoxLogin.Text.ToString() != "" && textBoxPassword.Text.ToString() != "")
            {
                SqlConnection conn = new SqlConnection(@"Persist Security Info=False;User ID=" + textBoxLogin.Text + ";Password=" + textBoxPassword.Text + ";Initial Catalog=Students;Server=LAPTOP-8BSFAANR\\SQLEXPRESS");

                try
                {
                    conn.Open();
                    conn.Close();
                    Hide();
                    MainForm mainForm = new MainForm(true, 1, conn);
                    mainForm.ShowDialog();
                    this.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Что-то введено не так!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                }
                catch (Exception se)
                {
                    Console.WriteLine("Ошибка подключения: {0}", se.Message);
                    return;
                }
            }
            conn.Close();
        }
    }
}