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
        SqlDataAdapter adap, adap1, adap2, adap3;
        DataSet data, data1, data2, data3;
        string[] headerNames;
        string query = "";
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
            //conn.Close();
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

        private void LoadTablesButton_Click(object sender, EventArgs e)
        {
            TouristGridView.ColumnHeadersVisible = true; 
            int numOfColumns = 8;
            headerNames = new string[] { "ID", "Номер группы", "Фамилия", "Имя", "Номер паспорта","Дата рождения","Телефон","Почта"};
            query = "SELECT * FROM Tourist";
            adap1 = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap1.Fill(data, "Tourists");
            TouristGridView.DataSource = data.Tables[0];
            TouristGridView.Columns[0].ReadOnly = true;
            for (int i = 0; i < numOfColumns; ++i)
                TouristGridView.Columns[i].HeaderText = headerNames[i];
            
            //---------------------------------------------------------------
            GroupGridView.ColumnHeadersVisible = true; 
            numOfColumns = 6;
            headerNames = new string[] { "ID", "Количество туристов", "Фамилия заказчика", "Имя заказчика", "Телефон заказчика", "Почта заказчика"};
            query = "SELECT * FROM TouristGroup";
            adap2 = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap2.Fill(data, "TouristGroups");
            GroupGridView.DataSource = data.Tables[0];
            GroupGridView.Columns[0].ReadOnly = true;
            for (int i = 0; i < numOfColumns; ++i)
                GroupGridView.Columns[i].HeaderText = headerNames[i];

            //---------------------------------------------------------------
            OrdersGridView.ColumnHeadersVisible = true; 
            numOfColumns = 7;
            headerNames = new string[] { "ID", "ID Тура", "Номер группы", "Дата заказа", "Дата оплаты", "Статус", "Статус оплаты" };
            query = "SELECT * FROM Orders";
            adap = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap.Fill(data, "Orders");
            OrdersGridView.DataSource = data.Tables[0];
            OrdersGridView.Columns[0].ReadOnly = true;
            for (int i = 0; i < numOfColumns; ++i)
                OrdersGridView.Columns[i].HeaderText = headerNames[i];
        }

        private void MakeOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commBuild3 = new SqlCommandBuilder(adap2);
                adap2.Update(data, "TouristGroups");
                SqlCommandBuilder commBuild2 = new SqlCommandBuilder(adap1);
                adap1.Update(data, "Tourist");   
                SqlCommandBuilder commBuild= new SqlCommandBuilder(adap);
                adap.Update(data, "Orders");    
                MessageBox.Show("Данные сохранены!");
            }
            catch
            {
                MessageBox.Show("Ошибка оформения заказа!");
            }
        
        }

    }
}
