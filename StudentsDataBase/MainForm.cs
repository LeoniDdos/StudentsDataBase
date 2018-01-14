﻿using System;
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

            var selectBooks = "SELECT StudentID as ID, CONCAT (Students.Surname, ' ', Left (Students.Name,1), '. ', Left (Students.Patronymic,1), '.') as ФИО, Groups.Name as Группа, Students.Birthday as Дата_рождения, Groups.Faculty as Факультет FROM Students INNER JOIN Groups ON Groups.GroupID = Students.GroupID";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(
            selectBooks, conn))
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
    }
}