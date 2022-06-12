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
    
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            List<Transactions> list_of_transactions = new List<Transactions>();
            
            bool is_sender = false;
            int panel_x = 100;
            int panel_y = 100;

            string connection_string = "datasource =localhost;port=3306;username=root;password='';database=holiday_project;SSL Mode=None";
            string query = "Select * from transactions WHERE sender_account_number ='" + Form1.account_number + "' OR ben_account_number='" + Form1.account_number + "'";

            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try 
            {
                con.Open();
                reader = cmd.ExecuteReader();
                //
                while (reader.Read())
                {
                    Transactions my_transaction = new Transactions();
                    my_transaction.sender_first_name = reader.GetString(1);
                    my_transaction.sender_middle_name = reader.GetString(2);
                    my_transaction.sender_last_name = reader.GetString(3);
                    my_transaction.sender_account_number = reader.GetInt32(4);
                    my_transaction.ben_first_name = reader.GetString(5);
                    my_transaction.ben_middle_name = reader.GetString(6);
                    my_transaction.ben_last_name = reader.GetString(7);
                    my_transaction.ben_account_number = reader.GetInt32(8);
                    my_transaction.amount = reader.GetDouble(9);
                    my_transaction.narration = reader.GetString(10);
                    my_transaction.date_transaction = reader.GetString(11);
                    my_transaction.time_transaction = reader.GetString(12);

                    list_of_transactions.Add(my_transaction);
                }

                 list_of_transactions.Reverse();

                for(int i = 0; i < list_of_transactions.Count; i++)
                {
                    string label1text = "FROM: " + " " + list_of_transactions[i].sender_first_name + " " + list_of_transactions[i].sender_middle_name + " " + list_of_transactions[i].sender_last_name;
                    string label2text = "TO: " + list_of_transactions[i].ben_first_name + " " + list_of_transactions[i].ben_middle_name + " " + list_of_transactions[i].ben_last_name;
                    string label3text = "AMOUNT: " + Convert.ToString(list_of_transactions[i].amount);
                    string label4text = "NARRATION: " + list_of_transactions[i].narration;
                    string label5text = "DATE OF TRANSACTION : " + list_of_transactions[i].date_transaction;
                    string label6text = "TIME OF TRANSACTION : " + list_of_transactions[i].time_transaction;


                    int label_x = 10;
                    int label_y = 10;
                    Panel my_panel = new Panel();//remeber to increase panelY
                    my_panel.Location = new System.Drawing.Point(panel_x, panel_y);
                    my_panel.Size = new System.Drawing.Size(400, 250);


                    if (list_of_transactions[i].sender_account_number == Form1.account_number)
                    {
                        is_sender = true;
                    }
                    else
                    {
                        is_sender = false;
                    }


                    
                    Label l1 = new Label();
                    l1.Text = label1text;
                    l1.AutoSize = true;
                    l1.Location = new System.Drawing.Point(label_x, label_y);
                    l1.Padding = new Padding(10, 10, 10, 10);
                    l1.Font = new Font("Arial", 12, FontStyle.Bold);

                    label_y += l1.Height + 10;



                    Label l2 = new Label();
                    l2.Text = label2text;
                    l2.AutoSize = true;
                    l2.Location = new System.Drawing.Point(label_x, label_y);
                    l2.Padding = new Padding(10, 10, 10, 10);
                    l2.Font = new Font("Arial", 12, FontStyle.Bold);

                    label_y += l2.Height + 10;

                    Label l3 = new Label();
                    l3.Text = label3text;
                    l3.AutoSize = true;
                    l3.Location = new System.Drawing.Point(label_x, label_y);
                    l3.Padding = new Padding(10, 10, 10, 10);
                    l3.Font = new Font("Arial", 12, FontStyle.Bold);

                    label_y += l3.Height + 10;

                    Label l4 = new Label();
                    l4.Text = label4text;
                    l4.AutoSize = true;
                    l4.Location = new System.Drawing.Point(label_x, label_y);
                    l4.Padding = new Padding(10, 10, 10, 10);
                    l4.Font = new Font("Arial", 12, FontStyle.Bold);
                    label_y += l4.Height + 10;

                    Label l5 = new Label();
                    l5.Text = label5text;
                    l5.AutoSize = true;
                    l5.Location = new System.Drawing.Point(label_x, label_y);
                    l5.Font = new Font("Arial", 12, FontStyle.Bold);
                    l5.Padding = new Padding(10, 10, 10, 10);
                    label_y += l5.Height + 10;

                    Label l6 = new Label();
                    l6.Text = label6text;
                    l6.AutoSize = true;
                    l6.Location = new System.Drawing.Point(label_x, label_y);
                    l6.Padding = new Padding(10, 10, 10, 10);
                    l6.Font = new Font("Arial", 12, FontStyle.Bold);

                    label_y += l6.Height + 10;

                    if (is_sender)
                    {
                        my_panel.BackColor = Color.Red;
                    }
                    else
                    {
                        my_panel.BackColor = Color.SpringGreen;
                    }

                    my_panel.Controls.Add(l1);
                    my_panel.Controls.Add(l2);
                    my_panel.Controls.Add(l3);
                    my_panel.Controls.Add(l4);
                    my_panel.Controls.Add(l5);
                    my_panel.Controls.Add(l6);
                    //my_panel.Controls.Add(p1);
                    Controls.Add(my_panel);
                    panel_y += my_panel.Height + 10;

                }


            
                con.Close();
            }
            catch(Exception my_ex)
            {
                MessageBox.Show(my_ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myform4 = new Form4();
            myform4.Show();

        }
    }
    class Transactions
    {
        public int transaction_id;
        public string sender_first_name;
        public string sender_middle_name;
        public string sender_last_name;
        public int sender_account_number;
        public string ben_first_name;
        public string ben_last_name;
        public string ben_middle_name;
        public int ben_account_number;
        public double amount;
        public string narration;
        public string date_transaction;
        public string time_transaction;

    }
}
