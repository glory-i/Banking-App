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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            welcome_label.Text = "WELCOME " + Form1.first_name + " " + Form1.middle_name + " " + Form1.last_name;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 my_form_5 = new Form5();
            my_form_5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 myform6 = new Form6();
            myform6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 my_form7 = new Form7();
            my_form7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //
            Form8 myform8 = new Form8();
            this.Hide();
            myform8.Show();
        }

        private int generate_cvv()
        {
            string my_string ="";
            Random r = new Random();
            for(int i =0; i < 3; i++)
            {
                my_string += Convert.ToString(r.Next(1, 10));
            }
            int cvv = Convert.ToInt32(my_string);
            return cvv;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            bool card_exists = false; ;

            int mpin = Form1.user_mpin;
            int cvv = generate_cvv();
            string expiry_date = dateTimePicker1.Value.Date.AddMonths(24).ToString("yyyyMMdd");
            int acc_no = Form1.account_number;
            int tpin = Form1.user_transaction_pin;
            string account_type = Form1.account_type;
            string bank_name = Form1.bank_name;



            string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "SELECT * FROM cards WHERE mpin = '" + mpin + "'";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    card_exists = true;
                }
                
                con.Close();

            }
            catch(Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }
            
            if (card_exists == true)
            {
                MessageBox.Show("A CARD ALREADY EXISTS FOR THIS ACCOUNT BOSS");

            }
            else
            {

                /*string connection_string2 = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query2 = "INSERT INTO cards VALUES ('" + mpin + "','" + cvv + "','" + expiry_date + "','','" + acc_no + "','" + tpin + "','" + account_type + "','" + bank_name + "','"+Form1.first_name+"','"+Form1.middle_name+ "','" + Form1.last_name + "')";
                MySqlConnection con2 = new MySqlConnection(connection_string2);
                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                MySqlDataReader reader2;

                try
                {
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    MessageBox.Show("card successfully processed ");
                    con2.Close();

                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }
                */
                this.Hide();
                Form9 myform9 = new Form9();
                myform9.Show();

            }
        
                
         }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 myform10 = new Form10();
            myform10.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //
        }

        private void view_beneficary_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 myform11 = new Form11();
            myform11.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form12 myform12 = new Form12();
            myform12.Show();
        }
    }
}
