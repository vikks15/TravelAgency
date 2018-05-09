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
    public partial class TouristForm : Form
    {
        LoginForm logForm;
        SqlConnection conn;
        SqlDataReader dataReader;
        SqlDataAdapter adap;
        DataSet data;
        string[] headerNames;
        string query = "";

        public TouristForm(LoginForm log_f)
        {
            InitializeComponent();
            logForm = log_f;
           
            label1.Text = logForm.LastNameTextBox.Text;

            string[] headerNames;
            int numOfColumns = 7;
            OrdersGridView.ColumnCount = 7;
            string groupIdNum = logForm.PasswordTextBox.Text;

            string query = @"SELECT GroupId, Country, City, BeginDate, EndDate, AcName, (Price * NumberOfTourists) AS TotalPrice
            FROM Tour, Accommodation, Orders, TouristGroup
            WHERE (GroupId = " + groupIdNum +") AND (TourId=IdTour) AND (AccommodationId=IdAccommodation) AND (IdGroup=GroupId)";

            headerNames = new string[] { "ID", "Страна", "Город, место", "Дата начала", "Дата окончания", "Место проживания", "Итоговая цена"};

            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            conn = new SqlConnection(way);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            dataReader = command.ExecuteReader();

            for (int i = 0; i < numOfColumns; ++i)
                OrdersGridView.Columns[i].Name = headerNames[i];

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

                    OrdersGridView.Rows.Add(tableString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
            conn.Close();
            dataReader.Close();            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm newForm = new LoginForm();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void TouristInfoTab_Click(object sender, EventArgs e)
        {
            TouristGridView.ColumnHeadersVisible = true;
            int numOfColumns = 8;
            string groupIdNum = logForm.PasswordTextBox.Text;
            headerNames = new string[] { "ID", "Номер группы", "Фамилия", "Имя", "Номер паспорта", "Дата рождения", "Телефон", "Почта" };
            query = "SELECT * FROM Tourist WHERE GroupId = " + groupIdNum;
            adap = new SqlDataAdapter(query, conn);
            data = new System.Data.DataSet();
            adap.Fill(data, "Tourists");
            TouristGridView.DataSource = data.Tables[0];
            TouristGridView.Columns[0].ReadOnly = true;
            for (int i = 0; i < numOfColumns; ++i)
                TouristGridView.Columns[i].HeaderText = headerNames[i];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int numOfColumns = 8;
            try
            {                
                SqlCommandBuilder commBuild = new SqlCommandBuilder(adap);
                adap.Update(data, "Tourists");

                //---------------Обновление------------------------------
                TouristGridView.DataSource = null;
                adap = new SqlDataAdapter(query, conn);
                data = new System.Data.DataSet();
                adap.Fill(data, "Tourists");
                TouristGridView.DataSource = data.Tables[0];
                for (int i = 0; i < numOfColumns; ++i)
                    TouristGridView.Columns[i].HeaderText = headerNames[i];
                //---------------------------------------------------------
                MessageBox.Show("Данные сохранены!");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения!");
            }
        
        }
    }
}
