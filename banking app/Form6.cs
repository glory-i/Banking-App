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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.first_name + " " + Form1.middle_name + " " + Form1.last_name;
            textBox1.Text = Form1.account_number.ToString();
            textBox4.Text = Form1.account_balance.ToString();
            textBox3.Text = Form1.account_type.ToString();
            textBox2.Text = Form1.bank_name.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myform4 = new Form4();
            myform4.Show();

        }
    }
}
