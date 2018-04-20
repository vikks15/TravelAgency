using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TA_Interface
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Название";
            dataGridView1.Columns[2].Name = "Класс";

            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            SqlConnection conn = new SqlConnection(way);
            conn.Open();
            SqlCommand firstcommand = new SqlCommand("select * from Airline order by IdAirline", conn);
            SqlDataReader rdr = firstcommand.ExecuteReader();

            try
            {
                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
            }
            finally
            {
                // Always call Close when done reading.
                rdr.Close();
            }

            if (conn != null) conn.Close();
        }
    }
}
