
namespace banking_app
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.block_card_panel = new System.Windows.Forms.Panel();
            this.back_button_blockcard = new System.Windows.Forms.Button();
            this.proceed_button_blockcard = new System.Windows.Forms.Button();
            this.block_card_textbox = new System.Windows.Forms.RichTextBox();
            this.block_card_question_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.block_card_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // block_card_panel
            // 
            this.block_card_panel.BackColor = System.Drawing.Color.Ivory;
            this.block_card_panel.Controls.Add(this.back_button_blockcard);
            this.block_card_panel.Controls.Add(this.proceed_button_blockcard);
            this.block_card_panel.Controls.Add(this.block_card_textbox);
            this.block_card_panel.Controls.Add(this.block_card_question_label);
            this.block_card_panel.Controls.Add(this.label1);
            this.block_card_panel.Location = new System.Drawing.Point(75, 28);
            this.block_card_panel.Margin = new System.Windows.Forms.Padding(2);
            this.block_card_panel.Name = "block_card_panel";
            this.block_card_panel.Size = new System.Drawing.Size(636, 431);
            this.block_card_panel.TabIndex = 1;
            // 
            // back_button_blockcard
            // 
            this.back_button_blockcard.BackColor = System.Drawing.Color.Navy;
            this.back_button_blockcard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button_blockcard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back_button_blockcard.Location = new System.Drawing.Point(45, 292);
            this.back_button_blockcard.Margin = new System.Windows.Forms.Padding(2);
            this.back_button_blockcard.Name = "back_button_blockcard";
            this.back_button_blockcard.Size = new System.Drawing.Size(187, 89);
            this.back_button_blockcard.TabIndex = 4;
            this.back_button_blockcard.Text = "BACK";
            this.back_button_blockcard.UseVisualStyleBackColor = false;
            this.back_button_blockcard.Click += new System.EventHandler(this.back_button_blockcard_Click);
            // 
            // proceed_button_blockcard
            // 
            this.proceed_button_blockcard.BackColor = System.Drawing.Color.Navy;
            this.proceed_button_blockcard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_button_blockcard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.proceed_button_blockcard.Location = new System.Drawing.Point(417, 292);
            this.proceed_button_blockcard.Margin = new System.Windows.Forms.Padding(2);
            this.proceed_button_blockcard.Name = "proceed_button_blockcard";
            this.proceed_button_blockcard.Size = new System.Drawing.Size(187, 89);
            this.proceed_button_blockcard.TabIndex = 3;
            this.proceed_button_blockcard.Text = "PROCEED";
            this.proceed_button_blockcard.UseVisualStyleBackColor = false;
            this.proceed_button_blockcard.Click += new System.EventHandler(this.proceed_button_blockcard_Click);
            // 
            // block_card_textbox
            // 
            this.block_card_textbox.Location = new System.Drawing.Point(36, 124);
            this.block_card_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.block_card_textbox.Name = "block_card_textbox";
            this.block_card_textbox.Size = new System.Drawing.Size(422, 119);
            this.block_card_textbox.TabIndex = 2;
            this.block_card_textbox.Text = "";
            // 
            // block_card_question_label
            // 
            this.block_card_question_label.AutoSize = true;
            this.block_card_question_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_card_question_label.Location = new System.Drawing.Point(32, 73);
            this.block_card_question_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block_card_question_label.Name = "block_card_question_label";
            this.block_card_question_label.Size = new System.Drawing.Size(62, 21);
            this.block_card_question_label.TabIndex = 1;
            this.block_card_question_label.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "To block card Answer your security question";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 517);
            this.Controls.Add(this.block_card_panel);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.block_card_panel.ResumeLayout(false);
            this.block_card_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel block_card_panel;
        private System.Windows.Forms.Button back_button_blockcard;
        private System.Windows.Forms.Button proceed_button_blockcard;
        private System.Windows.Forms.RichTextBox block_card_textbox;
        private System.Windows.Forms.Label block_card_question_label;
        private System.Windows.Forms.Label label1;
    }
}