using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, c, x, y, delta;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox1.Text);
            c = Convert.ToDouble(textBox1.Text);
            delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta > 0)
            {
                x = Convert.ToInt32((-b) - Math.Sqrt(delta)) / (2 * a);
                y = Convert.ToInt32((-b) + Math.Sqrt(delta)) / (2 * a);
                label6.Text = "X1 = " + x.ToString();
                label7.Text = "X2 = " + y.ToString();
            }
            else if (delta == 0)
            {
                x = Convert.ToInt32((-b) / (2 * a));
                label6.Text = "X = " + x.ToString();
            }
            else
            {
                label6.Text = "There is no solution";
            } */
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);

            }
            catch
            {
                MessageBox.Show("Nhap sai kieu du lieu", "Thong bao", MessageBoxButtons.OK);
                textBox4.Text = "Invalid";
            }
            delta = (b * b) - (4 * a * c);
                if (a == 0 && b == 0)
                {
                    textBox4.Text = "Vo so nghiem";
                }
                else if (a == 0)
                {
                    x = -c / b;
                    x = (double)System.Math.Round(x, 2);
                    textBox4.Text = "Nghiem X = " + x;
                }
                else if (delta < 0)
                {
                    textBox4.Text = "Phuong trinh vo nghiem";
                }
                else if (delta == 0)
                {
                    textBox4.Text = "Nghiem kep X1 = X2 = " + (-b / 2 / a);
                }
                else
                {
                    textBox4.Text = "2 nghiem \nX1 = " + ((-b + Math.Sqrt(delta)) / 2 / a) + " \nX2 = " + ((-b - Math.Sqrt(delta)) / 2 / a);
                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
