
namespace banking_app
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.account_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.beneficiary_bank_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enter_amount_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.display_beneficiary_label = new System.Windows.Forms.Label();
            this.confirm_checkBox = new System.Windows.Forms.CheckBox();
            this.transfer_money_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tpin_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.save_beneficiary_button = new System.Windows.Forms.Button();
            this.back_button_5 = new System.Windows.Forms.Button();
            this.beneficiary_acc_numbertextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.beneficiary_pictureBox = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiary_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // account_comboBox
            // 
            this.account_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.account_comboBox.FormattingEnabled = true;
            this.account_comboBox.Location = new System.Drawing.Point(36, 59);
            this.account_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.account_comboBox.Name = "account_comboBox";
            this.account_comboBox.Size = new System.Drawing.Size(579, 28);
            this.account_comboBox.TabIndex = 2;
            this.account_comboBox.SelectedIndexChanged += new System.EventHandler(this.account_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select an account to debit";
            // 
            // beneficiary_bank_comboBox
            // 
            this.beneficiary_bank_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beneficiary_bank_comboBox.FormattingEnabled = true;
            this.beneficiary_bank_comboBox.Items.AddRange(new object[] {
            "Access Bank",
            "Ecobank",
            "First Bank",
            "First City Monument Bank",
            "GT Bank",
            "Heritage Bank"});
            this.beneficiary_bank_comboBox.Location = new System.Drawing.Point(217, 118);
            this.beneficiary_bank_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.beneficiary_bank_comboBox.Name = "beneficiary_bank_comboBox";
            this.beneficiary_bank_comboBox.Size = new System.Drawing.Size(407, 28);
            this.beneficiary_bank_comboBox.TabIndex = 4;
            this.beneficiary_bank_comboBox.SelectedIndexChanged += new System.EventHandler(this.beneficiary_bank_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select beneficiary bank ";
            // 
            // enter_amount_textBox
            // 
            this.enter_amount_textBox.Location = new System.Drawing.Point(231, 344);
            this.enter_amount_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.enter_amount_textBox.Name = "enter_amount_textBox";
            this.enter_amount_textBox.ReadOnly = true;
            this.enter_amount_textBox.Size = new System.Drawing.Size(276, 26);
            this.enter_amount_textBox.TabIndex = 7;
            this.enter_amount_textBox.TextChanged += new System.EventHandler(this.enter_amount_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Amount";
            // 
            // display_beneficiary_label
            // 
            this.display_beneficiary_label.AutoSize = true;
            this.display_beneficiary_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_beneficiary_label.Location = new System.Drawing.Point(177, 247);
            this.display_beneficiary_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.display_beneficiary_label.Name = "display_beneficiary_label";
            this.display_beneficiary_label.Size = new System.Drawing.Size(59, 22);
            this.display_beneficiary_label.TabIndex = 8;
            this.display_beneficiary_label.Text = "label5";
            // 
            // confirm_checkBox
            // 
            this.confirm_checkBox.AutoSize = true;
            this.confirm_checkBox.Enabled = false;
            this.confirm_checkBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_checkBox.Location = new System.Drawing.Point(217, 482);
            this.confirm_checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirm_checkBox.Name = "confirm_checkBox";
            this.confirm_checkBox.Size = new System.Drawing.Size(242, 26);
            this.confirm_checkBox.TabIndex = 9;
            this.confirm_checkBox.Text = "CONFIRM TRANSACTION";
            this.confirm_checkBox.UseVisualStyleBackColor = true;
            this.confirm_checkBox.CheckedChanged += new System.EventHandler(this.confirm_checkBox_CheckedChanged);
            // 
            // transfer_money_button
            // 
            this.transfer_money_button.BackColor = System.Drawing.Color.AliceBlue;
            this.transfer_money_button.Enabled = false;
            this.transfer_money_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer_money_button.ForeColor = System.Drawing.Color.Navy;
            this.transfer_money_button.Image = ((System.Drawing.Image)(resources.GetObject("transfer_money_button.Image")));
            this.transfer_money_button.Location = new System.Drawing.Point(513, 477);
            this.transfer_money_button.Margin = new System.Windows.Forms.Padding(2);
            this.transfer_money_button.Name = "transfer_money_button";
            this.transfer_money_button.Size = new System.Drawing.Size(172, 114);
            this.transfer_money_button.TabIndex = 10;
            this.transfer_money_button.Text = "TRANSFER ";
            this.transfer_money_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.transfer_money_button.UseVisualStyleBackColor = false;
            this.transfer_money_button.Click += new System.EventHandler(this.transfer_money_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Narration";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 416);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 26);
            this.textBox1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.save_beneficiary_button);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(35, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 619);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 57);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(211, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "TRANSACTION RECEIPT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(486, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "PROCEED";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(132, 467);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(536, 23);
            this.textBox8.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 469);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Narration";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(199, 405);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(469, 23);
            this.textBox7.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 405);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Beneficiary Bank ";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(199, 339);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(469, 23);
            this.textBox6.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 339);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Beneficiary Name";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(278, 267);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(390, 23);
            this.textBox5.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Beneficiary Account Number";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(229, 207);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(439, 23);
            this.textBox4.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Source Account Name";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(265, 144);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(403, 23);
            this.textBox3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Source Account";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(265, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(403, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.tpin_textbox);
            this.panel2.Controls.Add(this.back_button_5);
            this.panel2.Controls.Add(this.beneficiary_acc_numbertextBox);
            this.panel2.Controls.Add(this.beneficiary_pictureBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.account_comboBox);
            this.panel2.Controls.Add(this.display_beneficiary_label);
            this.panel2.Controls.Add(this.beneficiary_bank_comboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.confirm_checkBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.enter_amount_textBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.transfer_money_button);
            this.panel2.Location = new System.Drawing.Point(33, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 619);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tpin_textbox
            // 
            this.tpin_textbox.Depth = 0;
            this.tpin_textbox.Hint = "ENTER TRANSACTION PIN";
            this.tpin_textbox.Location = new System.Drawing.Point(85, 573);
            this.tpin_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpin_textbox.Name = "tpin_textbox";
            this.tpin_textbox.PasswordChar = '\0';
            this.tpin_textbox.SelectedText = "";
            this.tpin_textbox.SelectionLength = 0;
            this.tpin_textbox.SelectionStart = 0;
            this.tpin_textbox.Size = new System.Drawing.Size(423, 32);
            this.tpin_textbox.TabIndex = 18;
            this.tpin_textbox.UseSystemPasswordChar = true;
            this.tpin_textbox.Visible = false;
            // 
            // save_beneficiary_button
            // 
            this.save_beneficiary_button.BackColor = System.Drawing.Color.Navy;
            this.save_beneficiary_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_beneficiary_button.ForeColor = System.Drawing.Color.GhostWhite;
            this.save_beneficiary_button.Location = new System.Drawing.Point(62, 513);
            this.save_beneficiary_button.Name = "save_beneficiary_button";
            this.save_beneficiary_button.Size = new System.Drawing.Size(155, 78);
            this.save_beneficiary_button.TabIndex = 17;
            this.save_beneficiary_button.Text = "SAVE BENEFICIARY";
            this.save_beneficiary_button.UseVisualStyleBackColor = false;
            this.save_beneficiary_button.Visible = false;
            this.save_beneficiary_button.Click += new System.EventHandler(this.save_beneficiary_button_Click);
            // 
            // back_button_5
            // 
            this.back_button_5.BackColor = System.Drawing.Color.AliceBlue;
            this.back_button_5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button_5.ForeColor = System.Drawing.Color.Navy;
            this.back_button_5.Image = ((System.Drawing.Image)(resources.GetObject("back_button_5.Image")));
            this.back_button_5.Location = new System.Drawing.Point(15, 459);
            this.back_button_5.Margin = new System.Windows.Forms.Padding(2);
            this.back_button_5.Name = "back_button_5";
            this.back_button_5.Size = new System.Drawing.Size(115, 109);
            this.back_button_5.TabIndex = 16;
            this.back_button_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.back_button_5.UseVisualStyleBackColor = false;
            this.back_button_5.Click += new System.EventHandler(this.back_button_5_Click);
            // 
            // beneficiary_acc_numbertextBox
            // 
            this.beneficiary_acc_numbertextBox.Depth = 0;
            this.beneficiary_acc_numbertextBox.Hint = "Enter Beneficiary Account Number";
            this.beneficiary_acc_numbertextBox.Location = new System.Drawing.Point(0, 185);
            this.beneficiary_acc_numbertextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.beneficiary_acc_numbertextBox.Name = "beneficiary_acc_numbertextBox";
            this.beneficiary_acc_numbertextBox.PasswordChar = '\0';
            this.beneficiary_acc_numbertextBox.SelectedText = "";
            this.beneficiary_acc_numbertextBox.SelectionLength = 0;
            this.beneficiary_acc_numbertextBox.SelectionStart = 0;
            this.beneficiary_acc_numbertextBox.Size = new System.Drawing.Size(847, 32);
            this.beneficiary_acc_numbertextBox.TabIndex = 15;
            this.beneficiary_acc_numbertextBox.UseSystemPasswordChar = false;
            this.beneficiary_acc_numbertextBox.Click += new System.EventHandler(this.beneficiary_acc_numbertextBox_Click);
            this.beneficiary_acc_numbertextBox.TextChanged += new System.EventHandler(this.beneficiary_acc_numbertextBox_TextChanged_1);
            // 
            // beneficiary_pictureBox
            // 
            this.beneficiary_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("beneficiary_pictureBox.Image")));
            this.beneficiary_pictureBox.Location = new System.Drawing.Point(36, 233);
            this.beneficiary_pictureBox.Name = "beneficiary_pictureBox";
            this.beneficiary_pictureBox.Size = new System.Drawing.Size(138, 97);
            this.beneficiary_pictureBox.TabIndex = 14;
            this.beneficiary_pictureBox.TabStop = false;
            this.beneficiary_pictureBox.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(717, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 656);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiary_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox account_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox beneficiary_bank_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enter_amount_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label display_beneficiary_label;
        private System.Windows.Forms.CheckBox confirm_checkBox;
        private System.Windows.Forms.Button transfer_money_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox beneficiary_pictureBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField beneficiary_acc_numbertextBox;
        private System.Windows.Forms.Button back_button_5;
        private System.Windows.Forms.Button save_beneficiary_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tpin_textbox;
    }
}