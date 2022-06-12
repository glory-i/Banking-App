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
    public partial class Form5 : Form
    {
        public string transaction_time;
        public string transaction_date;

        public string narration;
        public double beneficiary_current_account_balance;
        public int ben_bank_account;
        public double sender_current_account_balance;
        
        public string ben_first_name;
        public string ben_middle_name;
        public string ben_last_name;

        public double amount;
        public Form5()
        {
            InitializeComponent();
        }

        private bool acc_no_is_digit()
        {
            bool is_digit = true;
            if (beneficiary_acc_numbertextBox.Text == "")
            {
                is_digit = false;
            }
            foreach(char c in beneficiary_acc_numbertextBox.Text)
            {
                if(char.IsDigit(c) != true)
                {
                    is_digit = false;
                }
            }
            return is_digit;
        }
        private void get_beneficiary_details()
        {
            if (acc_no_is_digit() == true)
            {
                try
                {
                    ben_bank_account = Convert.ToInt32(beneficiary_acc_numbertextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("in valid format for account number");
                }
                catch(Exception myex)
                {
                    MessageBox.Show(myex.ToString());
                }
                //ben_bank_account = Convert.ToInt32(beneficiary_acc_numbertextBox.Text);
            }
            
            string beneficiary_bank = beneficiary_bank_comboBox.SelectedItem.ToString();
            
            string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "Select `First_Name`,`Middle_Name`,`Last_Name`,`account_balance`from bank WHERE Bank_Name ='" + beneficiary_bank + "' AND account_number = '"+ben_bank_account+"'";

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
                    ben_first_name = reader.GetString(0);
                    ben_middle_name = reader.GetString(1);
                    ben_last_name = reader.GetString(2);

                    label5.Text = "";
                    display_beneficiary_label.Text = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2);
                    beneficiary_pictureBox.Visible = true;
                    save_beneficiary_button.Visible = true;
                    beneficiary_current_account_balance = reader.GetDouble(3);
                    enter_amount_textBox.ReadOnly = false;
                    confirm_checkBox.Enabled = true;
                }
                else
                {
                    save_beneficiary_button.Visible = false;
                    label5.Text = "ACCOUNT NOT FOUND";
                    beneficiary_pictureBox.Visible = false;
                    enter_amount_textBox.ReadOnly = true;
                    display_beneficiary_label.Text = "";
                    confirm_checkBox.Enabled = false;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            string add_to_combo = (Form1.account_number.ToString() + "\n" + Form1.first_name+ " " + Form1.middle_name+ " " + Form1.last_name + "\n" + Form1.bank_name);
            account_comboBox.Items.Add(add_to_combo);
            display_beneficiary_label.Text = "";
            //get_beneficiary_details();
        }

        private void account_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(beneficiary_acc_numbertextBox.Text != "" && beneficiary_bank_comboBox.SelectedItem != null)
            {

                get_beneficiary_details();
            }
        }

        private void beneficiary_acc_numbertextBox_TextChanged(object sender, EventArgs e)
        {
          /*  if(account_comboBox.SelectedItem != null &&beneficiary_bank_comboBox.SelectedItem != null)
            {

                get_beneficiary_details();
            }*/
        }

        private void beneficiary_bank_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirm_checkBox.Checked = false;
            transfer_money_button.Enabled = false;
            tpin_textbox.Text = "";
            
            if(beneficiary_acc_numbertextBox.Text !=""&& account_comboBox.SelectedItem != null)
            {

                get_beneficiary_details();
            }
        }

        private void enter_amount_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToDouble(enter_amount_textBox.Text);
                confirm_checkBox.Enabled = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("enter a valid amount");
                confirm_checkBox.Enabled = false;
            }
        }

        private void confirm_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(confirm_checkBox.Checked == true)
            {
                transfer_money_button.Enabled = true;
                tpin_textbox.Visible = true;
            }
            else
            {
                transfer_money_button.Enabled = false;

            }
        }

        private void transfer_money_button_Click(object sender, EventArgs e)
        {
            bool transfer_complete = false;
            int tpin = 900009;
            try
            {
                tpin = Convert.ToInt32(tpin_textbox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("invalid format for tpin");
            }
            catch(Exception My_ex)
            {
                MessageBox.Show(My_ex.ToString());
            }
            if (Form1.account_balance - amount <= 19.00)
            {
                MessageBox.Show("Insufficient funds to perform this transaction");
            }
            else if(tpin != Form1.user_transaction_pin)
            {
                MessageBox.Show("INCORRECT TPIN ENTERED");

            }
            else if (amount <= 0)
            {
                MessageBox.Show("INVALID AMOUNT ");
            }
            else if (beneficiary_acc_numbertextBox.Text == Form1.account_number.ToString())
            {
                MessageBox.Show("you cannot transfer money to yourself ");
            }
            else if(tpin==Form1.user_transaction_pin && Form1.account_balance - amount >=20)
            {
                transfer_complete = true;

                string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                beneficiary_current_account_balance += amount;
                string query = "UPDATE `bank` SET `account_balance`='" + beneficiary_current_account_balance + "' WHERE `account_number` ='" + ben_bank_account + "'";

                MySqlConnection con = new MySqlConnection(connection_string);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("TRANSFER COMPLETE");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                string connection_string2 = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                Form1.account_balance -= amount;
                string query2 = "UPDATE `bank` SET `account_balance`='" + Form1.account_balance + "' WHERE `account_number` ='" + Form1.account_number + "'";

                MySqlConnection con2 = new MySqlConnection(connection_string2);
                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                MySqlDataReader reader2;

                try
                {
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                panel1.BringToFront();
                textBox2.Text = amount.ToString();
                string tbox3_text = Form1.account_number.ToString();
            

                textBox3.Text = tbox3_text[0] +""+ tbox3_text[1]+""+ tbox3_text[2] +"***"+tbox3_text[tbox3_text.Length -2] + ""+tbox3_text[tbox3_text.Length -1];
                textBox4.Text = Form1.first_name +" "+ Form1.middle_name +" "+  Form1.last_name;
                textBox5.Text = ben_bank_account.ToString();
                textBox6.Text = display_beneficiary_label.Text;
                textBox7.Text = beneficiary_bank_comboBox.SelectedItem.ToString();
                narration = textBox1.Text;
                textBox8.Text = textBox1.Text;

            }

            if (transfer_complete)
            {
                transaction_time = dateTimePicker1.Value.TimeOfDay.ToString();
                transaction_date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                string connection_string3 = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query3 = "INSERT INTO transactions VALUES('','" + Form1.first_name + "','"+Form1.middle_name+"','"+Form1.last_name+"','"+Form1.account_number+"','"+ben_first_name+"','"+ben_middle_name+"','"+ben_last_name+"','"+ben_bank_account+"','"+amount+"','"+narration+"','"+transaction_date+"','"+transaction_time+"')";

                MySqlConnection con3 = new MySqlConnection(connection_string3);
                MySqlCommand cmd3 = new MySqlCommand(query3, con3);
                MySqlDataReader reader3;

                try
                {
                    con3.Open();
                    reader3 = cmd3.ExecuteReader();
                    con3.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            transfer_money_button.Enabled = false;
            confirm_checkBox.Checked = false;
            tpin_textbox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myform4 = new Form4();
            myform4.Show();
        }

        private void beneficiary_acc_numbertextBox_TextChanged_1(object sender, EventArgs e)
        {

            confirm_checkBox.Checked = false;
            transfer_money_button.Enabled = false;
            tpin_textbox.Text = "";
            if (account_comboBox.SelectedItem != null && beneficiary_bank_comboBox.SelectedItem != null)
            {

                get_beneficiary_details();
            }
        }

        private void back_button_5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myform4 = new Form4();
            myform4.Show();
        }

        private void save_beneficiary_button_Click(object sender, EventArgs e)
        {
            string ben_bank = beneficiary_bank_comboBox.SelectedItem.ToString();
            int ben_account_no = Convert.ToInt32(beneficiary_acc_numbertextBox.Text);
            string[] mystring = display_beneficiary_label.Text.Split(' ');
            bool already_beneficiary = false;

            string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "Select * from `beneficaries` WHERE sender_account_no = '" + Form1.account_number + "' AND ben_account_no = '" + ben_account_no + "'";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    already_beneficiary = true;
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if(already_beneficiary == false)
            {
                string connection_string2 = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query2 = "Insert into `beneficaries` VALUES('','" + Form1.account_number + "','" + ben_bank + "','" + ben_account_no + "','" + mystring[0] + "','" + mystring[1] + "','" + mystring[2] + "')";

                MySqlConnection con2 = new MySqlConnection(connection_string2);
                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                MySqlDataReader reader2;


                try
                {
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    MessageBox.Show("succesfully saved as beneficiary");
                    con2.Close();
                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("THIS ACCOUNT IS ALREADY A BENEFICIARY");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void beneficiary_acc_numbertextBox_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
