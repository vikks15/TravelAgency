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
        SqlDataReader dataReader;
        string tableName;
        string[] headerNames;
        string query = "";
        int numOfColumns = 0;
      
        public HeadForm()
        {
            InitializeComponent();
            string[] tables = { "Туры", "Проживание", "Авиакомпании", "Страхование", "Сотрудники"};
            TableComboBox.Items.AddRange(tables);

            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            string query1 = "SELECT DISTINCT Country FROM Tour";
            List<string> resultList = new List<string>();

            conn = new SqlConnection(way);
            conn.Open();

            SqlCommand command = new SqlCommand(query1, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                resultList.Add(dataReader[0].ToString());
            }
            ReportsComboBox.Items.AddRange(resultList.ToArray());
            resultList.Clear();
            dataReader.Close();
            //conn.Close();
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

            switch (TableComboBox.Text)
            {
                case "Туры":
                    {                        
                        TableNameLabel.Text = "Туры";                        
                        query = "SELECT * FROM Tour";  
                        headerNames = new string[] { "ID", "Страна", "Город, место", "Дата начала", "Дата окончания", "Цена", "Туроператор", "Авиакомпания", "Проживание", "Страховка" };
                        tableName = "TourTable";
                        numOfColumns = 10;                    
                       
                        /*GridViewPage1.ColumnCount = 10;
                        GridViewPage1.Columns[8].Width = 250;    
                        for (int i = 0; i < GridViewPage1.ColumnCount; ++i)
                            GridViewPage1.Columns[i].Name = tmp[i];*/                      
                        break;
                    }

                case "Проживание":
                    {
                        TableNameLabel.Text = "Проживание";
                        query = "SELECT * FROM Accommodation";
                        headerNames = new string[]{ "ID", "Название", "Категория", "Количество звезд", "Питание", "Опции", "Телефон", "Адрес" };
                        tableName = "AcTable";
                        numOfColumns = 8;                        
                        break;
                    }
                case "Авиакомпании":
                    {
                        TableNameLabel.Text = "Авиакомпании";
                        query = "SELECT * FROM Airline Order By IdAirline";
                        headerNames = new string[]{ "ID", "Название", "Класс" };
                        tableName = "AirlineTable";
                        numOfColumns = 3;                       
                        break;
                    }
                case "Страхование":
                    {
                        TableNameLabel.Text = "Страхование";
                        query = "SELECT * FROM Insurance Order By IdInsurance";
                        headerNames = new string[]{ "ID", "Название компании", "Тип тура", "Категория страхования" };
                        tableName = "InsuranceTable";
                        numOfColumns = 4;                        
                        break;
                    }
                case "Сотрудники":
                    {
                        TableNameLabel.Text = "Сотрудники";
                        query = "SELECT * FROM Staff Order By IdLoginPassword";
                        headerNames = new string[] { "ID", "Должность", "Имя", "Фамилия" };
                        tableName = "StaffTable";
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
                GridViewPage1.Columns[0].ReadOnly = true;

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
            if (TableNameLabel.Text != TableComboBox.Text)
            {
                MessageBox.Show("Для сохранения переключитесь на нужную таблицу.");
                return;
            }

            try
            {                
                commBuild = new SqlCommandBuilder(adap);
                adap.Update(data, tableName);
                //---------------Обновление------------------------------
                GridViewPage1.DataSource = null;
                adap = new SqlDataAdapter(query, conn);
                data = new System.Data.DataSet();
                adap.Fill(data, tableName);
                GridViewPage1.DataSource = data.Tables[0];
                for (int i = 0; i < numOfColumns; ++i)
                    GridViewPage1.Columns[i].HeaderText = headerNames[i];
                //---------------------------------------------------------
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
            this.Hide();
            LoginForm newHeadForm = new LoginForm();
            newHeadForm.Closed += (s, args) => this.Close();
            newHeadForm.Show();
        }

        private void ReportsPage_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }     

        private void report1Button_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Заказы за период";
            string fromDate = dateTimePicker1.Value.ToString("yyyyMMdd");
            string toDate = dateTimePicker2.Value.ToString("yyyyMMdd");
            headerNames = new string[] { "ID", "Страна", "Город", "Дата заказа", "Статус оплаты" };
            query = @"SELECT IdOrders, Country, City, OrderDate, PaymentStatus FROM Orders, Tour
            WHERE (TourId=IdTour) AND (OrderDate BETWEEN '" + fromDate + "' AND '" + toDate + "')";

            adap = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap.Fill(data, "OrdersCount");
            TourOpGridView.DataSource = data.Tables[0];
            TourOpGridView.ReadOnly = true;
            for (int i = 0; i < 5; ++i)
                TourOpGridView.Columns[i].HeaderText = headerNames[i];
            conn.Close();

        }

        private void report2Button_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Количество заказов за период";
            headerNames = new string[] { "Количество заказов" };
            string fromDate = dateTimePicker1.Value.ToString("yyyyMMdd");
            string toDate = dateTimePicker2.Value.ToString("yyyyMMdd");
            query = @"SELECT COUNT(IdOrders) AS SumOfOrders FROM Orders 
            WHERE (PaymentDate IS NOT NULL) AND (PaymentDate > '" + fromDate + "') AND (PaymentDate < '" + toDate + "')";

            adap = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap.Fill(data, "OrdersCount");
            TourOpGridView.DataSource = data.Tables[0];
            TourOpGridView.ReadOnly = true;
            for (int i = 0; i < 1; ++i)
                TourOpGridView.Columns[i].HeaderText = headerNames[i];
            conn.Close();            
        }

        private void report3Button_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Оплаченные заказы по направлениям";
            headerNames = new string[] { "ID", "Страна", "Город", "Дата начала тура", "Дата окончания тура", "Дата заказа" };

            query = @"SELECT IdOrders, Country, City, BeginDate, EndDate, OrderDate
            FROM Orders, Tour
            WHERE (TourId=IdTour) AND (Country='" + ReportsComboBox.Text + "') AND (PaymentDate IS NOT NULL)";
            adap = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap.Fill(data, "OrdersByCountry");
            TourOpGridView.DataSource = data.Tables[0];
            TourOpGridView.ReadOnly = true;
            for (int i = 0; i < 6; ++i)
                TourOpGridView.Columns[i].HeaderText = headerNames[i];
            conn.Close();
        }
        
        private void report4Button_Click(object sender, EventArgs e)
        {
            label1.Text = "Доход за период";
            headerNames = new string[] { "Количество заказов", "Страна", "Общая сумма" };

            query = @"SELECT COUNT(IdOrders) as NumOfOrders, Country, SUM(NumberOfTourists*Price) as TotalPrice
            FROM TouristGroup, Orders, Tour
            WHERE (IdTour=TourId) AND (GroupId=IdGroup)
            GROUP BY Country";
            adap = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap.Fill(data, "OrdersByCountry");
            TourOpGridView.DataSource = data.Tables[0];
            TourOpGridView.ReadOnly = true;
            for (int i = 0; i < 3; ++i)
                TourOpGridView.Columns[i].HeaderText = headerNames[i];
            conn.Close();
        }

        private void report5Button_Click(object sender, EventArgs e)
        {
            label1.Text = "Доход по направлению";
            headerNames = new string[] { "Количество заказов", "Страна", "Общая сумма"};

            query = @"SELECT COUNT(IdOrders) as NumOfOrders, Country, SUM(NumberOfTourists*Price) as TotalPrice
            FROM TouristGroup, Orders, Tour
            WHERE (Country='" + ReportsComboBox.Text + "') AND (IdTour=TourId) AND (GroupId=IdGroup) GROUP BY Country";
            adap = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap.Fill(data, "OrdersByCountry");
            TourOpGridView.DataSource = data.Tables[0];
            TourOpGridView.ReadOnly = true;
            for (int i = 0; i < 3; ++i)
                TourOpGridView.Columns[i].HeaderText = headerNames[i];
            conn.Close();
        } 
    }
}
