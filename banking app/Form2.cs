using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_app
{
    public partial class Form2 : Form
    {
        public static string f_name;
        public static string m_name;
        public static string l_name;
        public static string account_type;
        public static string bank_name;
        public static string question;
        public static string answer;




        public Form2()
        {
            InitializeComponent();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            f_name = fname_textBox.Text.ToUpper();
            l_name = last_name_textBox.Text.ToUpper();
            m_name = middle_nametextBox.Text.ToUpper();
            if (savings_radioButton.Checked)
            {
                account_type = savings_radioButton.Text;
            }
            if (current_radioButton.Checked)
            {
                account_type = current_radioButton.Text;
            }
            if (default_radiobutton.Checked)
            {
                account_type = default_radiobutton.Text;
            }
            if (other_radioButton.Checked)
            {
                account_type = other_radioButton.Text;
            }

            bank_name = bank_comboBox.SelectedItem.ToString();
            question = question_richTextBox.Text.ToString();
            answer = answer_richTextBox.Text.ToLower();
            
            Form3 my_form_3 = new Form3();
            my_form_3.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 my_form_1 = new Form1();
            my_form_1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //
        }

        private bool option_chosen()
        {
            bool an_option_chosen = false;
            if(savings_radioButton.Checked|| current_radioButton.Checked|| default_radiobutton.Checked|| other_radioButton.Checked)
            {
                an_option_chosen = true;
            }
            return an_option_chosen;
        }
        private void fname_textBox_TextChanged(object sender, EventArgs e)
        {
           /* if(fname_textBox.Text != "")
            {
                fnamecheck_label.Text = "";
            }
            else
            {
                fnamecheck_label.Text = "*";
            }
            
            if(fnamecheck_label.Text== "" && mnamecheck_label.Text=="" && lnamecheck_label.Text=="" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled =true;
            }
            else
            {
                next_button.Enabled = false;
            } */
        }

        private void middle_nametextBox_TextChanged(object sender, EventArgs e)
        {
          /*  if(middle_nametextBox.Text != "")
            {
                mnamecheck_label.Text = "";
            }
            else
            {
                mnamecheck_label.Text = "*";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            }
          */
        }

        private void last_name_textBox_TextChanged(object sender, EventArgs e)
        {
            /*
            if (last_name_textBox.Text != "")
            {
                lnamecheck_label.Text = "";
            }
            else
            {
                lnamecheck_label.Text = "*";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            } */
        }

        private void other_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (option_chosen())
            {
                account_type_check_label.Text = "";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            }

        }

        private void default_radiobutton_CheckedChanged(object sender, EventArgs e)
        {

            if (option_chosen())
            {
                account_type_check_label.Text = "";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            }
        }

        private void current_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (option_chosen())
            {
                account_type_check_label.Text = "";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            }
        }

        private void savings_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (option_chosen())
            {
                account_type_check_label.Text = "";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            }
        }

        private void bank_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bank_comboBox.SelectedItem != null)
            {
                bank_check_label.Text = "";
            }
            if(fnamecheck_label.Text== "" && mnamecheck_label.Text=="" && lnamecheck_label.Text=="" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled =true;
            }

            else
            {
                next_button.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fname_textBox_TextChanged_1(object sender, EventArgs e)
        {
            //

            if (fname_textBox.Text != "")
            {
                fnamecheck_label.Text = "";
            }
            else
            {
                fnamecheck_label.Text = "*";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }
            else
            {
                next_button.Enabled = false;
            }

        }

        private void middle_nametextBox_TextChanged_1(object sender, EventArgs e)
        {
            //

            if (middle_nametextBox.Text != "")
            {
                mnamecheck_label.Text = "";
            }
            else
            {
                mnamecheck_label.Text = "*";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            }
        }

        private void last_name_textBox_TextChanged_1(object sender, EventArgs e)
        {

            if (last_name_textBox.Text != "")
            {
                lnamecheck_label.Text = "";
            }
            else
            {
                lnamecheck_label.Text = "*";
            }

            if (fnamecheck_label.Text == "" && mnamecheck_label.Text == "" && lnamecheck_label.Text == "" && account_type_check_label.Text == "" && bank_check_label.Text == "")
            {
                next_button.Enabled = true;
            }

            else
            {
                next_button.Enabled = false;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
