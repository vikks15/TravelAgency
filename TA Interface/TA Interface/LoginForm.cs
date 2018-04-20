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
            string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
            SqlConnection conn = new SqlConnection(way);
            conn.Open();
            SqlCommand askLogin = new SqlCommand("SELECT * from LoginPassword", conn);
            SqlDataReader rdr = askLogin.ExecuteReader();

            /*while (rdr.Read())
            {
                comboBox1.Items.Add(rdr[1]);
            }*/

            string[] users = { "Руководитель", "Менеджер", "Турист" };
            UserComboBox.Items.AddRange(users);

            if (rdr != null) rdr.Close();
            if (conn != null) conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((UserComboBox.Text != "Руководитель") && (UserComboBox.Text != "Менеджер") && (UserComboBox.Text != "Турист"))
            {
                MessageBox.Show("Неправильно выбран пользователь!");
            }
            else
            {
                string way = "Data Source=VICKY-PC\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True";
                SqlConnection conn = new SqlConnection(way);
                conn.Open();
                SqlCommand askLogin = new SqlCommand("SELECT * from LoginPassword", conn);
                SqlDataReader rdr = askLogin.ExecuteReader();

                if (UserComboBox.Text == "Руководитель" && PasswordTextBox.Text == "1")
                {
                    this.Hide();
                    HeadForm newHeadForm = new HeadForm();
                    newHeadForm.Closed += (s, args) => this.Close();
                    newHeadForm.Show();

                }
                else if (UserComboBox.Text == "Менеджер" && PasswordTextBox.Text == "2")
                {
                    this.Hide();
                    ManagerForm newManagerForm = new ManagerForm();
                    newManagerForm.Closed += (s, args) => this.Close();
                    newManagerForm.Show();

                }
                else if (UserComboBox.Text == "Турист" && PasswordTextBox.Text == "3")
                {
                    this.Hide();
                    TouristForm newTouristForm = new TouristForm();
                    newTouristForm.Closed += (s, args) => this.Close();
                    newTouristForm.Show();
                }
                else MessageBox.Show("Неверный пароль или фамилия");

                if (rdr != null) rdr.Close();
                if (conn != null) conn.Close();
            }
        }
    }
}
