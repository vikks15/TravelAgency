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
        SqlConnection conn;
        SqlDataReader rdr;
        public ManagerForm()
        {
            InitializeComponent();
            ChooseTourGridView.AllowUserToAddRows = false;
            ChooseTourGridView.ReadOnly = true;
            ChooseTourGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ChooseTourGridView.ColumnHeadersVisible = true;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (rdr != null) rdr.Close();
            if (conn != null) conn.Close();
            this.Hide();
            LoginForm newHeadForm = new LoginForm();
            newHeadForm.Closed += (s, args) => this.Close();
            newHeadForm.Show();
        }

        private void TourInfoButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "Информация о турах";            
            string[] headerNames;
            string query = "", tableName = "";
            int numOfColumns = 10;
            ChooseTourGridView.ColumnCount = 10;

            query = @"SELECT IdTour, Country, City, BeginDate, EndDate, Price, TourOpName, AirlineName, AcName, CompanyName
                      FROM Tour, TourOperator, Airline, Accommodation, Insurance
                      WHERE (TourOpId = IdTourOperator) AND (AirlineId = IdAirline) AND (AccommodationId = IdAccommodation) AND (InsuranceId = IdInsurance)";
            headerNames = new string[] { "ID", "Страна", "Город, место", "Дата начала", "Дата окончания", "Цена", "Туроператор", "Авиакомпания", "Проживание", "Страховка" };
            tableName = "TourTable";


            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            conn = new SqlConnection(way);
            conn.Open();
            SqlCommand firstcommand = new SqlCommand(query, conn);
            rdr = firstcommand.ExecuteReader();

            for (int i = 0; i < numOfColumns; ++i)
                ChooseTourGridView.Columns[i].Name = headerNames[i];

            string[] tableString = new string[numOfColumns];
            try
            {
                while (rdr.Read())
                {
                    for (int i = 0; i < numOfColumns; ++i)
                    {
                        if (i == 3 || i == 4)
                        {
                            DateTime tmp = Convert.ToDateTime(rdr[i]);
                            tableString[i] = tmp.ToShortDateString();
                        }
                        else tableString[i] = rdr[i].ToString();
                    }

                    ChooseTourGridView.Rows.Add(tableString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }

        }

        private void AirlineInfo_Click(object sender, EventArgs e)
        {

        }

    }
}
