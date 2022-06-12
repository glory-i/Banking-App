
namespace banking_app
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpin_textbox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.tpin_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mpin_textbox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.mpin_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.matching_tpin_label = new System.Windows.Forms.Label();
            this.matching_mpin_label = new System.Windows.Forms.Label();
            this.done_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.tpin_textbox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tpin_textbox);
            this.panel1.Controls.Add(this.mpin_textbox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mpin_textbox);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.matching_tpin_label);
            this.panel1.Controls.Add(this.matching_mpin_label);
            this.panel1.Location = new System.Drawing.Point(23, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 396);
            this.panel1.TabIndex = 2;
            // 
            // tpin_textbox2
            // 
            this.tpin_textbox2.Depth = 0;
            this.tpin_textbox2.Hint = "Confirm transaction pin";
            this.tpin_textbox2.Location = new System.Drawing.Point(15, 277);
            this.tpin_textbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpin_textbox2.Name = "tpin_textbox2";
            this.tpin_textbox2.PasswordChar = '\0';
            this.tpin_textbox2.SelectedText = "";
            this.tpin_textbox2.SelectionLength = 0;
            this.tpin_textbox2.SelectionStart = 0;
            this.tpin_textbox2.Size = new System.Drawing.Size(420, 32);
            this.tpin_textbox2.TabIndex = 12;
            this.tpin_textbox2.UseSystemPasswordChar = true;
            this.tpin_textbox2.TextChanged += new System.EventHandler(this.tpin_textbox2_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(556, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "NOTE: DEFAULT STARTING ACCOUNT BALANCE IS 500.0";
            // 
            // tpin_textbox
            // 
            this.tpin_textbox.Depth = 0;
            this.tpin_textbox.Hint = "Enter 4 digit transaction pin";
            this.tpin_textbox.Location = new System.Drawing.Point(15, 209);
            this.tpin_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpin_textbox.Name = "tpin_textbox";
            this.tpin_textbox.PasswordChar = '\0';
            this.tpin_textbox.SelectedText = "";
            this.tpin_textbox.SelectionLength = 0;
            this.tpin_textbox.SelectionStart = 0;
            this.tpin_textbox.Size = new System.Drawing.Size(420, 32);
            this.tpin_textbox.TabIndex = 12;
            this.tpin_textbox.UseSystemPasswordChar = true;
            this.tpin_textbox.TextChanged += new System.EventHandler(this.tpin_textbox_TextChanged_1);
            // 
            // mpin_textbox2
            // 
            this.mpin_textbox2.Depth = 0;
            this.mpin_textbox2.Hint = "Confirm your mpin";
            this.mpin_textbox2.Location = new System.Drawing.Point(15, 117);
            this.mpin_textbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpin_textbox2.Name = "mpin_textbox2";
            this.mpin_textbox2.PasswordChar = '\0';
            this.mpin_textbox2.SelectedText = "";
            this.mpin_textbox2.SelectionLength = 0;
            this.mpin_textbox2.SelectionStart = 0;
            this.mpin_textbox2.Size = new System.Drawing.Size(420, 32);
            this.mpin_textbox2.TabIndex = 12;
            this.mpin_textbox2.UseSystemPasswordChar = true;
            this.mpin_textbox2.TextChanged += new System.EventHandler(this.mpin_textbox2_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "MPIN MUST BE AT LEAST 5 DIGITS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mpin_textbox
            // 
            this.mpin_textbox.Depth = 0;
            this.mpin_textbox.Hint = "Enter mpin";
            this.mpin_textbox.Location = new System.Drawing.Point(15, 58);
            this.mpin_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpin_textbox.Name = "mpin_textbox";
            this.mpin_textbox.PasswordChar = '\0';
            this.mpin_textbox.SelectedText = "";
            this.mpin_textbox.SelectionLength = 0;
            this.mpin_textbox.SelectionStart = 0;
            this.mpin_textbox.Size = new System.Drawing.Size(420, 32);
            this.mpin_textbox.TabIndex = 12;
            this.mpin_textbox.UseSystemPasswordChar = true;
            this.mpin_textbox.TextChanged += new System.EventHandler(this.mpin_textbox_TextChanged_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(472, 277);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 47);
            this.button5.TabIndex = 13;
            this.button5.Text = "View";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(472, 194);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(472, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(472, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // matching_tpin_label
            // 
            this.matching_tpin_label.AutoSize = true;
            this.matching_tpin_label.Location = new System.Drawing.Point(78, 328);
            this.matching_tpin_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matching_tpin_label.Name = "matching_tpin_label";
            this.matching_tpin_label.Size = new System.Drawing.Size(14, 20);
            this.matching_tpin_label.TabIndex = 9;
            this.matching_tpin_label.Text = "`";
            // 
            // matching_mpin_label
            // 
            this.matching_mpin_label.AutoSize = true;
            this.matching_mpin_label.Location = new System.Drawing.Point(78, 165);
            this.matching_mpin_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matching_mpin_label.Name = "matching_mpin_label";
            this.matching_mpin_label.Size = new System.Drawing.Size(13, 20);
            this.matching_mpin_label.TabIndex = 8;
            this.matching_mpin_label.Text = ".";
            // 
            // done_button
            // 
            this.done_button.BackColor = System.Drawing.Color.Snow;
            this.done_button.Enabled = false;
            this.done_button.ForeColor = System.Drawing.Color.Navy;
            this.done_button.Image = ((System.Drawing.Image)(resources.GetObject("done_button.Image")));
            this.done_button.Location = new System.Drawing.Point(495, 426);
            this.done_button.Margin = new System.Windows.Forms.Padding(2);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(160, 97);
            this.done_button.TabIndex = 3;
            this.done_button.Text = "SIGN UP";
            this.done_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.done_button.UseVisualStyleBackColor = false;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(71, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 87);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Snow;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(282, 431);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 87);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 539);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label matching_tpin_label;
        private System.Windows.Forms.Label matching_mpin_label;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private MaterialSkin.Controls.MaterialSingleLineTextField mpin_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField mpin_textbox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tpin_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField tpin_textbox2;
    }
}