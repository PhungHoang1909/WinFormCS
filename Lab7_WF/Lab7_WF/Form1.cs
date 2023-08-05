using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_WF
{
    public partial class Form1 : Form
    {

        private int currentID = 1;
        private List<SinhVien> danhSachHocSinh = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateColumns();
        }

        public void updateColumns()
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Sex";
            dataGridView1.Columns[3].Name = "Age";
            dataGridView1.Columns[4].Name = "Math";
            dataGridView1.Columns[5].Name = "Physics";
            dataGridView1.Columns[6].Name = "Chemistry";
            dataGridView1.Columns[7].Name = "Average";
            dataGridView1.Columns[8].Name = "Academic";

            // for equal width
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void txtBox_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBox_Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBox_Physics_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBox_Chemistry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Tinh Diem trung binh:
            string diemToan = txtBox_Math.Text;
            string diemLy = txtBox_Physics.Text;
            string diemHoa = txtBox_Chemistry.Text;

            double diemTB =
                (Convert.ToDouble(diemToan) + Convert.ToDouble(diemLy) + Convert.ToDouble(diemHoa)) / 3;
            diemTB = Math.Round(diemTB, 2);

            string academic = "";
            if (diemTB >= 8)
            {
                academic = "Excellent";
            }
            else if (diemTB >= 6.5)
            {
                academic = "Good";
            }
            else if (diemTB >= 5)
            {
                academic = "Average";
            }
            else
            {
                academic = "Below avg";
            }

            dataGridView1.Rows.Add(currentID, txtBox_Name.Text, cBox_Sex.Text,
                txtBox_Age.Text, txtBox_Math.Text, txtBox_Physics.Text, txtBox_Chemistry.Text,
                diemTB, academic);

            danhSachHocSinh.Add(new SinhVien
            {
                ID = currentID,
                Name = txtBox_Name.Text,
                Sex = cBox_Sex.Text,
                Age = Convert.ToInt32(txtBox_Age.Text),
                DiemToan = Convert.ToDouble(txtBox_Math.Text),
                DiemLy = Convert.ToDouble(txtBox_Physics.Text),
                DiemHoa = Convert.ToDouble(txtBox_Chemistry.Text)
            });

            currentID++;

            txtBox_Name.Clear();
            txtBox_Age.Clear();
            txtBox_Math.Clear();
            txtBox_Physics.Clear();
            txtBox_Chemistry.Clear();
        }

        private void btn_SearchName_Click(object sender, EventArgs e)
        {
            string searchName = txtBox_SearchName.Text;

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().ToLower() == searchName.ToLower())
                {
                    // Tên học sinh được tìm thấy
                    found = true;

                    // Chọn hàng chứa thông tin học sinh cần tìm kiếm
                    row.Selected = true;

                    // Cuộn đến hàng đã chọn để người dùng có thể thấy nó
                    dataGridView1.CurrentCell = row.Cells[0];

                    break;
                }
            }

            // Nếu tên học sinh không tồn tại, hiển thị thông báo
            if (!found)
            {
                MessageBox.Show("Student not found");
            }

            txtBox_SearchName.Clear();
        }

        private void btn_SearchID_Click(object sender, EventArgs e)
        {
            string searchID = txtBox_SearchID.Text;

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == searchID)
                {
                    // ID được tìm thấy
                    found = true;

                    // Chọn hàng chứa thông tin học sinh cần tìm kiếm
                    row.Selected = true;

                    // Cuộn đến hàng đã chọn để người dùng có thể thấy nó
                    dataGridView1.CurrentCell = row.Cells[0];

                    break;
                }
            }

            // Nếu ID không tồn tại, hiển thị thông báo
            if (!found)
            {
                MessageBox.Show("ID not found");
            }

            txtBox_SearchID.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SortGrade_Click(object sender, EventArgs e)
        {

            dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Descending);
        }

        private void btn_SortID_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void btn_SortName_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

        }

        private void btn_DeleteID_Click(object sender, EventArgs e)
        {
            string searchID = txtBox_SearchID.Text;
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == searchID)
                {
                    // ID được tìm thấy
                    found = true;

                    // Chọn hàng chứa thông tin học sinh cần tìm kiếm
                    row.Selected = true;

                    // Cuộn đến hàng đã chọn để người dùng có thể thấy nó
                    dataGridView1.CurrentCell = row.Cells[0];

                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show($"Student with ID {searchID} has been deleted.");
                }
            }

            // Nếu ID không tồn tại, hiển thị thông báo
            if (!found)
            {
                MessageBox.Show("ID not found");
            }

            txtBox_SearchID.Clear();
        }

        private void btn_UpdateID_Click(object sender, EventArgs e)
        {
            string searchID = txtBox_SearchID.Text;
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == searchID)
                {
                    // ID is found
                    found = true;

                    // Update the student's information
                    row.Cells["Name"].Value = txtBox_Name.Text;
                    row.Cells["Sex"].Value = cBox_Sex.Text;
                    row.Cells["Age"].Value = txtBox_Age.Text;
                    row.Cells["Math"].Value = txtBox_Math.Text;
                    row.Cells["Physics"].Value = txtBox_Physics.Text;
                    row.Cells["Chemistry"].Value = txtBox_Chemistry.Text;

                    // Calculate and update the average and academic columns
                    double diemToan = Convert.ToDouble(txtBox_Math.Text);
                    double diemLy = Convert.ToDouble(txtBox_Physics.Text);
                    double diemHoa = Convert.ToDouble(txtBox_Chemistry.Text);
                    double diemTB = (diemToan + diemLy + diemHoa) / 3;
                    diemTB = Math.Round(diemTB, 2);

                    string academic = "";
                    if (diemTB >= 8)
                    {
                        academic = "Excellent";
                    }
                    else if (diemTB >= 6.5)
                    {
                        academic = "Good";
                    }
                    else if (diemTB >= 5)
                    {
                        academic = "Average";
                    }
                    else
                    {
                        academic = "Below avg";
                    }

                    row.Cells["Average"].Value = diemTB;
                    row.Cells["Academic"].Value = academic;

                    MessageBox.Show($"Student with ID {searchID} has been updated.");
                    break;
                }
            }

            // If ID is not found, show a message box
            if (!found)
            {
                MessageBox.Show("ID not found");
            }

            // Clear the search ID textbox
            txtBox_SearchID.Clear();
        }
    }
}
