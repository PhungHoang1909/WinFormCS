using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_TongHop
{
    public partial class Lab8 : Form
    {
        public Lab8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Lab1_Click(object sender, EventArgs e)
        {
            Lab1 fl1 = new Lab1();
            fl1.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lab2_Click(object sender, EventArgs e)
        {
            frmPuzzleGame fl2 = new frmPuzzleGame();
            fl2.Show();
            
        }

        private void btn_Lab3_Click(object sender, EventArgs e)
        {
            Lab3 fl3 = new Lab3();
            fl3.Show();
        }

        private void btn_Lab6_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form1 fl6 = new WindowsFormsApp1.Form1();
            fl6.Show();
        }

        private void btn_Lab7_Click(object sender, EventArgs e)
        {
            Lab7 fl7 = new Lab7();
            fl7.Show();
        }

        private void btn_Lab4_Click(object sender, EventArgs e)
        {
            Lab4 fl4 = new Lab4();
            fl4.Show();
        }

        private void btn_Lab5_Click(object sender, EventArgs e)
        {
            ImageProcessing.ImageProcessing fl5 = new ImageProcessing.ImageProcessing();
            fl5.Show();
        }
    }
}
