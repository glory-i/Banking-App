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
    public partial class Form10 : Form
    {

        public int no_times_answered;
        public Form10()
        {
            InitializeComponent();
        }

        private void back_button_blockcard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myform4 = new Form4();
            myform4.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            block_card_question_label.Text = Form1.security_question;
            
        }

        private void proceed_button_blockcard_Click(object sender, EventArgs e)
        {
            block_card_textbox.Text = block_card_textbox.Text.ToString().Trim();
            
            no_times_answered += 1;
            if(no_times_answered ==3 && block_card_textbox.Text.ToLower() != Form1.answer)
            {
                MessageBox.Show("You have answered the security question incorrectly 3 times and thus you have been logged out");
                Application.Exit();
            }
            else if(block_card_textbox.Text.ToLower() != Form1.answer)
            {
                MessageBox.Show("INCORRECT ANSWER TO SECURITY QUESTION");
            }
            
            else if(block_card_textbox.Text.ToLower() == Form1.answer)
            {
                bool card_exists = false;
                string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query = "SELECT * FROM cards WHERE mpin = '" + Form1.user_mpin + "' AND tpin='" + Form1.user_transaction_pin + "'";
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
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }

                if (card_exists == true)
                {
                    string connection_string2 = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                    string query2 = "DELETE FROM `cards` WHERE mpin ='" + Form1.user_mpin + "' AND tpin ='" + Form1.user_transaction_pin + "'";

                    MySqlConnection con2 = new MySqlConnection(connection_string2);
                    MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                    MySqlDataReader reader2;

                    try
                    {
                        con2.Open();
                        reader2 = cmd2.ExecuteReader();
                        MessageBox.Show("THIS CARD HAS BEEN SUCCEFULLY BLOCKED AND CAN NO LONGER BE USED, YOU WILL NEED TO PROCESS A NEW CARD");
                        this.Hide();
                        Form4 myform4 = new Form4();
                        myform4.Show();
                        con2.Close();
                    }
                    catch (Exception my_ex)
                    {
                        MessageBox.Show(my_ex.ToString());
                    }


                }
                else
                {
                    MessageBox.Show("There is no existing card for this account to be blocked");
                }

            }
        }
    }
}
