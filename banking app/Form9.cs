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
    public partial class Form9 : Form
    {
        public static int card_number1;
        public static string card_bank1;
        public static int cvv1;
        public static string card_expiry_date1;
        
        
        public static int card_pin;

        public Form9()
        {
            InitializeComponent();
        }

        public string get_expiry_date(string my_date)
        {
            string[] date_array = my_date.Split('/');
            string expiry_date = date_array[1] +"/"+ date_array[2][2] + date_array[2][3];
            return expiry_date;
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            //card_pin_panel.BringToFront();
            //card_pin_panel.Visible = true;
            //change_view_button.Visible = false;
            /*string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL mode=None";
            string query = "Select * from cards where `account number` = '" + Form1.account_number + "'";

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
                    card_number1 = reader.GetInt32(3);
                    cvv1 = reader.GetInt32(1);
                    card_bank1 = reader.GetString(7);
                    card_expiry_date1 = get_expiry_date(reader.GetString(2));



                    card_number_label.Text = Convert.ToString(card_number1);
                    cvv_label.Text = Convert.ToString(cvv1);
                    bank_name_label.Text = card_bank1;
                    bank_name_label2.Text = card_bank1;

                    expiry_date_label.Text = Convert.ToString(card_expiry_date1);
                    name_label.Text = Form1.first_name +" "+ Form1.middle_name +" "+ Form1.last_name;
                }
                con.Close();

            }
            catch(Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myform4 = new Form4();
            myform4.Show();
        }

        private void expiry_date_label_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //
        }

        private void change_view_button_Click(object sender, EventArgs e)
        {
            if(change_view_button.Text =="VIEW BACK")
            {
                change_view_button.Text = "VIEW FRONT";
                panel2.BringToFront();
            }
            else
            {
                change_view_button.Text = "VIEW BACK";
                card_front_panel.BringToFront();
            }
        }

        private void view_card_Pin_Click(object sender, EventArgs e)
        {
            if (card_pin_tbox.UseSystemPasswordChar == true)
            {
                card_pin_tbox.UseSystemPasswordChar = false;
                view_card_Pin.Text = "HIDE";
            }
            else
            {
                card_pin_tbox.UseSystemPasswordChar = true;
                view_card_Pin.Text = "VIEW";

            }
        }

        private void view_confirm_card_pi_Click(object sender, EventArgs e)
        {
            if (confirm_card_pin_tbox.UseSystemPasswordChar == true)
            {
                confirm_card_pin_tbox.UseSystemPasswordChar = false;
                view_confirm_card_pi.Text = "HIDE";
            }
            else
            {
                confirm_card_pin_tbox.UseSystemPasswordChar = true;
                view_confirm_card_pi.Text = "VIEW";

            }

        }

        private void confirm_card_pin_tbox_TextChanged(object sender, EventArgs e)
        {
            confirm_card_checkBox.Checked = false;
            process_card_button.Enabled = false;
            if (confirm_card_pin_tbox.Text != card_pin_tbox.Text)
            {
                label_matching.Text = " card pins are not matching";
            }
            else
            {
                label_matching.Text = " ";
            }
            if (confirm_card_pin_tbox.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void confirm_card_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (confirm_card_checkBox.Checked == true)
            {
                bool valid_pin = false;
                bool same_length = false;
                bool is_integer = false;
                bool is_four = false;

                if (confirm_card_pin_tbox.Text == card_pin_tbox.Text)
                {
                    label_matching.Text = "";
                    same_length = true;
                }
                else
                {
                    label_matching.Text = " card pins are not matching ";
                    same_length = false;
                }
                
                if (confirm_card_pin_tbox.Text.Length == 4 )
                {
                    is_four = true;
                    try
                    {
                        card_pin = Convert.ToInt32(confirm_card_pin_tbox.Text);
                        is_integer = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Card pin must be digits");
                        is_integer = false;
                    }
                }
                else
                {
                    MessageBox.Show("Card pin must be 4 digits only.");
                    is_four=false;
                }
                if (is_four == true && is_integer==true && same_length==true)
                {
                    valid_pin = true;
                    process_card_button.Enabled = true;
                }
                else
                {
                    process_card_button.Enabled = false;
                    confirm_card_checkBox.Checked = false;
                }
                

            }
        }

        private void card_pin_tbox_TextChanged(object sender, EventArgs e)
        {
            confirm_card_checkBox.Checked = false;
            
            process_card_button.Enabled = false;
            if (confirm_card_pin_tbox.Text != card_pin_tbox.Text)
            {
                label_matching.Text = " card pins are not matching";
            }
            else
            {
                label_matching.Text = " ";
            }
            if (card_pin_tbox.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
        }

        private int generate_cvv()
        {
            string my_string = "";
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                my_string += Convert.ToString(r.Next(1, 10));
            }
            int cvv = Convert.ToInt32(my_string);
            return cvv;
        }

        private void process_card_button_Click(object sender, EventArgs e)
        {
            //
            int mpin = Form1.user_mpin;
            int cvv = generate_cvv();
            string expiry_date = dateTimePicker1.Value.Date.AddMonths(24).ToString("yyyyMMdd");
            int acc_no = Form1.account_number;
            int tpin = Form1.user_transaction_pin;
            string account_type = Form1.account_type;
            string bank_name = Form1.bank_name;
            string card_type = cardtypes_cbox.SelectedItem.ToString().ToLower();

            string connection_string2 = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query2 = "INSERT INTO cards VALUES ('" + mpin + "','" + cvv + "','" + expiry_date + "','','" + acc_no + "','" + tpin + "','" + account_type + "','" + bank_name + "','" + Form1.first_name + "','" + Form1.middle_name + "','" + Form1.last_name + "','" + card_pin + "','"+card_type+"')";
            MySqlConnection con2 = new MySqlConnection(connection_string2);
            MySqlCommand cmd2 = new MySqlCommand(query2, con2);
            MySqlDataReader reader2;

            try
            {
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                MessageBox.Show("card successfully processed ");
                process_card_button.Enabled = false;
                confirm_card_checkBox.Checked = false;
                con2.Close();

            }
            catch (Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }








            string connection_string = "datasource=localhost;port=3306;username=root;password='';database=holiday_project;SSL mode=None";
            string query = "Select * from cards where `account number` = '" + Form1.account_number + "'";

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
                    card_number1 = reader.GetInt32(3);
                    cvv1 = reader.GetInt32(1);
                    card_bank1 = reader.GetString(7);
                    card_expiry_date1 = get_expiry_date(reader.GetString(2));



                    card_number_label.Text = Convert.ToString(card_number1);
                    cvv_label.Text = Convert.ToString(cvv1);
                    bank_name_label.Text = card_bank1;
                    bank_name_label2.Text = card_bank1;

                    expiry_date_label.Text = Convert.ToString(card_expiry_date1);
                    name_label.Text = Form1.first_name + " " + Form1.middle_name + " " + Form1.last_name;

                    if (card_type == "verve")
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\gloryiweriebor\Pictures\verveicon2.png");
                    }
                    if(card_type== "mastercard")
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\gloryiweriebor\Pictures\pictures for banking app\mastercard3.png");
                    }
                    if(card_type== "visa")
                    {
                        pictureBox3.Image = Image.FromFile(@"C:\Users\gloryiweriebor\Pictures\pictures for banking app\visa3.png");

                    }

                }
                con.Close();
                card_pin_panel.SendToBack();
                card_pin_panel.Visible = false;
                change_view_button.Visible = true;

            }
            catch (Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }
        }

        private void cardtypes_cbox_SelectedValueChanged(object sender, EventArgs e)
        {
            confirm_card_checkBox.Checked = false;
            if(cardtypes_cbox.SelectedItem!= null)
            {
                confirm_card_checkBox.Enabled = true;
                label6.Visible = false;
            }
            else
            {
                confirm_card_checkBox.Enabled = false;
                label6.Visible = true;
            }
        }

        private void cardtypes_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void confirm_card_pin_tbox_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
