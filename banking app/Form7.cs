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
    public partial class Form7 : Form
    {
        int no_of_times_tried = 0;
        int current_mpin;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if(Form1.security_question != "")
            {
                label2.Text = Form1.security_question;
            }
            else
            {
                panel2.BringToFront();
                current_mpintextBox.ReadOnly = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no_of_times_tried += 1;
            if(no_of_times_tried == 3)
            {
                MessageBox.Show("you have failed this security question 3 times and thus you have been logged out");
                Application.Exit();
            }
            string answer = richTextBox1.Text.ToLower();
            answer = answer.Trim();
            if(answer == Form1.answer)
            {
                //
                panel2.BringToFront();
                current_mpintextBox.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("YOU HAVE ANSWERED THIS SECURITY QUESTION INCORRECTLY");
            }
        }

        private bool is_digit()
        {
            bool is_digit = true;
            foreach(char c in new_mpin_textBox.Text)
            {
                if(char.IsDigit(c) == false)
                {
                    is_digit = false;
                }
            }
            return is_digit;
        }

        private bool is_digit2()
        {
            bool is_digit = true;
            foreach (char c in current_mpintextBox.Text)
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
            if(new_mpin_textBox.Text.Length >= 5)
            {
                is_long = true;
            }
            return is_long;
        }

        private bool is_same()
        {
            bool is_same = false;
            if(confirm_mpin_textBox.Text == new_mpin_textBox.Text)
            {
                is_same = true;
            }
            return is_same;
        }
        private void current_mpintextBox_TextChanged(object sender, EventArgs e)
        {
            if(is_digit2() && current_mpintextBox.Text!="")
            {
                current_mpin = Convert.ToInt32(current_mpintextBox.Text);
            }
            if (current_mpin == Form1.user_mpin)
            {
                new_mpin_textBox.ReadOnly = false;
            }
            else
            {
                new_mpin_textBox.ReadOnly = true;
                button1.Enabled = false;
            }


            if (is_same() && is_digit() && is_long() && current_mpin == Form1.user_mpin)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void new_mpin_textBox_TextChanged(object sender, EventArgs e)
        {
            if(is_digit() && is_long())
            {
                confirm_mpin_textBox.ReadOnly = false;
            }
            else
            {
                confirm_mpin_textBox.ReadOnly = true;
            }


            if (is_same() && is_digit() && is_long())
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void confirm_mpin_textBox_TextChanged(object sender, EventArgs e)
        {
            if (is_same() && is_digit() && is_long())
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool same_pin = false;
            int new_mpin = Convert.ToInt32(confirm_mpin_textBox.Text);

            string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "SELECT mpin FROM bank where mpin='"+new_mpin+"'";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows == true)
                {
                    same_pin = true;

                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if(same_pin== true)
            {
                MessageBox.Show("This mpin has been chosen by another user");
            }

            else
            {
                string connection_string2 = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query2 = "UPDATE `bank` SET `mpin`='"+new_mpin+"' WHERE `mpin` = '"+Form1.user_mpin+"'";
                MySqlConnection con2 = new MySqlConnection(connection_string2);
                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                MySqlDataReader reader2;

                try
                {
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    /*MessageBox.Show("Mpin succefully changed ");
                    Form1.user_mpin = new_mpin;
                    this.Hide();
                    Form4 myform4 = new Form4();
                    myform4.Show(); */
                    con2.Close();
                }
                catch(Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }

                string connection_string3 = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query3 = "UPDATE `cards` SET `mpin`='" + new_mpin + "' WHERE `mpin` = '" + Form1.user_mpin + "' AND tpin ='"+Form1.user_transaction_pin+"'";
                MySqlConnection con3 = new MySqlConnection(connection_string3);
                MySqlCommand cmd3 = new MySqlCommand(query3, con3);
                MySqlDataReader reader3;

                try
                {
                    con3.Open();
                    reader3 = cmd3.ExecuteReader();
                    MessageBox.Show("Mpin succefully changed ");
                    Form1.user_mpin = new_mpin;
                    this.Hide();
                    Form4 myform4 = new Form4();
                    myform4.Show();
                    con3.Close();
                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(current_mpintextBox.UseSystemPasswordChar == true)
            {
                current_mpintextBox.UseSystemPasswordChar = false;
                button3.Text = "HIDE";
            }
            else
            {
                button3.Text = "VIEW";
                current_mpintextBox.UseSystemPasswordChar = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (new_mpin_textBox.UseSystemPasswordChar == true)
            {
                new_mpin_textBox.UseSystemPasswordChar = false;
                button4.Text = "HIDE";
            }
            else
            {
                button4.Text = "VIEW";
                new_mpin_textBox.UseSystemPasswordChar = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (confirm_mpin_textBox.UseSystemPasswordChar == true)
            {
                confirm_mpin_textBox.UseSystemPasswordChar = false;
                button5.Text = "HIDE";
            }
            else
            {
                button5.Text = "VIEW";
                confirm_mpin_textBox.UseSystemPasswordChar = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 myform4 = new Form4();
            this.Hide();
            myform4.Show();
        }

        private void back_button2_Click(object sender, EventArgs e)
        {

            Form4 myform4 = new Form4();
            this.Hide();
            myform4.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
