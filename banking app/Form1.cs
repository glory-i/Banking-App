using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace banking_app
{
    public partial class Form1 : Form
    {
        public static string first_name;
        public static string middle_name;
        public static string last_name;
        public static string account_type;
        public static int user_mpin;
        public static int user_transaction_pin;
        public static int account_number;
        public static double account_balance;
        public static string bank_name;
        public static string security_question;
        public static string answer;
        public int no_mpin_tried=0;
        public int no_tpin_tried=0;







        public Form1()
        {
            InitializeComponent();
        }

        private void create_account_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 my_form_2 = new Form2();
            my_form_2.Show();
            this.Hide();

            
        }

        private void mpin_login_button_Click(object sender, EventArgs e)
        {
            bool valid_mpin = false;
            no_mpin_tried += 1;
            try
            {

            
                int mpin = Convert.ToInt32(login_mpin_textBox.Text); 
                string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode = None";
                string query = "SELECT * from bank WHERE mpin = '" + mpin + "'";
                MySqlConnection con = new MySqlConnection(connection_string);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;

            
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    valid_mpin = true;
                    first_name = reader.GetString(0);
                    middle_name = reader.GetString(1);
                    last_name = reader.GetString(2);
                    account_type = reader.GetString(3);
                    user_mpin = reader.GetInt32(4);
                    user_transaction_pin = reader.GetInt32(5);
                    account_number = reader.GetInt32(6);
                    account_balance = reader.GetDouble(7);
                    bank_name = reader.GetString(8);
                    security_question = reader.GetString(9);
                    answer = reader.GetString(10);

                    tpin_panel.BringToFront();
                }

                else
                {
                    MessageBox.Show("INVALID MPIN ENTERED");
                }
                con.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("invalid format for mpin");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (no_mpin_tried == 3 && valid_mpin == false)
            {
                MessageBox.Show("You have entered an invalid mpin 3 times and thus you have been kicked out of the application");
                Application.Exit();
            }
        }

        private void tpin_login_button_Click(object sender, EventArgs e)
        {
            bool valid_tpin = false;
            int tpin;
            no_tpin_tried += 1;
            try
            {
                 tpin = Convert.ToInt32(tpin_login_txtbox.Text);
                if (tpin == user_transaction_pin)
                {
                    valid_tpin = true;
                    this.Hide();
                    Form4 my_form_4 = new Form4();
                    my_form_4.Show();

                }
                else
                {
                    MessageBox.Show("INVALID TRANSACTION PIN ENTERED");
                }

                
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format for tpin");
            }
            catch (Exception myex)
            {
                MessageBox.Show(myex.ToString());

            }
            if (no_tpin_tried == 3 && valid_tpin == false)
            {
                MessageBox.Show("YOU HAVE ENTERED AN INVALID TRANSACTION PIN 3 TIMES AND SO YOU HAVE BEEN KICKED OUT OF THE APPLICATION ");
                Application.Exit();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
