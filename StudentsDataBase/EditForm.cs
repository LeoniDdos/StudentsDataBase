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
    public partial class EditForm : Form
    {
        SqlConnection conn;
        int studID;

        public EditForm(int studID, SqlConnection conn)
        {
            InitializeComponent();

            this.studID = studID;
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
            dt.Load(reader);

            comboBoxStudGroup.ValueMember = "GroupID";
            comboBoxStudGroup.DisplayMember = "Name";
            comboBoxStudGroup.DataSource = dt;


            sc = new SqlCommand("SELECT OtdelID FROM Otdels", conn);

            reader = sc.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("OtdelID", typeof(string));
            dt.Load(reader);

            comboBoxChooseOtd.ValueMember = "OtdelID";
            comboBoxChooseOtd.DisplayMember = "OtdelID";
            comboBoxChooseOtd.DataSource = dt;


            sc = new SqlCommand("SELECT GroupID, Name FROM Groups", conn);

            reader = sc.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("GroupID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Load(reader);

            comboBoxChooseGrp.ValueMember = "GroupID";
            comboBoxChooseGrp.DisplayMember = "Name";
            comboBoxChooseGrp.DataSource = dt;

            conn.Close();
        }

        private void buttonEditOtdelenie_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("sp_EditOtdelenie", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Manager"; param.Value = textBoxOtdManager.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@Telephone"; param.Value = textBoxOtdTelephone.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@OtdelID"; param.Value = comboBoxChooseOtd.SelectedIndex + 1; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);

                Console.WriteLine("Изменяем запись");
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно изменены", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception se)
                    {
                        Console.WriteLine("Ошибка: {0}", se.Message);
                        conn.Close();
                        return;
                    }
                }
            }
            conn.Close();
            Close();
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("sp_EditGroup", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Name"; param.Value = textBoxGrpName.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@Faculty"; param.Value = textBoxGrpFaculty.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@Curator"; param.Value = textBoxGrpFaculty.Text.ToString(); param.SqlDbType = SqlDbType.VarChar; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@OtdelID"; param.Value = comboBoxGrpOtdelenie.SelectedIndex + 1; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@GroupID"; param.Value = comboBoxChooseGrp.SelectedIndex + 1; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);

                Console.WriteLine("Изменяем запись");
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно изменены", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception se)
                    {
                        Console.WriteLine("Ошибка: {0}", se.Message);
                        conn.Close();
                        return;
                    }
                }
            }
            conn.Close();
            Close();
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("sp_EditStudent", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
                param = new SqlParameter();
                param.ParameterName = "@StudentID"; param.Value = studID; param.SqlDbType = SqlDbType.Int; cmd.Parameters.Add(param);

                Console.WriteLine("Изменяем запись");
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно изменены", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception se)
                    {
                        Console.WriteLine("Ошибка: {0}", se.Message);
                        conn.Close();
                        return;
                    }
                }
            }
            conn.Close();
            Close();
        }
    }
}