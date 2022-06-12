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
    public partial class Form8 : Form
    {
        int no_of_times_tried = 0;
        int current_tpin;
        public Form8()
        {
            InitializeComponent();
        }

        private bool is_digit2()
        {
            bool is_digit = true;
            foreach(char c in current_tpin_textBox.Text)
            {
                if(char.IsDigit(c) == false)
                {
                    is_digit = false;
                }
            }
            return is_digit;
        }
        private bool is_digit()
        {
            bool is_digit = true;
            foreach (char c in new_tpin_textBox.Text)
            {
                if (char.IsDigit(c) == false)
                {
                    is_digit = false;
                }
            }
            return is_digit;
        }

        private bool is_long()
        {
            bool is_long = false;
            if(new_tpin_textBox.Text.Length == 4)
            {
                is_long = true;
            }
            return is_long;
        }

        private bool is_same()
        {
            bool is_same = false;
            if(new_tpin_textBox.Text == confirm_tpin_textBox.Text)
            {
                is_same = true;
            }
            return is_same;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            if(Form1.security_question != "")
            {
                tpin_question_label.Text = Form1.security_question;
            }
            else
            {
                //
                current_tpin_textBox.ReadOnly = false;
            }
        }


        private void proceed_button_Click(object sender, EventArgs e)
        {
            string answer = tpin_answer_richTextBox.Text.ToLower();
            answer = answer.Trim();
            no_of_times_tried += 1;
            if(no_of_times_tried == 4)
            {
                MessageBox.Show("You have answered this question incorrectly 3 times and you have been kicked out of the application ");
                Application.Exit();
            }

            if (answer == Form1.answer)
            {
                tpin_panel2.BringToFront();
                current_tpin_textBox.ReadOnly = false;

            }

            else
            {
                MessageBox.Show("YOU HAVE ANSWERED THIS QUESTION INCORRECTLY ");
            }
        }

        private void current_tpin_textBox_TextChanged(object sender, EventArgs e)
        {
            if(is_digit2() && current_tpin_textBox.Text != "")
            {
                current_tpin = Convert.ToInt32(current_tpin_textBox.Text);
            }

            if(current_tpin == Form1.user_transaction_pin)
            {
                new_tpin_textBox.ReadOnly = false;
            }
            else
            {
                new_tpin_textBox.ReadOnly = true;
                change_tpin_button.Enabled = false;
            }


            if (is_digit() && is_digit2() && is_long() && is_same() && current_tpin == Form1.user_transaction_pin)
            {
                change_tpin_button.Enabled = true;
            }
            else
            {
                change_tpin_button.Enabled = false;
            }
        }

        private void new_tpin_textBox_TextChanged(object sender, EventArgs e)
        {
            if(is_digit() && is_long())
            {
                confirm_tpin_textBox.ReadOnly = false;
            }
            else
            {
                confirm_tpin_textBox.ReadOnly = true;
            }

            if(is_digit() && is_digit2() && is_long() && is_same())
            {
                change_tpin_button.Enabled = true;
            }
            else
            {
                change_tpin_button.Enabled = false;
            }
        }

        private void confirm_tpin_textBox_TextChanged(object sender, EventArgs e)
        {
            //
            if(is_same() && is_digit() && is_digit2() && is_long())
            {
                change_tpin_button.Enabled = true;
            }
            else
            {
                change_tpin_button.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(current_tpin_textBox.UseSystemPasswordChar == true)
            {
                current_tpin_textBox.UseSystemPasswordChar = false;
                button1.Text = "HIDE";
            }

            else
            {
                current_tpin_textBox.UseSystemPasswordChar = true;
                button1.Text = "VIEW";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (new_tpin_textBox.UseSystemPasswordChar == true)
            {
                new_tpin_textBox.UseSystemPasswordChar = false;
                button2.Text = "HIDE";
            }

            else
            {
                new_tpin_textBox.UseSystemPasswordChar = true;
                button2.Text = "VIEW";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (confirm_tpin_textBox.UseSystemPasswordChar == true)
            {
                confirm_tpin_textBox.UseSystemPasswordChar = false;
                button3.Text = "HIDE";
            }

            else
            {
                confirm_tpin_textBox.UseSystemPasswordChar = true;
                button3.Text = "VIEW";
            }
        }

        private void change_tpin_button_Click(object sender, EventArgs e)
        {
            int new_tpin = Convert.ToInt32(confirm_tpin_textBox.Text);

            string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "UPDATE `bank` SET `transaction_pin`='" + new_tpin + "' WHERE `transaction_pin`='" + Form1.user_transaction_pin + "' AND `mpin`='"+Form1.user_mpin+"'";

            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
               /* MessageBox.Show("SUCCESSFULLY CHANGED TRANSACTION PIN");
                Form1.user_transaction_pin = new_tpin;

                Form4 myform4 = new Form4();
                this.Hide();
                myform4.Show();*/

                con.Close();
            }
            catch(Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }


            string connection_string2 = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query2 = "UPDATE `cards` SET `tpin`='" + new_tpin + "' WHERE `tpin`='" + Form1.user_transaction_pin + "' AND `mpin`='" + Form1.user_mpin + "'";

            MySqlConnection con2 = new MySqlConnection(connection_string2);
            MySqlCommand cmd2 = new MySqlCommand(query2, con2);
            MySqlDataReader reader2;

            try
            {
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                MessageBox.Show("SUCCESSFULLY CHANGED TRANSACTION PIN");
                Form1.user_transaction_pin = new_tpin;

                Form4 myform4 = new Form4();
                this.Hide();
                myform4.Show();

                con2.Close();
            }
            catch (Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }



        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form4 myform4 = new Form4();
            this.Hide();
            myform4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form4 myform4 = new Form4();
            this.Hide();
            myform4.Show();
        }

        private void tpin_panel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
