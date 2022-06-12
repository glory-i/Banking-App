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
    public partial class Form11 : Form
    {
        public string s;
        public string ben_first_name;
        public string ben_middle_name;
        public string ben_last_name;
        public int ben_account_number;
        public string ben_bank;

        //variables for transfer to beneficiary
        public string transfer_ben_first_name;
        public string transfer_ben_middle_name;
        public string transfer_ben_last_name;
        public string transfer_ben_narration;
        public double transfer_ben_acc_balance;
        public double transfer_ben_amount;
        public int transfer_ben_account_number;
        public string transfer_ben_bank;




        public Form11()
        {
            InitializeComponent();
        }
        public DataTable getbeneficiary()
        {
            string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "Select ben_bank,ben_account_no,ben_first_name,ben_middle_name,ben_last_name from beneficaries WHERE sender_account_no='" + Form1.account_number + "'";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        private void Form11_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           //

        }

        private void ben_fname_tbox_Click(object sender, EventArgs e)
        {
            //
        }

        private void ben_mname_tbox_Click(object sender, EventArgs e)
        {
            //
        }

        private void ben_mname_tbox_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void ben_fname_tbox_TextChanged(object sender, EventArgs e)
        {//
        }

        private void ben_lname_tbox_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void ben_acc_no_tbox_Click(object sender, EventArgs e)
        {
            //
        }

        private void ben_acc_no_tbox_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            ben_fname_tbox.Visible = false;
            ben_middlename_tbox.Visible = false;
            ben_lname_tbox.Visible = false;
            save_ben_button.Enabled = false;
            if (ben_acc_no_tbox.Text != "" && comboBox1.SelectedItem != null)
            {
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                save_ben_button.Enabled = false;
            }

            if(ben_acc_no_tbox.Text != "")
            {
                ben_acc_no_label.Visible = false;
            }
            else
            {
                ben_acc_no_label.Visible = true;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            ben_fname_tbox.Visible = false;
            ben_middlename_tbox.Visible = false;
            ben_lname_tbox.Visible = false;
            save_ben_button.Enabled = false;
            if (comboBox1.SelectedItem != null && ben_acc_no_tbox.Text!="")
            {
               
                checkBox1.Enabled = true;
               
            }
            else
            {

                checkBox1.Enabled = false;
                save_ben_button.Enabled = false;
            }

            if(comboBox1.SelectedItem != null)
            {
                ben_bank_label.Visible = false;
            }
            else
            {
                ben_bank_label.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                try
                {
                    ben_account_number = Convert.ToInt32(ben_acc_no_tbox.Text);
                    ben_bank = comboBox1.SelectedItem.ToString();
                    string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                    string query = "Select First_name,Middle_name,Last_name from bank where account_number='"+ben_account_number+"' and Bank_Name='"+ben_bank+"'";
                    MySqlConnection con = new MySqlConnection(connection_string);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        ben_first_name = reader.GetString(0);
                        ben_middle_name = reader.GetString(1);
                        ben_last_name = reader.GetString(2);
                        save_ben_button.Enabled = true;
                        ben_fname_tbox.Text = ben_first_name;
                        ben_middlename_tbox.Text = ben_middle_name;
                        ben_lname_tbox.Text = ben_last_name;
                        ben_fname_tbox.Visible = true;
                        ben_middlename_tbox.Visible = true;
                        ben_lname_tbox.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("ACCOUNT DOES NOT EXIST ");
                        checkBox1.Checked = false;
                        save_ben_button.Enabled = false;
                        ben_fname_tbox.Visible = false;
                        ben_middlename_tbox.Visible = false;
                        ben_lname_tbox.Visible = false;
                    }
                    con.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("enter a valid account number ");
                    checkBox1.Checked = false;
                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }
                

            }
        }

        private void save_ben_button_Click(object sender, EventArgs e)
        {
            bool already_beneficiary;
            if (Convert.ToInt32(ben_acc_no_tbox.Text) == Form1.account_number)
            {
                MessageBox.Show("YOU CANNOT ADD YOURSELF AS A BENEFICIARY");
                checkBox1.Checked = false;
                save_ben_button.Enabled = false;
                ben_acc_no_tbox.Text = "";
                comboBox1.SelectedItem = null;
                ben_fname_tbox.Visible = false;
                ben_middlename_tbox.Visible = false;
                ben_lname_tbox.Visible = false;
            }
            else
            {


                try
                {
                    string connection_string2 = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                    string query2 = "Select * from beneficaries where sender_account_no='" + Form1.account_number + "' and ben_account_no='" + ben_account_number + "'";
                    MySqlConnection con2 = new MySqlConnection(connection_string2);
                    MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                    MySqlDataReader reader2;

                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    reader2.Read();
                    if (reader2.HasRows)
                    {
                        already_beneficiary = true;
                        MessageBox.Show("this account is already beneficiary");
                        checkBox1.Checked = false;

                        ben_acc_no_tbox.Text = "";
                        comboBox1.SelectedItem = null;
                        ben_fname_tbox.Visible = false;
                        ben_middlename_tbox.Visible = false;
                        ben_lname_tbox.Visible = false;
                        save_ben_button.Enabled = false;
                    }
                    else
                    {
                        already_beneficiary = false;
                    }
                    con2.Close();

                    if (already_beneficiary == false)
                    {
                        string connection_string3 = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                        string query3 = "INSERT INTO beneficaries VALUES('','" + Form1.account_number + "','" + ben_bank + "','" + ben_account_number + "','" + ben_first_name + "','" + ben_middle_name + "','" + ben_last_name + "')";
                        MySqlConnection con3 = new MySqlConnection(connection_string3);
                        MySqlCommand cmd3 = new MySqlCommand(query3, con3);
                        MySqlDataReader reader3;

                        con3.Open();
                        reader3 = cmd3.ExecuteReader();

                        MessageBox.Show("succefully added beneficiary");
                        checkBox1.Checked = false;
                        save_ben_button.Enabled = false;
                        ben_acc_no_tbox.Text = "";
                        comboBox1.SelectedItem = null;
                        ben_fname_tbox.Visible = false;
                        ben_middlename_tbox.Visible = false;
                        ben_lname_tbox.Visible = false;
                        con3.Close();


                    }
                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_ben_panel.BringToFront();
        }

        private void view_ben_button_Click(object sender, EventArgs e)
        {
            view_ben_panel.BringToFront();
            dataGridView1.DataSource = getbeneficiary();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            transfer_ben_panel.BringToFront();
            try
            {
                string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query = "Select * from beneficaries where sender_account_no='" + Form1.account_number + "'";
                MySqlConnection con = new MySqlConnection(connection_string);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string beneficiary = reader.GetString(4) + " " + reader.GetString(5) + " " + reader.GetString(6) + " " + Convert.ToString(reader.GetInt32(3)) + " " + reader.GetString(2);
                        //firstname+middlename+lastname+accno+bank
                        if (list_of_ben_cbox.Items.Contains(beneficiary) == false)
                        {

                            list_of_ben_cbox.Items.Add(beneficiary);
                        }
                        

                    }
                }
                con.Close();
            }
            catch (Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }

            if (list_of_ben_cbox.Items == null)
            {
                MessageBox.Show("you have no beneficiaries ");
            }

        }

        private void list_of_ben_cbox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (list_of_ben_cbox.SelectedItem == null)
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
            
            transfer_checkbox.Checked = false;
            transfer_button.Enabled = false;
            tpin_textbox.Text = "";
            if (transfer_narration_txtbox.Text != "" && transfer_ben_amount_txtbox.Text != "" && list_of_ben_cbox.SelectedItem != null)
            {
                transfer_checkbox.Enabled = true;
            }
            else
            {
                transfer_checkbox.Enabled = false;
                
            }
        }

        private void transfer_ben_amount_txtbox_TextChanged(object sender, EventArgs e)
        {
            transfer_checkbox.Checked = false;
            transfer_button.Enabled = false;
            tpin_textbox.Text = "";
            if (transfer_narration_txtbox.Text != "" && transfer_ben_amount_txtbox.Text != "" && list_of_ben_cbox.SelectedItem != null)
            {
                transfer_checkbox.Enabled = true;
            }
            else
            {
                transfer_checkbox.Enabled = false;
                
            }
            if (transfer_ben_amount_txtbox.Text == "")
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void transfer_narration_txtbox_TextChanged(object sender, EventArgs e)
        {
            transfer_checkbox.Checked = false;
            transfer_button.Enabled = false;
            tpin_textbox.Text = "";
            if (transfer_narration_txtbox.Text != "" && transfer_ben_amount_txtbox.Text!="" && list_of_ben_cbox.SelectedItem != null)
            {
                transfer_checkbox.Enabled = true;
            }
            else
            {
                transfer_checkbox.Enabled = false;
               
            }
        }

        private void transfer_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            transfer_ben_bank = "";
            if (transfer_checkbox.Checked == true)
            {
                try
                {
                    string[] beneficiary_array = list_of_ben_cbox.SelectedItem.ToString().Split(' ');
                    //firstname+middlename+lastname+accno+bank
                    transfer_ben_first_name = beneficiary_array[0];
                    transfer_ben_middle_name = beneficiary_array[1];
                    transfer_ben_last_name = beneficiary_array[2];
                    transfer_ben_account_number = Convert.ToInt32(beneficiary_array[3]);
                    for(int i = 4; i < beneficiary_array.Length; i++)
                    {
                        transfer_ben_bank += beneficiary_array[i]+" ";
                    }
                    transfer_ben_amount = Convert.ToDouble(transfer_ben_amount_txtbox.Text);
                    transfer_ben_narration = transfer_narration_txtbox.Text;


                    string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                    string query = "Select account_balance from bank where account_number = '" + transfer_ben_account_number + "' ";
                    MySqlConnection con = new MySqlConnection(connection_string);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    transfer_ben_acc_balance = reader.GetDouble(0);
                    tpin_textbox.Visible = true;
                    transfer_button.Enabled = true;

                    con.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show("invalid amount entered");

                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }
            }
        }

        private void transfer_button_Click(object sender, EventArgs e)
        {
            int tpin=900099;
            try
            {
                tpin = Convert.ToInt32(tpin_textbox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("invalid format for transaction pin entered...");

            }            
            catch(Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }
            
            if(Form1.account_balance-transfer_ben_amount >= 20 && tpin ==Form1.user_transaction_pin )
            {
                Form1.account_balance -= transfer_ben_amount;
                transfer_ben_acc_balance += transfer_ben_amount;

                try
                {
                    string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                    string query = "UPDATE bank SET account_balance = '" + Form1.account_balance + "' where account_number ='" + Form1.account_number + "'";
                    MySqlConnection con = new MySqlConnection(connection_string);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();
                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }

                try
                {

                    string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                    string query = "UPDATE bank SET account_balance = '" + transfer_ben_acc_balance + "' where account_number ='" + transfer_ben_account_number + "'";
                    MySqlConnection con = new MySqlConnection(connection_string);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();
                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }

                try
                {
                    string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                    string time = dateTimePicker1.Value.TimeOfDay.ToString();

                    string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                    string query = "INSERT INTO transactions VALUES('','"+Form1.first_name+ "' , '" + Form1.middle_name + "','" + Form1.last_name + "','" + Form1.account_number + "','" + transfer_ben_first_name + "','" + transfer_ben_middle_name + "','"+transfer_ben_last_name+"','"+transfer_ben_account_number+"','"+transfer_ben_amount+"','"+transfer_ben_narration+"','"+date+"','"+time+"')";

                    MySqlConnection con = new MySqlConnection(connection_string);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("TRANSACTION SUCCESSFULLY COMPLETED");
                    string source_account = Form1.account_number.ToString();
                    string actual_sorce_account = source_account[0]+""+source_account[1]+""+source_account[2]+"****"+source_account[source_account.Length-3] +source_account[source_account.Length-2]+source_account[source_account.Length-1];
                    textBox1.Text = Convert.ToString(transfer_ben_amount);
                    textBox2.Text = actual_sorce_account;
                    textBox3.Text = Form1.first_name + " " + Form1.middle_name + " " + Form1.last_name;
                    textBox4.Text = Convert.ToString(transfer_ben_account_number);
                    textBox5.Text = transfer_ben_first_name + " " + transfer_ben_middle_name + " " + transfer_ben_last_name;
                    textBox6.Text = transfer_ben_bank;
                    textBox7.Text = transfer_ben_narration;
                    transfer_receipt_panel.BringToFront();
                    transfer_receipt_panel.Visible = true;


                    con.Close();
                }
                catch (Exception my_ex)
                {
                    MessageBox.Show(my_ex.ToString());
                }
            }

            else if(Form1.account_balance-transfer_ben_amount<20)
            {
                MessageBox.Show("INSUFFICIENT FUNDS MY GUY");
            }
            else if(tpin != Form1.user_transaction_pin)
            {
                MessageBox.Show("Inavlid transaction pin");
            }

            transfer_checkbox.Checked = false;
            transfer_button.Enabled = false;
            transfer_narration_txtbox.Text = "";
            transfer_ben_amount_txtbox.Text = "";
            list_of_ben_cbox.SelectedItem = null;
            tpin_textbox.Text = "";
            tpin_textbox.Visible = false;


        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myform4 = new Form4();
            myform4.Show();

        }

        private void list_of_ben_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            transfer_receipt_panel.Visible = false;
            transfer_receipt_panel.SendToBack();
        }

        private void ben_lname_tbox_Click(object sender, EventArgs e)
        {
            //
        }

        private void del_ben_button_Click(object sender, EventArgs e)
        {

            delete_ben_panel.BringToFront();
            try
            {
                string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
                string query = "Select * from beneficaries where sender_account_no='" + Form1.account_number + "'";
                MySqlConnection con = new MySqlConnection(connection_string);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;

                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string beneficiary = reader.GetString(4) + " " + reader.GetString(5) + " " + reader.GetString(6) + " " + Convert.ToString(reader.GetInt32(3)) + " " + reader.GetString(2);
                        //firstname+middlename+lastname+accno+bank
                        if (del_ben_combobox.Items.Contains(beneficiary) == false)
                        {

                            del_ben_combobox.Items.Add(beneficiary);
                        }


                    }
                }
                con.Close();
            }
            catch (Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }

            if (del_ben_combobox.Items == null)
            {
                MessageBox.Show("you have no beneficiaries ");
            }
        }

        private void del_ben_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            del_confirm_checkBox.Checked = false;
            delete_button.Enabled = false;
            richTextBox1.Text = "";
            if (del_ben_combobox.SelectedItem != null)
            {
                del_confirm_checkBox.Enabled = true;
            }
        }

        private void del_confirm_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (del_confirm_checkBox.Checked == true)
            {
                delete_button.Enabled = true;
            }
            else{
                delete_button.Enabled = false;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            if (del_ben_combobox.SelectedItem != null)
            {
                try
                {

                    string[] ben_array = del_ben_combobox.SelectedItem.ToString().Split(' ');
                    string selected_ben = del_ben_combobox.SelectedItem.ToString();
                    int account_number = Convert.ToInt32(ben_array[3]);
                    string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode = None";
                    string query = "DELETE FROM `beneficaries` WHERE ben_account_no='" + account_number + "'";

                    MySqlConnection con = new MySqlConnection(connection_string);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("beneficiary successfully removed ");
                    del_confirm_checkBox.Checked = false;
                    delete_button.Enabled = false;
                    del_confirm_checkBox.Enabled = false;
                    del_ben_combobox.Items.Remove(selected_ben);
                    list_of_ben_cbox.Items.Remove(selected_ben);
                    del_ben_combobox.SelectedItem = null;
                    richTextBox1.Text = "";
                    if(del_ben_combobox.Items== null)
                    {
                        del_ben_combobox.Text = "";
                        MessageBox.Show("YOU HAVE NO REMAINING BENEFICIARIES");
                    }

                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.ToString());
                }
              
                
            }
        }
    }
}
