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
    public partial class Users : Form
    {
        SqlConnection conn;

        public Users(SqlConnection conn)
        {
            InitializeComponent();

            this.conn = conn;
        }

        private void buttonUserReg_Click(object sender, EventArgs e)
        {
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

        private void buttonUserRole_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("sp_addrolemember", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@rolename"; param.Value = textBoxUserRole.Text.ToString(); param.SqlDbType = SqlDbType.Text; cmd.Parameters.Add(param);
                param = new SqlParameter();
                param.ParameterName = "@membername"; param.Value = textBoxUserName.Text.ToString(); param.SqlDbType = SqlDbType.Text; cmd.Parameters.Add(param);

                Console.WriteLine("Даем роль");
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

        private void buttonUserDel_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("sp_droplogin", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@loginame"; param.Value = textBoxUserNameDel.Text.ToString(); param.SqlDbType = SqlDbType.Text; cmd.Parameters.Add(param);
                
                Console.WriteLine("Удаляем");
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
