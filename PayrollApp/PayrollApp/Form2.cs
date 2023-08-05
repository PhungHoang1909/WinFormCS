using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class Form2 : Form
    {
        public Form2(double GrossPay, double deferralDeduction, string name, double SocSec, double agencyFee, double net)
        {
            InitializeComponent();
            textBoxName.Text = name;
            labeGrossPay.Text = "Gross Pay: $" + GrossPay.ToString("0.00");
            lbldeferralDeduction.Text = "Deferral: $" + deferralDeduction.ToString("0.00");
            lblSocSec.Text= "Soc Sec Ded: $" + SocSec.ToString("0.00");
            lblAgencyFee.Text = "Agency Fee: $" + agencyFee.ToString("0.00");
            lblnet.Text = "Net Pay: $" + net.ToString("0.00");



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }
    }
}
