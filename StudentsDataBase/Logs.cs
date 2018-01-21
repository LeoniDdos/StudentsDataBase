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
    public partial class Logs : Form
    {
        SqlConnection conn;

        public Logs(SqlConnection conn)
        {
            InitializeComponent();

            this.conn = conn;

            RefreshData();
        }

        public void RefreshData()
        {
            conn.Open();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(
            "sp_ShowLogs", conn))
            {
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridViewLogs.DataSource = dt.DefaultView;
            }
            conn.Close();

            DataGridViewColumn column = dataGridViewLogs.Columns[0];
            column.Width = 25;
        }
    }
}
