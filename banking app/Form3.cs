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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private bool mpin_is_digit()
        {
            bool is_digit = true;
            foreach(char c in mpin_textbox.Text)
            {
                if(char.IsDigit(c) == false)
                {
                    is_digit = false;
                }
            }
            return is_digit;
        }
        private bool tpin_is_digit()
        {
            bool is_digit = true;
            foreach (char c in tpin_textbox.Text)
            {
                if (char.IsDigit(c) == false)
                {
                    is_digit = false;
                }
            }
            return is_digit;
        }

        private bool mpin_is_long()
        {
            bool length = false;
            if(mpin_textbox.Text.Length >= 5)
            {
                length = true;
            }
            return length;
        }

        private bool mpin2_is_same()
        {
            bool equal = false;
            if (mpin_textbox.Text == mpin_textbox2.Text)
            {
                equal = true;
            }
            return equal;
        }

        private bool tpin_is_long()
        {
            bool length = false;
            if (tpin_textbox.Text.Length == 4)
            {
                length = true;
            }
            return length;
        }
        private bool tpin2_is_same()
        {
            bool equal = false;
            if (tpin_textbox.Text == tpin_textbox2.Text)
            {
                equal = true;
            }
            return equal;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //
        }

        private void tpin_textbox2_TextChanged(object sender, EventArgs e)
        {
         /*   if (tpin2_is_same() == false)
            {
                matching_tpin_label.Text = "4 DIGITS TRANSACTION PINS ARE NOT MATCHING";
            }
            else
            {
                matching_tpin_label.Text = "";
            }

            if (mpin2_is_same() && mpin_is_digit() && mpin_is_long() && tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            }
         */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 my_form1 = new Form1();
            my_form1.Show();
            this.Hide();
        }

        private void tpin_textbox_TextChanged(object sender, EventArgs e)
        {

           /* if (tpin2_is_same() == false)
            {
                matching_tpin_label.Text = "4 DIGITS TRANSACTION PINS ARE NOT MATCHING";
            }
            else
            {
                matching_tpin_label.Text = "";
            }

            if (mpin2_is_same() && mpin_is_digit() && mpin_is_long() && tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            }*/
        }

        private void mpin_textbox2_TextChanged(object sender, EventArgs e)
        {
            /*

            if (mpin2_is_same() == false)
            {
                matching_mpin_label.Text = " MPINS ARE NOT MATCHING";
            }
            else
            {
                matching_mpin_label.Text = "";
            }

            if (mpin2_is_same() && mpin_is_digit() && mpin_is_long() && tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            } */
        }

        private void mpin_textbox_TextChanged(object sender, EventArgs e)
        {
            /*
            if (mpin2_is_same() == false)
            {
                matching_mpin_label.Text = "MPINS ARE NOT MATCHING";
            }
            else
            {
                matching_mpin_label.Text = "";
            }

            if(mpin2_is_same() && mpin_is_digit() && mpin_is_long() &&tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            } */
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            int mpin =Convert.ToInt32(mpin_textbox.Text);
            int tpin = Convert.ToInt32(tpin_textbox.Text);
            double default_balance = 500.0;
            bool same_mpin = false;
            string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "Select mpin from bank WHERE mpin ='" + mpin + "'";

            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows==true)
                {
                    same_mpin = true;
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if(same_mpin == true)
            {
                MessageBox.Show("THIS MPIN IS ALREADY IN USE BY ANOTHER USER, SELECT ANOTHER MPIN");

            }
            else
            {
                string connection_string2 = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query2 = "INSERT INTO `bank` VALUES('"+Form2.f_name+"','"+Form2.m_name+ "','" + Form2.l_name + "','" + Form2.account_type + "','" +mpin + "','" + tpin + "','','" + default_balance + "','" + Form2.bank_name + "','" + Form2.question + "','"+Form2.answer+"')";

                MySqlConnection con2 = new MySqlConnection(connection_string2);
                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                MySqlDataReader reader2;

                try
                {
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    MessageBox.Show("You have successfully created a bank account with us, Congratulations... You can login now");
                    this.Hide();
                    Form1 myform1 = new Form1();
                    myform1.Show();
                    con2.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(mpin_textbox.UseSystemPasswordChar == false)
            {
                mpin_textbox.UseSystemPasswordChar = true;
                button2.Text = "View";
            }
            else
            {
                mpin_textbox.UseSystemPasswordChar = false;
                button2.Text = "Hide";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(mpin_textbox2.UseSystemPasswordChar == false)
            {
                mpin_textbox2.UseSystemPasswordChar = true;
                button3.Text = "View";
            }
            else
            {
                mpin_textbox2.UseSystemPasswordChar = false;
                button3.Text = "Hide";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(tpin_textbox.UseSystemPasswordChar == false)
            {
                tpin_textbox.UseSystemPasswordChar = true;
                button4.Text = "View";
            }
            else
            {
                tpin_textbox.UseSystemPasswordChar = false;
                button4.Text = "Hide";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(tpin_textbox2.UseSystemPasswordChar == false)
            {
                tpin_textbox2.UseSystemPasswordChar = true;
                button5.Text = "View";
            }
            else
            {
                tpin_textbox2.UseSystemPasswordChar = false;
                button5.Text = "Hide";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mpin_textbox_TextChanged_1(object sender, EventArgs e)
        {
            if (mpin2_is_same() == false)
            {
                matching_mpin_label.Text = "MPINS ARE NOT MATCHING";
            }
            else
            {
                matching_mpin_label.Text = "";
            }

            if (mpin2_is_same() && mpin_is_digit() && mpin_is_long() && tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            }
        }

        private void mpin_textbox2_TextChanged_1(object sender, EventArgs e)
        {

            if (mpin2_is_same() == false)
            {
                matching_mpin_label.Text = " MPINS ARE NOT MATCHING";
            }
            else
            {
                matching_mpin_label.Text = "";
            }

            if (mpin2_is_same() && mpin_is_digit() && mpin_is_long() && tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            }
        }

        private void tpin_textbox_TextChanged_1(object sender, EventArgs e)
        {
            if (tpin2_is_same() == false)
            {
                matching_tpin_label.Text = "4 DIGITS TRANSACTION PINS ARE NOT MATCHING";
            }
            else
            {
                matching_tpin_label.Text = "";
            }

            if (mpin2_is_same() && mpin_is_digit() && mpin_is_long() && tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            }

        }

        private void tpin_textbox2_TextChanged_1(object sender, EventArgs e)
        {

            if (tpin2_is_same() == false)
            {
                matching_tpin_label.Text = "4 DIGITS TRANSACTION PINS ARE NOT MATCHING";
            }
            else
            {
                matching_tpin_label.Text = "";
            }

            if (mpin2_is_same() && mpin_is_digit() && mpin_is_long() && tpin2_is_same() && tpin_is_digit() && tpin_is_long())
            {
                done_button.Enabled = true;
            }
            else
            {
                done_button.Enabled = false;
            }
        }
    }
}
