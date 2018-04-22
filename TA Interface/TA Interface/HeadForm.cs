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
        string[] headerNames;
        string query = "";
        int numOfColumns = 0;

        public HeadForm()
        {
            InitializeComponent();
            string[] tables = { "Туры", "Проживание", "Авиакомпании", "Страхование" };
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

                case "Проживаниие":
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
    }
}
