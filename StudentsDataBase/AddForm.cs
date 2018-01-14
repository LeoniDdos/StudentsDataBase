using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDataBase
{
    public partial class AddForm : Form
    {
        SqlConnection conn;

        public AddForm(SqlConnection conn)
        {
            InitializeComponent();

            this.conn = conn;

            DataRefresh();
        }

        private void DataRefresh()
        {
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT OtdelID FROM Otdels", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("OtdelID", typeof(string));
            dt.Load(reader);

            comboBoxGrpOtdelenie.ValueMember = "OtdelID";
            comboBoxGrpOtdelenie.DisplayMember = "OtdelID";
            comboBoxGrpOtdelenie.DataSource = dt;


            sc = new SqlCommand("SELECT GroupID, Name FROM Groups", conn);
            
            reader = sc.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("GroupID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("OtdelID", typeof(string));
            dt.Load(reader);

            comboBoxStudGroup.ValueMember = "GroupID";
            comboBoxStudGroup.DisplayMember = "Name";
            comboBoxStudGroup.DataSource = dt;

            conn.Close();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxStudSurname.Text.ToString() != "" && textBoxStudName.Text.ToString() != "" && textBoxStudPatronymic.Text.ToString() != "" && textBoxStudBirthday.Text.ToString() != "")
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Insert into Students" +
                            "(Surname, Name, Patronymic, Birthday, GroupID) Values (@Surname, @Name, @Patronymic, @Birthday, @GroupID)", conn))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Surname"; param.Value = textBoxStudSurname.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Name"; param.Value = textBoxStudName.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Patronymic"; param.Value = textBoxStudPatronymic.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Birthday"; param.Value = textBoxStudBirthday.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@GroupID"; param.Value = comboBoxStudGroup.SelectedIndex + 1; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);

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

                MessageBox.Show("Данные успешно введены", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                textBoxStudSurname.Text = "";
                textBoxStudName.Text = "";
                textBoxStudPatronymic.Text = "";
                textBoxStudBirthday.Text = "";
            }
            else MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if (textBoxGrpName.Text.ToString() != "" && textBoxGrpCurator.Text.ToString() != "" && textBoxGrpFaculty.Text.ToString() != "")
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Insert into Groups" +
                            "(Name, Curator, Faculty, StudCount, OtdelID) Values (@Name, @Curator, @Faculty, @StudCount, @OtdelID)", conn))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Name"; param.Value = textBoxGrpName.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Curator"; param.Value = textBoxGrpCurator.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Faculty"; param.Value = textBoxGrpFaculty.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@StudCount"; param.Value = 0; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@OtdelID"; param.Value = comboBoxGrpOtdelenie.SelectedIndex + 1; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);
                   
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
                MessageBox.Show("Данные успешно введены", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                textBoxGrpName.Text = "";
                textBoxGrpCurator.Text = "";
                textBoxGrpFaculty.Text = "";

                DataRefresh();
            }
            else MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAddOtdelenie_Click(object sender, EventArgs e)
        {
            if (textBoxOtdManager.Text.ToString() != "" && textBoxOtdTelephone.Text.ToString() != "")
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Insert into Otdels" +
                            "(Manager, Telephone) Values (@Manager, @Telephone)", conn))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@Manager"; param.Value = textBoxOtdManager.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                    param = new SqlParameter();
                    param.ParameterName = "@Telephone"; param.Value = textBoxOtdTelephone.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
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
                MessageBox.Show("Данные успешно введены", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

                textBoxOtdManager.Text = "";
                textBoxOtdTelephone.Text = "";

                DataRefresh();
            }
            else MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
