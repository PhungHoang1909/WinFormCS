using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_20_2023
{
    public partial class Form2 : Form
    {
        public class SinhVien
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public double Math { get; set; }
            public double Phy { get; set; }
            public double Che { get; set; }
            public double Avg { get; set; }
            public string Rank { get; set; }
        }

        public List<SinhVien> ListSinhVien = new List<SinhVien>();

        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
