using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _7_20_2023
{
    public partial class Form1 : Form
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
        int MaSV = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSV_Click(object sender, EventArgs e)
        {
            if (MathBox.Text == "" || NameBox.Text == "" || AgeBox.Text == "" ||
                    GenderBox.Text == "" || PhyBox.Text == "" || CheBox.Text == "")
            { UpdateIDlbl.Text = "Please enter all the fields"; }
            else
            {
                MaSV++;
                string HocLuc;
                double DiemTB = (double.Parse(MathBox.Text) + double.Parse(PhyBox.Text) + double.Parse(CheBox.Text)) / 3;
                if (DiemTB >= 8) { HocLuc = "Good"; }
                else if (DiemTB >= 6.5) { HocLuc = "Medium"; }
                else if (DiemTB >= 5) { HocLuc = "Avg"; }
                else { HocLuc = "Bad"; }

                ListSinhVien.Add(new SinhVien
                {
                    ID = MaSV,
                    Name = NameBox.Text,
                    Gender = GenderBox.Text,
                    Age = int.Parse(AgeBox.Text),
                    Math = double.Parse(MathBox.Text),
                    Phy = double.Parse(PhyBox.Text),
                    Che = double.Parse(CheBox.Text),
                    Avg = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero),
                    Rank = HocLuc
                });
            }
        }

        private void ShowSV_Click(object sender, EventArgs e)
        {
            ShowID.Text = ShowName.Text = ShowAge.Text = ShowGender.Text = ShowMath.Text =
                ShowPhy.Text = ShowChe.Text = ShowAvg.Text = ShowRank.Text = null;
            
            if (SortBox.Text == "Sort By ID (Default)")
            {
                ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                    return sv1.ID.CompareTo(sv2.ID);
                });
            }

            if (SortBox.Text == "Sort By Name")
            {
                ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                    return sv1.Name.CompareTo(sv2.Name);
                });
            }

            if (SortBox.Text == "Sort By GPA")
            {
                ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                    return sv1.Avg.CompareTo(sv2.Avg);
                });
            }

            foreach (SinhVien sv in ListSinhVien)
            {
                ShowID.Text = ShowID.Text + sv.ID.ToString() + Environment.NewLine;
                ShowAge.Text = ShowAge.Text + sv.Age.ToString() + Environment.NewLine;
                ShowName.Text = ShowName.Text + sv.Name.ToString() + Environment.NewLine;
                ShowGender.Text = ShowGender.Text + sv.Gender.ToString() + Environment.NewLine;
                ShowMath.Text = ShowMath.Text + sv.Math.ToString() + Environment.NewLine;
                ShowPhy.Text = ShowPhy.Text + sv.Phy.ToString() + Environment.NewLine;
                ShowChe.Text = ShowChe.Text + sv.Che.ToString() + Environment.NewLine;
                ShowAvg.Text = ShowAvg.Text + sv.Avg.ToString() + Environment.NewLine;
                ShowRank.Text = ShowRank.Text + sv.Rank.ToString() + Environment.NewLine;
            }
        }

        private void UpdateSV_Click(object sender, EventArgs e)
        {
            ShowID.Text = ShowName.Text = ShowAge.Text = ShowGender.Text = ShowMath.Text =
                ShowPhy.Text = ShowChe.Text = ShowAvg.Text = ShowRank.Text = null;
            

            if (FunctionBox.Text == "Update By ID")
            {
                SinhVien sv = ListSinhVien.Find(ListSinhVien => ListSinhVien.ID == int.Parse(IDBox.Text));
                if (sv == null) UpdateIDlbl.Text = "NOT FOUND STUDENT";
                else
                {
                    UpdateIDlbl.Text = "Update Complete";
                    if (NameBox.Text != "" && NameBox.MaxLength > 0)
                    {
                        sv.Name = NameBox.Text;
                    }

                    if (GenderBox.Text != "" && GenderBox.MaxLength > 0)
                    {
                        sv.Gender = GenderBox.Text;
                    }

                    if (AgeBox.Text != "" && AgeBox.MaxLength > 0)
                    {
                        sv.Age = int.Parse(AgeBox.Text);
                    }

                    if (MathBox.Text != "" && MathBox.MaxLength > 0)
                    {
                        sv.Math = double.Parse(MathBox.Text);
                    }

                    if (PhyBox.Text != "" && PhyBox.MaxLength > 0)
                    {
                        sv.Phy = double.Parse(PhyBox.Text);
                    }

                    if (CheBox.Text != "" && CheBox.MaxLength > 0)
                    {
                        sv.Che = double.Parse(CheBox.Text);
                    }
                    sv.Avg = Math.Round((sv.Math + sv.Phy + sv.Che) / 3, 2, MidpointRounding.AwayFromZero);
                    if (sv.Avg >= 8) { sv.Rank = "Good"; }
                    else if (sv.Avg >= 6.5) { sv.Rank = "Medium"; }
                    else if (sv.Avg >= 5) { sv.Rank = "Avg"; }
                    else { sv.Rank = "Bad"; }

                    foreach (SinhVien a in ListSinhVien)
                    {
                        ShowID.Text = ShowID.Text + a.ID.ToString() + Environment.NewLine;
                        ShowAge.Text = ShowAge.Text + a.Age.ToString() + Environment.NewLine;
                        ShowName.Text = ShowName.Text + a.Name.ToString() + Environment.NewLine;
                        ShowGender.Text = ShowGender.Text + a.Gender.ToString() + Environment.NewLine;
                        ShowMath.Text = ShowMath.Text + a.Math.ToString() + Environment.NewLine;
                        ShowPhy.Text = ShowPhy.Text + a.Phy.ToString() + Environment.NewLine;
                        ShowChe.Text = ShowChe.Text + a.Che.ToString() + Environment.NewLine;
                        ShowAvg.Text = ShowAvg.Text + a.Avg.ToString() + Environment.NewLine;
                        ShowRank.Text = ShowRank.Text + a.Rank.ToString() + Environment.NewLine;
                    }

                }
            }

            if (FunctionBox.Text == "Delete By ID")
            {
                SinhVien sv = ListSinhVien.Find(ListSinhVien => ListSinhVien.ID == int.Parse(IDBox.Text));
                if (sv != null)
                {
                    ListSinhVien.Remove(sv);
                    UpdateIDlbl.Text = "Delete Successfully";
                }
                else
                {
                    UpdateIDlbl.Text = "NOT FOUND STUDENT";
                }

                foreach (SinhVien a in ListSinhVien)
                {
                    ShowID.Text = ShowID.Text + a.ID.ToString() + Environment.NewLine;
                    ShowAge.Text = ShowAge.Text + a.Age.ToString() + Environment.NewLine;
                    ShowName.Text = ShowName.Text + a.Name.ToString() + Environment.NewLine;
                    ShowGender.Text = ShowGender.Text + a.Gender.ToString() + Environment.NewLine;
                    ShowMath.Text = ShowMath.Text + a.Math.ToString() + Environment.NewLine;
                    ShowPhy.Text = ShowPhy.Text + a.Phy.ToString() + Environment.NewLine;
                    ShowChe.Text = ShowChe.Text + a.Che.ToString() + Environment.NewLine;
                    ShowAvg.Text = ShowAvg.Text + a.Avg.ToString() + Environment.NewLine;
                    ShowRank.Text = ShowRank.Text + a.Rank.ToString() + Environment.NewLine;
                }

            }

            if (FunctionBox.Text == "Find By Name")
            {
                bool set = false;
                List<SinhVien> searchResult = new List<SinhVien>();
                if (ListSinhVien != null && ListSinhVien.Count > 0)
                {
                    foreach (SinhVien sv in ListSinhVien)
                    {
                        if (sv.Name.ToUpper().Contains(IDBox.Text.ToUpper()))
                        {
                            searchResult.Add(sv);
                            set = true;
                        }
                    }
                }

                if (set == true)
                {
                    UpdateIDlbl.Text = "FOUND";
                    foreach (SinhVien a in searchResult)
                    {
                        ShowID.Text = ShowID.Text + a.ID.ToString() + Environment.NewLine;
                        ShowAge.Text = ShowAge.Text + a.Age.ToString() + Environment.NewLine;
                        ShowName.Text = ShowName.Text + a.Name.ToString() + Environment.NewLine;
                        ShowGender.Text = ShowGender.Text + a.Gender.ToString() + Environment.NewLine;
                        ShowMath.Text = ShowMath.Text + a.Math.ToString() + Environment.NewLine;
                        ShowPhy.Text = ShowPhy.Text + a.Phy.ToString() + Environment.NewLine;
                        ShowChe.Text = ShowChe.Text + a.Che.ToString() + Environment.NewLine;
                        ShowAvg.Text = ShowAvg.Text + a.Avg.ToString() + Environment.NewLine;
                        ShowRank.Text = ShowRank.Text + a.Rank.ToString() + Environment.NewLine;
                    }
                }
                else
                {
                    UpdateIDlbl.Text = "NOT FOUND STUDENT";
                }
            }

            


        }

        private void ShowRank_Click(object sender, EventArgs e)
        {

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ShowID.Text = ShowName.Text = ShowAge.Text = ShowGender.Text = ShowMath.Text =
                ShowPhy.Text = ShowChe.Text = ShowAvg.Text = ShowRank.Text = null;
            NameBox.Text = AgeBox.Text = GenderBox.Text = MathBox.Text 
                = CheBox.Text = PhyBox.Text = null;
            if (FunctionBox.Text == "Update By ID")
            { UpdateIDlbl.Text = "(Please Reset first) Enter ID in the following field and Infos You Want to Change In The Fields Above "; }
            if (FunctionBox.Text == "Find By Name")
            { UpdateIDlbl.Text = "Enter Name you want to Find in the following field"; }
            if (FunctionBox.Text == "Delete By ID")
            { UpdateIDlbl.Text = "Enter ID you want to delete in the following field"; }

        }

        private void FindOp_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionBox.Text == "Update By ID") 
            { UpdateIDlbl.Text = "(Please Reset first) Enter ID in the following field and Infos You Want to Change In The Fields Above "; }
            if (FunctionBox.Text == "Find By Name")
            { UpdateIDlbl.Text = "Enter Name you want to Find in the following field"; }
            if (FunctionBox.Text == "Delete By ID")
            { UpdateIDlbl.Text = "Enter ID you want to delete in the following field"; }
        }
    }
}
