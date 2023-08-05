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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int hoursWorked = int.Parse(textBoxHourWork.Text);
                int dependents = int.Parse(textBoxNoDependent.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nhap vao di dmm");
            }
            // Calculate the take-home pay
            double GrossPay = 150 * hoursWorked;
            double deferralDeduction = (GrossPay -( GrossPay * 0.0575 * dependents)) * 0.25;
            double SocSec = GrossPay * 0.0785;
            double agencyFee = GrossPay * 0.13;
            double net = GrossPay - SocSec - deferralDeduction - agencyFee;

            // Show Form2 with the results
            this.Hide();
            Form2 form2 = new Form2 (GrossPay, deferralDeduction, name, SocSec, agencyFee, net);
            form2.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
                    }

        private void textBoxHourWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNoDependent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxHourWork.Text = null;
            textBoxName.Text = null;
            textBoxNoDependent.Text = null;
        }
    }
}
