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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            string[] users = { "Руководитель", "Менеджер", "Турист" };
            UserComboBox.Items.AddRange(users);
            //touristForm = tour_form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            string tableName = null;

            if (UserComboBox.Text == "Руководитель" || UserComboBox.Text == "Менеджер")
                tableName = "SELECT * FROM Staff";
            else if (UserComboBox.Text == "Турист")
                tableName = "SELECT * FROM TouristGroup";
            else
            {
                MessageBox.Show("Неправильно выбран пользователь!");
                return;
            }
  
            SqlConnection conn = new SqlConnection(way);
            conn.Open();
            SqlCommand askLogin = new SqlCommand(tableName, conn);
            SqlDataReader rdr = askLogin.ExecuteReader();

            string password = null;
            while (rdr.Read())
            {
                if (UserComboBox.Text == rdr[1].ToString() && LastNameTextBox.Text == rdr[3].ToString())
                    password = rdr[4].ToString(); //check User with this Lastname
                else if (UserComboBox.Text == "Турист" && LastNameTextBox.Text == rdr[2].ToString())
                    password = rdr[0].ToString(); //tourist password = num of group
            }

            if (password == null)
            {
                MessageBox.Show("Данного пользователя не существует.");
                return;
            }
            else if (password != PasswordTextBox.Text)
            {
                MessageBox.Show("Неверный пароль!");
                return;
            }

            switch (UserComboBox.Text)
            {
                case "Руководитель":
                    {
                        this.Hide();
                        HeadForm newHeadForm = new HeadForm();
                        newHeadForm.Closed += (s, args) => this.Close();
                        newHeadForm.Show();
                        break;
                    }
                case "Менеджер":
                    {
                        this.Hide();
                        ManagerForm newManagerForm = new ManagerForm();
                        newManagerForm.Closed += (s, args) => this.Close();
                        newManagerForm.Show();
                        break;
                    }
                case "Турист":
                    {
                        TouristForm touristForm = new TouristForm(this);
                        this.Hide();
                        /*TouristFormMenu newTouristFormMenu = new TouristFormMenu(touristForm);
                        newTouristFormMenu.Closed += (s, args) => this.Close();
                        newTouristFormMenu.Show();*/
                        touristForm.Closed += (s, args) => this.Close();
                        touristForm.Show();
                        break;
                    }
            }
            if (rdr != null) rdr.Close();
            if (conn != null) conn.Close();
        }
    }
}
