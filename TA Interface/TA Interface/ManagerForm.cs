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
        SqlDataReader dataReader;
        public ManagerForm()
        {
            InitializeComponent();
            ChooseTourGridView.AllowUserToAddRows = false;
            ChooseTourGridView.ReadOnly = true;
            ChooseTourGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ChooseTourGridView.ColumnHeadersVisible = true;

            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            string countryQuery = "SELECT DISTINCT Country FROM Tour";
            List<string> countriesList = new List<string>();

            conn = new SqlConnection(way);
            conn.Open();
            SqlCommand command = new SqlCommand(countryQuery, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                countriesList.Add(dataReader[0].ToString());
            }             
            ComboBoxCountry.Items.AddRange(countriesList.ToArray());
            conn.Close();
            dataReader.Close();
        }

        private void TourInfoButton_Click(object sender, EventArgs e)
        {
            ChooseTourGridView.Rows.Clear();
            HeaderLabel.Text = "Найденные туры";
            string[] headerNames;            
            int numOfColumns = 10;
            ChooseTourGridView.ColumnCount = 10;

            string query = @"SELECT IdTour, Country, City, BeginDate, EndDate, Price, TourOpName, AirlineName, AcName, CompanyName
                     FROM Tour, TourOperator, Airline, Accommodation, Insurance
                     WHERE (TourOpId = IdTourOperator) AND (AirlineId = IdAirline) AND (AccommodationId = IdAccommodation) AND (InsuranceId = IdInsurance)";

            headerNames = new string[] { "ID", "Страна", "Город, место", "Дата начала", "Дата окончания", "Цена", "Туроператор", "Авиакомпания", "Проживание", "Страховка" };

            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            conn = new SqlConnection(way);
            conn.Open();
            SqlCommand firstcommand = new SqlCommand(query, conn);
            dataReader = firstcommand.ExecuteReader();

            for (int i = 0; i < numOfColumns; ++i)
                ChooseTourGridView.Columns[i].Name = headerNames[i];

            string[] tableString = new string[numOfColumns];
            try
            {
                while (dataReader.Read())
                {
                    for (int i = 0; i < numOfColumns; ++i)
                    {
                        if (i == 3 || i == 4)
                        {
                            DateTime tmp = Convert.ToDateTime(dataReader[i]);
                            tableString[i] = tmp.ToShortDateString();
                        }
                        else tableString[i] = dataReader[i].ToString();
                    }

                    ChooseTourGridView.Rows.Add(tableString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
            conn.Close();
            dataReader.Close();
        }    

        private void SearchTourButton_Click(object sender, EventArgs e)
        {
            ChooseTourGridView.Rows.Clear();
            HeaderLabel.Text = "Найденные туры";
            string[] headerNames;
            string query = "", tableName = "";
            int numOfColumns = 5;
            ChooseTourGridView.ColumnCount = 5;

            //----------------------------------------------------------------------------------------
            string theDate1 = dateTimePicker1.Value.ToString("yyyyMMdd");
            string theDate2 = dateTimePicker2.Value.ToString("yyyyMMdd");
            query = "SELECT IdTour, Country, BeginDate, EndDate, (Price*";
            query += numOfTouristsField.Value;
            query += ") AS TotalPrice FROM Tour WHERE Country = '";
            query += ComboBoxCountry.Text + "' AND BeginDate = '" + theDate1 + "' AND EndDate = '" + theDate2 + "'";
            //------------------------------------------------------------------------------------------
           
            headerNames = new string[] { "ID", "Страна", "Дата начала", "Дата окончания", "Итоговая цена" };
            tableName = "TourTable";

            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            conn = new SqlConnection(way);
            conn.Open();
            SqlCommand firstcommand = new SqlCommand(query, conn);
            dataReader = firstcommand.ExecuteReader();

            for (int i = 0; i < numOfColumns; ++i)
                ChooseTourGridView.Columns[i].Name = headerNames[i];

            string[] tableString = new string[numOfColumns];
            try
            {
                while (dataReader.Read())
                {
                    for (int i = 0; i < numOfColumns; ++i)
                    {
                        if (i == 2 || i == 3)
                        {
                            DateTime tmp = Convert.ToDateTime(dataReader[i]);
                            tableString[i] = tmp.ToShortDateString();
                        }
                        else tableString[i] = dataReader[i].ToString();
                    }

                    ChooseTourGridView.Rows.Add(tableString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
            conn.Close();
            dataReader.Close();
        }


        private void ExtendedSearchButton_Click(object sender, EventArgs e)
        {
            ExtendedSearch window = new ExtendedSearch(this);
            window.Show();

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (dataReader != null) dataReader.Close();
            if (conn != null) conn.Close();
            this.Hide();
            LoginForm newHeadForm = new LoginForm();
            newHeadForm.Closed += (s, args) => this.Close();
            newHeadForm.Show();
        }

    }
}
