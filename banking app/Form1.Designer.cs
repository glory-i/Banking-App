
namespace banking_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.create_account_linkLabel = new System.Windows.Forms.LinkLabel();
            this.tpin_panel = new System.Windows.Forms.Panel();
            this.tpin_login_txtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tpin_login_button = new System.Windows.Forms.Button();
            this.mpin_panel = new System.Windows.Forms.Panel();
            this.login_mpin_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mpin_login_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tpin_panel.SuspendLayout();
            this.mpin_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK OF NIGERIA...";
            // 
            // create_account_linkLabel
            // 
            this.create_account_linkLabel.AutoSize = true;
            this.create_account_linkLabel.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_account_linkLabel.Location = new System.Drawing.Point(358, 504);
            this.create_account_linkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.create_account_linkLabel.Name = "create_account_linkLabel";
            this.create_account_linkLabel.Size = new System.Drawing.Size(432, 26);
            this.create_account_linkLabel.TabIndex = 3;
            this.create_account_linkLabel.TabStop = true;
            this.create_account_linkLabel.Text = "Don\'t Have an Account? Sign Up Here";
            this.create_account_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.create_account_linkLabel_LinkClicked);
            // 
            // tpin_panel
            // 
            this.tpin_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.tpin_panel.Controls.Add(this.tpin_login_txtbox);
            this.tpin_panel.Controls.Add(this.tpin_login_button);
            this.tpin_panel.Location = new System.Drawing.Point(118, 149);
            this.tpin_panel.Margin = new System.Windows.Forms.Padding(2);
            this.tpin_panel.Name = "tpin_panel";
            this.tpin_panel.Size = new System.Drawing.Size(563, 185);
            this.tpin_panel.TabIndex = 4;
            // 
            // tpin_login_txtbox
            // 
            this.tpin_login_txtbox.Depth = 0;
            this.tpin_login_txtbox.Hint = "Enter transaction pin";
            this.tpin_login_txtbox.Location = new System.Drawing.Point(32, 44);
            this.tpin_login_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.tpin_login_txtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpin_login_txtbox.Name = "tpin_login_txtbox";
            this.tpin_login_txtbox.PasswordChar = '\0';
            this.tpin_login_txtbox.SelectedText = "";
            this.tpin_login_txtbox.SelectionLength = 0;
            this.tpin_login_txtbox.SelectionStart = 0;
            this.tpin_login_txtbox.Size = new System.Drawing.Size(473, 32);
            this.tpin_login_txtbox.TabIndex = 4;
            this.tpin_login_txtbox.UseSystemPasswordChar = true;
            // 
            // tpin_login_button
            // 
            this.tpin_login_button.BackColor = System.Drawing.Color.Navy;
            this.tpin_login_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpin_login_button.ForeColor = System.Drawing.SystemColors.Window;
            this.tpin_login_button.Location = new System.Drawing.Point(132, 98);
            this.tpin_login_button.Margin = new System.Windows.Forms.Padding(2);
            this.tpin_login_button.Name = "tpin_login_button";
            this.tpin_login_button.Size = new System.Drawing.Size(203, 74);
            this.tpin_login_button.TabIndex = 3;
            this.tpin_login_button.Text = "LOG IN";
            this.tpin_login_button.UseVisualStyleBackColor = false;
            this.tpin_login_button.Click += new System.EventHandler(this.tpin_login_button_Click);
            // 
            // mpin_panel
            // 
            this.mpin_panel.BackColor = System.Drawing.Color.AliceBlue;
            this.mpin_panel.Controls.Add(this.login_mpin_textBox);
            this.mpin_panel.Controls.Add(this.mpin_login_button);
            this.mpin_panel.Location = new System.Drawing.Point(118, 134);
            this.mpin_panel.Margin = new System.Windows.Forms.Padding(2);
            this.mpin_panel.Name = "mpin_panel";
            this.mpin_panel.Size = new System.Drawing.Size(563, 199);
            this.mpin_panel.TabIndex = 5;
            // 
            // login_mpin_textBox
            // 
            this.login_mpin_textBox.Depth = 0;
            this.login_mpin_textBox.Hint = "Enter mpin to login";
            this.login_mpin_textBox.Location = new System.Drawing.Point(89, 58);
            this.login_mpin_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.login_mpin_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_mpin_textBox.Name = "login_mpin_textBox";
            this.login_mpin_textBox.PasswordChar = '\0';
            this.login_mpin_textBox.SelectedText = "";
            this.login_mpin_textBox.SelectionLength = 0;
            this.login_mpin_textBox.SelectionStart = 0;
            this.login_mpin_textBox.Size = new System.Drawing.Size(416, 32);
            this.login_mpin_textBox.TabIndex = 7;
            this.login_mpin_textBox.UseSystemPasswordChar = true;
            // 
            // mpin_login_button
            // 
            this.mpin_login_button.BackColor = System.Drawing.Color.Navy;
            this.mpin_login_button.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpin_login_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mpin_login_button.Location = new System.Drawing.Point(170, 113);
            this.mpin_login_button.Margin = new System.Windows.Forms.Padding(2);
            this.mpin_login_button.Name = "mpin_login_button";
            this.mpin_login_button.Size = new System.Drawing.Size(187, 74);
            this.mpin_login_button.TabIndex = 6;
            this.mpin_login_button.Text = "LOG IN";
            this.mpin_login_button.UseVisualStyleBackColor = false;
            this.mpin_login_button.Click += new System.EventHandler(this.mpin_login_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(20, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(451, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "...Delivering quality since 1960";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 565);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.create_account_linkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mpin_panel);
            this.Controls.Add(this.tpin_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tpin_panel.ResumeLayout(false);
            this.mpin_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel create_account_linkLabel;
        private System.Windows.Forms.Panel tpin_panel;
        private System.Windows.Forms.Panel mpin_panel;
        private System.Windows.Forms.Button mpin_login_button;
        private System.Windows.Forms.Button tpin_login_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField login_mpin_textBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField tpin_login_txtbox;
    }
}

