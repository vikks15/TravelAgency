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
    public partial class ExtendedSearch : Form
    {
        ManagerForm MForm;
        SqlConnection conn;
        SqlDataReader dataReader;

        public ExtendedSearch(ManagerForm M_Form)
        {
            InitializeComponent();
            MForm = M_Form; //для передачи в другую форму

            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            string query1 = "SELECT DISTINCT Country FROM Tour";
            string query2 = "SELECT City FROM Tour";
            List<string> resultList = new List<string>();

            conn = new SqlConnection(way);
            conn.Open();

            SqlCommand command = new SqlCommand(query1, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                resultList.Add(dataReader[0].ToString());
            }
            сomboBoxCountry.Items.AddRange(resultList.ToArray());
            resultList.Clear();
            dataReader.Close();

            command = new SqlCommand(query2, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                resultList.Add(dataReader[0].ToString());
            }
            comboBoxCity.Items.AddRange(resultList.ToArray());
            dataReader.Close();
            conn.Close();

            string[] typeOfAccommodation = { "Отель", "Апартаменты", "Апарт-Отель" };
            comboBoxAcType.Items.AddRange(typeOfAccommodation);
        }

        private void SearchTourButton_Click(object sender, EventArgs e)
        {

            MForm.label8.Text = comboBoxCity.Text;
            this.Close();

        }
    }
}
