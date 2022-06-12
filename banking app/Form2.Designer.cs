
namespace banking_app
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.account_type_groupBox = new System.Windows.Forms.GroupBox();
            this.other_radioButton = new System.Windows.Forms.RadioButton();
            this.default_radiobutton = new System.Windows.Forms.RadioButton();
            this.current_radioButton = new System.Windows.Forms.RadioButton();
            this.savings_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.last_name_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.middle_nametextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fname_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.account_type_check_label = new System.Windows.Forms.Label();
            this.mnamecheck_label = new System.Windows.Forms.Label();
            this.lnamecheck_label = new System.Windows.Forms.Label();
            this.fnamecheck_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bank_check_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bank_comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.answer_richTextBox = new System.Windows.Forms.RichTextBox();
            this.question_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.account_type_groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // account_type_groupBox
            // 
            this.account_type_groupBox.Controls.Add(this.other_radioButton);
            this.account_type_groupBox.Controls.Add(this.default_radiobutton);
            this.account_type_groupBox.Controls.Add(this.current_radioButton);
            this.account_type_groupBox.Controls.Add(this.savings_radioButton);
            this.account_type_groupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_type_groupBox.Location = new System.Drawing.Point(49, 207);
            this.account_type_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.account_type_groupBox.Name = "account_type_groupBox";
            this.account_type_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.account_type_groupBox.Size = new System.Drawing.Size(328, 138);
            this.account_type_groupBox.TabIndex = 6;
            this.account_type_groupBox.TabStop = false;
            this.account_type_groupBox.Text = "Account Type";
            // 
            // other_radioButton
            // 
            this.other_radioButton.AutoSize = true;
            this.other_radioButton.Location = new System.Drawing.Point(196, 92);
            this.other_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.other_radioButton.Name = "other_radioButton";
            this.other_radioButton.Size = new System.Drawing.Size(80, 25);
            this.other_radioButton.TabIndex = 3;
            this.other_radioButton.TabStop = true;
            this.other_radioButton.Text = "Other";
            this.other_radioButton.UseVisualStyleBackColor = true;
            this.other_radioButton.CheckedChanged += new System.EventHandler(this.other_radioButton_CheckedChanged);
            // 
            // default_radiobutton
            // 
            this.default_radiobutton.AutoSize = true;
            this.default_radiobutton.Location = new System.Drawing.Point(10, 92);
            this.default_radiobutton.Margin = new System.Windows.Forms.Padding(2);
            this.default_radiobutton.Name = "default_radiobutton";
            this.default_radiobutton.Size = new System.Drawing.Size(92, 25);
            this.default_radiobutton.TabIndex = 2;
            this.default_radiobutton.TabStop = true;
            this.default_radiobutton.Text = "Default";
            this.default_radiobutton.UseVisualStyleBackColor = true;
            this.default_radiobutton.CheckedChanged += new System.EventHandler(this.default_radiobutton_CheckedChanged);
            // 
            // current_radioButton
            // 
            this.current_radioButton.AutoSize = true;
            this.current_radioButton.Location = new System.Drawing.Point(192, 32);
            this.current_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.current_radioButton.Name = "current_radioButton";
            this.current_radioButton.Size = new System.Drawing.Size(95, 25);
            this.current_radioButton.TabIndex = 1;
            this.current_radioButton.TabStop = true;
            this.current_radioButton.Text = "Current";
            this.current_radioButton.UseVisualStyleBackColor = true;
            this.current_radioButton.CheckedChanged += new System.EventHandler(this.current_radioButton_CheckedChanged);
            // 
            // savings_radioButton
            // 
            this.savings_radioButton.AutoSize = true;
            this.savings_radioButton.Location = new System.Drawing.Point(11, 32);
            this.savings_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.savings_radioButton.Name = "savings_radioButton";
            this.savings_radioButton.Size = new System.Drawing.Size(99, 25);
            this.savings_radioButton.TabIndex = 0;
            this.savings_radioButton.TabStop = true;
            this.savings_radioButton.Text = "Savings";
            this.savings_radioButton.UseVisualStyleBackColor = true;
            this.savings_radioButton.CheckedChanged += new System.EventHandler(this.savings_radioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.last_name_textBox);
            this.panel1.Controls.Add(this.middle_nametextBox);
            this.panel1.Controls.Add(this.fname_textBox);
            this.panel1.Controls.Add(this.account_type_check_label);
            this.panel1.Controls.Add(this.mnamecheck_label);
            this.panel1.Controls.Add(this.lnamecheck_label);
            this.panel1.Controls.Add(this.fnamecheck_label);
            this.panel1.Controls.Add(this.account_type_groupBox);
            this.panel1.Location = new System.Drawing.Point(11, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 364);
            this.panel1.TabIndex = 9;
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Depth = 0;
            this.last_name_textBox.Hint = "Last Name";
            this.last_name_textBox.Location = new System.Drawing.Point(57, 152);
            this.last_name_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.PasswordChar = '\0';
            this.last_name_textBox.SelectedText = "";
            this.last_name_textBox.SelectionLength = 0;
            this.last_name_textBox.SelectionStart = 0;
            this.last_name_textBox.Size = new System.Drawing.Size(310, 32);
            this.last_name_textBox.TabIndex = 12;
            this.last_name_textBox.UseSystemPasswordChar = false;
            this.last_name_textBox.TextChanged += new System.EventHandler(this.last_name_textBox_TextChanged_1);
            // 
            // middle_nametextBox
            // 
            this.middle_nametextBox.Depth = 0;
            this.middle_nametextBox.Hint = "Middle Name";
            this.middle_nametextBox.Location = new System.Drawing.Point(57, 93);
            this.middle_nametextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_nametextBox.Name = "middle_nametextBox";
            this.middle_nametextBox.PasswordChar = '\0';
            this.middle_nametextBox.SelectedText = "";
            this.middle_nametextBox.SelectionLength = 0;
            this.middle_nametextBox.SelectionStart = 0;
            this.middle_nametextBox.Size = new System.Drawing.Size(310, 32);
            this.middle_nametextBox.TabIndex = 11;
            this.middle_nametextBox.UseSystemPasswordChar = false;
            this.middle_nametextBox.TextChanged += new System.EventHandler(this.middle_nametextBox_TextChanged_1);
            // 
            // fname_textBox
            // 
            this.fname_textBox.Depth = 0;
            this.fname_textBox.Hint = "First Name";
            this.fname_textBox.Location = new System.Drawing.Point(53, 36);
            this.fname_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname_textBox.Name = "fname_textBox";
            this.fname_textBox.PasswordChar = '\0';
            this.fname_textBox.SelectedText = "";
            this.fname_textBox.SelectionLength = 0;
            this.fname_textBox.SelectionStart = 0;
            this.fname_textBox.Size = new System.Drawing.Size(314, 32);
            this.fname_textBox.TabIndex = 10;
            this.fname_textBox.UseSystemPasswordChar = false;
            this.fname_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged_1);
            // 
            // account_type_check_label
            // 
            this.account_type_check_label.AutoSize = true;
            this.account_type_check_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_type_check_label.ForeColor = System.Drawing.Color.Red;
            this.account_type_check_label.Location = new System.Drawing.Point(19, 205);
            this.account_type_check_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.account_type_check_label.Name = "account_type_check_label";
            this.account_type_check_label.Size = new System.Drawing.Size(26, 31);
            this.account_type_check_label.TabIndex = 8;
            this.account_type_check_label.Text = "*";
            // 
            // mnamecheck_label
            // 
            this.mnamecheck_label.AutoSize = true;
            this.mnamecheck_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnamecheck_label.ForeColor = System.Drawing.Color.Red;
            this.mnamecheck_label.Location = new System.Drawing.Point(19, 93);
            this.mnamecheck_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mnamecheck_label.Name = "mnamecheck_label";
            this.mnamecheck_label.Size = new System.Drawing.Size(26, 31);
            this.mnamecheck_label.TabIndex = 9;
            this.mnamecheck_label.Text = "*";
            // 
            // lnamecheck_label
            // 
            this.lnamecheck_label.AutoSize = true;
            this.lnamecheck_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnamecheck_label.ForeColor = System.Drawing.Color.Red;
            this.lnamecheck_label.Location = new System.Drawing.Point(19, 152);
            this.lnamecheck_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnamecheck_label.Name = "lnamecheck_label";
            this.lnamecheck_label.Size = new System.Drawing.Size(26, 31);
            this.lnamecheck_label.TabIndex = 8;
            this.lnamecheck_label.Text = "*";
            // 
            // fnamecheck_label
            // 
            this.fnamecheck_label.AutoSize = true;
            this.fnamecheck_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamecheck_label.ForeColor = System.Drawing.Color.Red;
            this.fnamecheck_label.Location = new System.Drawing.Point(19, 36);
            this.fnamecheck_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnamecheck_label.Name = "fnamecheck_label";
            this.fnamecheck_label.Size = new System.Drawing.Size(26, 31);
            this.fnamecheck_label.TabIndex = 7;
            this.fnamecheck_label.Text = "*";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.White;
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.Location = new System.Drawing.Point(64, 455);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(123, 90);
            this.back_button.TabIndex = 11;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.Color.White;
            this.next_button.Enabled = false;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Image = ((System.Drawing.Image)(resources.GetObject("next_button.Image")));
            this.next_button.Location = new System.Drawing.Point(689, 455);
            this.next_button.Margin = new System.Windows.Forms.Padding(2);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(123, 90);
            this.next_button.TabIndex = 10;
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.bank_check_label);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.bank_comboBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.answer_richTextBox);
            this.panel2.Controls.Add(this.question_richTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(455, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 364);
            this.panel2.TabIndex = 12;
            // 
            // bank_check_label
            // 
            this.bank_check_label.AutoSize = true;
            this.bank_check_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_check_label.ForeColor = System.Drawing.Color.Red;
            this.bank_check_label.Location = new System.Drawing.Point(2, 42);
            this.bank_check_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bank_check_label.Name = "bank_check_label";
            this.bank_check_label.Size = new System.Drawing.Size(26, 31);
            this.bank_check_label.TabIndex = 11;
            this.bank_check_label.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 302);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "MANDATORY QUESTION";
            // 
            // bank_comboBox
            // 
            this.bank_comboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bank_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank_comboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.bank_comboBox.FormattingEnabled = true;
            this.bank_comboBox.Items.AddRange(new object[] {
            "Access Bank",
            "Ecobank",
            "First Bank",
            "First City Monument Bank",
            "GT Bank",
            "Heritage Bank"});
            this.bank_comboBox.Location = new System.Drawing.Point(171, 45);
            this.bank_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.bank_comboBox.Name = "bank_comboBox";
            this.bank_comboBox.Size = new System.Drawing.Size(206, 28);
            this.bank_comboBox.TabIndex = 10;
            this.bank_comboBox.SelectedIndexChanged += new System.EventHandler(this.bank_comboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(11, 293);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 31);
            this.label12.TabIndex = 13;
            this.label12.Text = "*";
            // 
            // answer_richTextBox
            // 
            this.answer_richTextBox.Location = new System.Drawing.Point(149, 211);
            this.answer_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.answer_richTextBox.Name = "answer_richTextBox";
            this.answer_richTextBox.Size = new System.Drawing.Size(244, 63);
            this.answer_richTextBox.TabIndex = 9;
            this.answer_richTextBox.Text = "";
            // 
            // question_richTextBox
            // 
            this.question_richTextBox.Location = new System.Drawing.Point(154, 129);
            this.question_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.question_richTextBox.Name = "question_richTextBox";
            this.question_richTextBox.Size = new System.Drawing.Size(239, 57);
            this.question_richTextBox.TabIndex = 8;
            this.question_richTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "SELECT A BANK";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Security Question";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(382, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 90);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.account_type_groupBox.ResumeLayout(false);
            this.account_type_groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox account_type_groupBox;
        private System.Windows.Forms.RadioButton other_radioButton;
        private System.Windows.Forms.RadioButton default_radiobutton;
        private System.Windows.Forms.RadioButton current_radioButton;
        private System.Windows.Forms.RadioButton savings_radioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox bank_comboBox;
        private System.Windows.Forms.RichTextBox answer_richTextBox;
        private System.Windows.Forms.RichTextBox question_richTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label account_type_check_label;
        private System.Windows.Forms.Label mnamecheck_label;
        private System.Windows.Forms.Label lnamecheck_label;
        private System.Windows.Forms.Label fnamecheck_label;
        private System.Windows.Forms.Label bank_check_label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField fname_textBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField last_name_textBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField middle_nametextBox;
    }
}