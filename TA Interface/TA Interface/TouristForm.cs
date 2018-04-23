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

        public TouristForm(LoginForm log_f)
        {
            InitializeComponent();
            logForm = log_f;
           
            label1.Text = logForm.LastNameTextBox.Text;

            string[] headerNames;
            int numOfColumns = 7;
            OrdersGridView.ColumnCount = 7;

            string query = @"SELECT GroupId, Country, City, BeginDate, EndDate, AcName, (Price*2) AS TotalPrice
                             FROM Tour, Accommodation, Orders
                             WHERE GroupId = '2' AND TourId=IdTour AND AccommodationId=IdAccommodation";

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
    }
}
