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
    public partial class MainForm : Form
    {
        SqlConnection conn;

        public MainForm(bool root, int flag, SqlConnection conn)
        {
            InitializeComponent();

            if (root == false)
            {
                buttonAdd.Visible = false;
                buttonEdit.Visible = false;
            }

            if (flag == 0)
            {
                Login loginForm = new Login();
                loginForm.ShowDialog();
            }

            this.conn = conn;
        }

        public MainForm(bool root, int flag)
        {
            InitializeComponent();

            if (root == false)
            {
                buttonAdd.Visible = false;
                buttonEdit.Visible = false;
            }

            if (flag == 0)
            {
                Login loginForm = new Login();
                loginForm.ShowDialog();
            }
        }

        public void RefreshData()
        {
            conn.Open();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(
            "sp_ShowStudents", conn))
            {
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridViewStudents.DataSource = dt.DefaultView;
            }
            conn.Close();

            DataGridViewColumn column = dataGridViewStudents.Columns[0];
            column.Width = 25;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();   
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(conn);
            addForm.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new EditForm(dataGridViewStudents.CurrentCell.RowIndex + 1, conn);
                editForm.ShowDialog();
            }
            catch (Exception se)
            {
                Console.WriteLine("Ошибка: {0}", se.Message);
                MessageBox.Show("Выберите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users(conn);
            usersForm.ShowDialog();
        }

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            Logs logsForm = new Logs(conn);
            logsForm.ShowDialog();
        }
    }
}
