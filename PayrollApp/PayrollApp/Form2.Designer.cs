namespace PayrollApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labeGrossPay = new System.Windows.Forms.Label();
            this.lbldeferralDeduction = new System.Windows.Forms.Label();
            this.lblSocSec = new System.Windows.Forms.Label();
            this.lblAgencyFee = new System.Windows.Forms.Label();
            this.lblnet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "XYZ JobSource";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(256, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeGrossPay
            // 
            this.labeGrossPay.AutoSize = true;
            this.labeGrossPay.Location = new System.Drawing.Point(106, 209);
            this.labeGrossPay.Name = "labeGrossPay";
            this.labeGrossPay.Size = new System.Drawing.Size(82, 17);
            this.labeGrossPay.TabIndex = 11;
            this.labeGrossPay.Text = "Gross Pay: ";
            this.labeGrossPay.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbldeferralDeduction
            // 
            this.lbldeferralDeduction.AutoSize = true;
            this.lbldeferralDeduction.Location = new System.Drawing.Point(110, 255);
            this.lbldeferralDeduction.Name = "lbldeferralDeduction";
            this.lbldeferralDeduction.Size = new System.Drawing.Size(90, 17);
            this.lbldeferralDeduction.TabIndex = 12;
            this.lbldeferralDeduction.Text = "Federal Ded:";
            this.lbldeferralDeduction.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblSocSec
            // 
            this.lblSocSec.AutoSize = true;
            this.lblSocSec.Location = new System.Drawing.Point(110, 301);
            this.lblSocSec.Name = "lblSocSec";
            this.lblSocSec.Size = new System.Drawing.Size(94, 17);
            this.lblSocSec.TabIndex = 13;
            this.lblSocSec.Text = "Soc Sec Ded:";
            // 
            // lblAgencyFee
            // 
            this.lblAgencyFee.AutoSize = true;
            this.lblAgencyFee.Location = new System.Drawing.Point(106, 348);
            this.lblAgencyFee.Name = "lblAgencyFee";
            this.lblAgencyFee.Size = new System.Drawing.Size(87, 17);
            this.lblAgencyFee.TabIndex = 14;
            this.lblAgencyFee.Text = "Agency Fee:";
            this.lblAgencyFee.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblnet
            // 
            this.lblnet.AutoSize = true;
            this.lblnet.Location = new System.Drawing.Point(110, 401);
            this.lblnet.Name = "lblnet";
            this.lblnet.Size = new System.Drawing.Size(62, 17);
            this.lblnet.TabIndex = 15;
            this.lblnet.Text = "Net Pay:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 490);
            this.Controls.Add(this.lblnet);
            this.Controls.Add(this.lblAgencyFee);
            this.Controls.Add(this.lblSocSec);
            this.Controls.Add(this.lbldeferralDeduction);
            this.Controls.Add(this.labeGrossPay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeGrossPay;
        private System.Windows.Forms.Label lbldeferralDeduction;
        private System.Windows.Forms.Label lblSocSec;
        private System.Windows.Forms.Label lblAgencyFee;
        private System.Windows.Forms.Label lblnet;
    }
}