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
    public partial class HeadForm : Form
    {
        SqlConnection conn;
        SqlDataAdapter adap;
        DataSet data;
        SqlCommandBuilder commBuild;
        string tableName;

        public HeadForm()
        {
            InitializeComponent();
            string[] tables = { "Туры", "Проживаниие", "Авиакомпании", "Страхование" };
            TableComboBox.Items.AddRange(tables);

        }

        private void Menu_SelectedIndexChanged()
        {
            MessageBox.Show(this, this.Menu.SelectedTab.Text.Trim());

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //GridViewPage1.Rows.Clear(); --вариант 1
            GridViewPage1.DataSource = null;
            GridViewPage1.ColumnHeadersVisible = true;
            string[] headerNames = new string[10];
            string query = "";
            int numOfColumns = 0;

            switch (TableComboBox.Text)
            {
                case "Туры":
                    {                        
                        TableNameLabel.Text = "Туры";
                        /*query = @"SELECT IdTour, Country, City, BeginDate, EndDate, Price, TourOpName, AirlineName, AcName, CompanyName
                                    FROM Tour, TourOperator, Airline, Accommodation, Insurance
                                    WHERE (TourOpId = IdTourOperator) AND (AirlineId = IdAirline) AND (AccommodationId = IdAccommodation) AND (InsuranceId = IdInsurance)";*/
                        query = "SELECT * FROM Tour";  
                        string[] tmp = { "ID", "Страна", "Город, место", "Дата начала", "Дата окончания", "Цена", "Туроператор", "Авиакомпания", "Проживание", "Страховка" };
                        
                        headerNames = tmp;
                        tableName = "TourTable";
                        numOfColumns = 10;                    
                       
                        /*GridViewPage1.ColumnCount = 10;
                        GridViewPage1.Columns[8].Width = 250;    
                        for (int i = 0; i < GridViewPage1.ColumnCount; ++i)
                            GridViewPage1.Columns[i].Name = tmp[i];*/                      
                        break;
                    }

                case "Проживаниие":
                    {
                        TableNameLabel.Text = "Проживание";
                        query = "SELECT * FROM Accommodation";                      
                        string[] tmp = { "ID", "Название", "Категория", "Количество звезд", "Питание", "Опции", "Телефон", "Адрес"};
                        headerNames = tmp;
                        tableName = "AcTable";
                        numOfColumns = 8;                        
                        break;
                    }
                case "Авиакомпании":
                    {
                        TableNameLabel.Text = "Авиакомпании";
                        query = "SELECT * FROM Airline Order By IdAirline";                      
                        string[] tmp = { "ID", "Название", "Класс"};
                        headerNames = tmp;
                        tableName = "AirlineTable";
                        numOfColumns = 3;                       
                        break;
                    }
                case "Страхование":
                    {
                        TableNameLabel.Text = "Страхование";
                        query = "SELECT * FROM Insurance Order By IdInsurance";
                        string[] tmp = { "ID", "Название компании", "Тип тура", "Категория страхования"};
                        headerNames = tmp;
                        tableName = "InsuranceTable";
                        numOfColumns = 4;                        
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Неправильно выбрана таблица!");
                        return;
                    }
            }

            try
            {
                string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
                conn = new SqlConnection(way);
                conn.Open();
                adap = new SqlDataAdapter(query, conn);
                data = new System.Data.DataSet();
                adap.Fill(data, tableName);
                
                GridViewPage1.DataSource = data.Tables[0];

                for (int i = 0; i < numOfColumns; ++i)
                    GridViewPage1.Columns[i].HeaderText = headerNames[i];
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
           

            //TableNameLabel.Text = data.Tables[0].Rows[0][0].ToString();
            //TourGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; - без прокрутки в сторону
 
            //------------------------------вариант 1-------------------------------------------------------------------
            /*string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";

            SqlConnection conn = new SqlConnection(way);
            conn.Open();*/
            /*SqlCommand tableContent = new SqlCommand(query, conn);
            SqlDataReader rdr = tableContent.ExecuteReader();

            string[] tableString = new string[GridViewPage1.ColumnCount];
            while (rdr.Read())
            {
                for (int i = 0; i < GridViewPage1.ColumnCount; ++i)
                    tableString[i] = rdr[i].ToString();
                GridViewPage1.Rows.Add(tableString);
            }
           
            if (rdr != null) conn.Close();
            if (conn != null) conn.Close();*/
            //---------------------------------------------------------------------------------------------------------
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                commBuild = new SqlCommandBuilder(adap);
                adap.Update(data, tableName);
                MessageBox.Show("Данные сохранены!");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения!");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (conn != null) conn.Close();
        }
    }
}
