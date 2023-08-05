namespace Lab7_WF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Math = new System.Windows.Forms.Label();
            this.lbl_Physics = new System.Windows.Forms.Label();
            this.lbl_Chemistry = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.txtBox_Math = new System.Windows.Forms.TextBox();
            this.txtBox_Physics = new System.Windows.Forms.TextBox();
            this.txtBox_Chemistry = new System.Windows.Forms.TextBox();
            this.cBox_Sex = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_SearchName = new System.Windows.Forms.Label();
            this.btn_SearchName = new System.Windows.Forms.Button();
            this.txtBox_SearchName = new System.Windows.Forms.TextBox();
            this.lbl_SearchID = new System.Windows.Forms.Label();
            this.btn_SearchID = new System.Windows.Forms.Button();
            this.txtBox_SearchID = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_SortGrade = new System.Windows.Forms.Button();
            this.lbl_SortGrade = new System.Windows.Forms.Label();
            this.lbl_SortID = new System.Windows.Forms.Label();
            this.btn_SortID = new System.Windows.Forms.Button();
            this.lbl_SortName = new System.Windows.Forms.Label();
            this.btn_SortName = new System.Windows.Forms.Button();
            this.btn_DeleteID = new System.Windows.Forms.Button();
            this.btn_UpdateID = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(250, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(5, 41);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(58, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sex.Location = new System.Drawing.Point(5, 79);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(42, 20);
            this.lbl_Sex.TabIndex = 2;
            this.lbl_Sex.Text = "Sex:";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(5, 114);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(43, 20);
            this.lbl_Age.TabIndex = 3;
            this.lbl_Age.Text = "Age:";
            // 
            // lbl_Math
            // 
            this.lbl_Math.AutoSize = true;
            this.lbl_Math.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Math.Location = new System.Drawing.Point(5, 147);
            this.lbl_Math.Name = "lbl_Math";
            this.lbl_Math.Size = new System.Drawing.Size(51, 20);
            this.lbl_Math.TabIndex = 4;
            this.lbl_Math.Text = "Math:";
            // 
            // lbl_Physics
            // 
            this.lbl_Physics.AutoSize = true;
            this.lbl_Physics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Physics.Location = new System.Drawing.Point(5, 180);
            this.lbl_Physics.Name = "lbl_Physics";
            this.lbl_Physics.Size = new System.Drawing.Size(73, 20);
            this.lbl_Physics.TabIndex = 5;
            this.lbl_Physics.Text = "Physics:";
            // 
            // lbl_Chemistry
            // 
            this.lbl_Chemistry.AutoSize = true;
            this.lbl_Chemistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chemistry.Location = new System.Drawing.Point(5, 213);
            this.lbl_Chemistry.Name = "lbl_Chemistry";
            this.lbl_Chemistry.Size = new System.Drawing.Size(90, 20);
            this.lbl_Chemistry.TabIndex = 6;
            this.lbl_Chemistry.Text = "Chemistry:";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(135, 41);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Name.TabIndex = 7;
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Location = new System.Drawing.Point(135, 114);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.ShortcutsEnabled = false;
            this.txtBox_Age.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Age.TabIndex = 9;
            this.txtBox_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Age_KeyPress);
            // 
            // txtBox_Math
            // 
            this.txtBox_Math.Location = new System.Drawing.Point(135, 147);
            this.txtBox_Math.Name = "txtBox_Math";
            this.txtBox_Math.ShortcutsEnabled = false;
            this.txtBox_Math.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Math.TabIndex = 10;
            this.txtBox_Math.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Math_KeyPress);
            // 
            // txtBox_Physics
            // 
            this.txtBox_Physics.Location = new System.Drawing.Point(135, 180);
            this.txtBox_Physics.Name = "txtBox_Physics";
            this.txtBox_Physics.ShortcutsEnabled = false;
            this.txtBox_Physics.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Physics.TabIndex = 11;
            this.txtBox_Physics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Physics_KeyPress);
            // 
            // txtBox_Chemistry
            // 
            this.txtBox_Chemistry.Location = new System.Drawing.Point(135, 213);
            this.txtBox_Chemistry.Name = "txtBox_Chemistry";
            this.txtBox_Chemistry.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Chemistry.TabIndex = 12;
            this.txtBox_Chemistry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Chemistry_KeyPress);
            // 
            // cBox_Sex
            // 
            this.cBox_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Sex.FormattingEnabled = true;
            this.cBox_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cBox_Sex.Location = new System.Drawing.Point(135, 73);
            this.cBox_Sex.Name = "cBox_Sex";
            this.cBox_Sex.Size = new System.Drawing.Size(100, 24);
            this.cBox_Sex.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(68, 281);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(126, 46);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_SearchName
            // 
            this.lbl_SearchName.AutoSize = true;
            this.lbl_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchName.Location = new System.Drawing.Point(5, 436);
            this.lbl_SearchName.Name = "lbl_SearchName";
            this.lbl_SearchName.Size = new System.Drawing.Size(102, 20);
            this.lbl_SearchName.TabIndex = 14;
            this.lbl_SearchName.Text = "Tên cần tìm:";
            // 
            // btn_SearchName
            // 
            this.btn_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchName.Location = new System.Drawing.Point(236, 429);
            this.btn_SearchName.Name = "btn_SearchName";
            this.btn_SearchName.Size = new System.Drawing.Size(93, 31);
            this.btn_SearchName.TabIndex = 15;
            this.btn_SearchName.Text = "Search";
            this.btn_SearchName.UseVisualStyleBackColor = true;
            this.btn_SearchName.Click += new System.EventHandler(this.btn_SearchName_Click);
            // 
            // txtBox_SearchName
            // 
            this.txtBox_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SearchName.Location = new System.Drawing.Point(120, 429);
            this.txtBox_SearchName.Name = "txtBox_SearchName";
            this.txtBox_SearchName.Size = new System.Drawing.Size(100, 27);
            this.txtBox_SearchName.TabIndex = 16;
            // 
            // lbl_SearchID
            // 
            this.lbl_SearchID.AutoSize = true;
            this.lbl_SearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchID.Location = new System.Drawing.Point(5, 391);
            this.lbl_SearchID.Name = "lbl_SearchID";
            this.lbl_SearchID.Size = new System.Drawing.Size(31, 20);
            this.lbl_SearchID.TabIndex = 17;
            this.lbl_SearchID.Text = "ID:";
            // 
            // btn_SearchID
            // 
            this.btn_SearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchID.Location = new System.Drawing.Point(236, 382);
            this.btn_SearchID.Name = "btn_SearchID";
            this.btn_SearchID.Size = new System.Drawing.Size(93, 31);
            this.btn_SearchID.TabIndex = 18;
            this.btn_SearchID.Text = "Search";
            this.btn_SearchID.UseVisualStyleBackColor = true;
            this.btn_SearchID.Click += new System.EventHandler(this.btn_SearchID_Click);
            // 
            // txtBox_SearchID
            // 
            this.txtBox_SearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SearchID.Location = new System.Drawing.Point(120, 384);
            this.txtBox_SearchID.Name = "txtBox_SearchID";
            this.txtBox_SearchID.Size = new System.Drawing.Size(100, 27);
            this.txtBox_SearchID.TabIndex = 19;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(913, 380);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(115, 61);
            this.btn_Exit.TabIndex = 20;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_SortGrade
            // 
            this.btn_SortGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortGrade.Location = new System.Drawing.Point(747, 395);
            this.btn_SortGrade.Name = "btn_SortGrade";
            this.btn_SortGrade.Size = new System.Drawing.Size(93, 31);
            this.btn_SortGrade.TabIndex = 21;
            this.btn_SortGrade.Text = "Sort";
            this.btn_SortGrade.UseVisualStyleBackColor = true;
            this.btn_SortGrade.Click += new System.EventHandler(this.btn_SortGrade_Click);
            // 
            // lbl_SortGrade
            // 
            this.lbl_SortGrade.AutoSize = true;
            this.lbl_SortGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SortGrade.Location = new System.Drawing.Point(547, 400);
            this.lbl_SortGrade.Name = "lbl_SortGrade";
            this.lbl_SortGrade.Size = new System.Drawing.Size(179, 20);
            this.lbl_SortGrade.TabIndex = 22;
            this.lbl_SortGrade.Text = "Xếp điểmTB giảm dần:";
            // 
            // lbl_SortID
            // 
            this.lbl_SortID.AutoSize = true;
            this.lbl_SortID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SortID.Location = new System.Drawing.Point(547, 449);
            this.lbl_SortID.Name = "lbl_SortID";
            this.lbl_SortID.Size = new System.Drawing.Size(134, 20);
            this.lbl_SortID.TabIndex = 23;
            this.lbl_SortID.Text = "Xếp ID tăng dần:";
            // 
            // btn_SortID
            // 
            this.btn_SortID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortID.Location = new System.Drawing.Point(747, 444);
            this.btn_SortID.Name = "btn_SortID";
            this.btn_SortID.Size = new System.Drawing.Size(93, 31);
            this.btn_SortID.TabIndex = 24;
            this.btn_SortID.Text = "Sort";
            this.btn_SortID.UseVisualStyleBackColor = true;
            this.btn_SortID.Click += new System.EventHandler(this.btn_SortID_Click);
            // 
            // lbl_SortName
            // 
            this.lbl_SortName.AutoSize = true;
            this.lbl_SortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SortName.Location = new System.Drawing.Point(547, 354);
            this.lbl_SortName.Name = "lbl_SortName";
            this.lbl_SortName.Size = new System.Drawing.Size(102, 20);
            this.lbl_SortName.TabIndex = 25;
            this.lbl_SortName.Text = "Xếp tên A-Z:";
            // 
            // btn_SortName
            // 
            this.btn_SortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortName.Location = new System.Drawing.Point(747, 343);
            this.btn_SortName.Name = "btn_SortName";
            this.btn_SortName.Size = new System.Drawing.Size(93, 31);
            this.btn_SortName.TabIndex = 26;
            this.btn_SortName.Text = "Sort";
            this.btn_SortName.UseVisualStyleBackColor = true;
            this.btn_SortName.Click += new System.EventHandler(this.btn_SortName_Click);
            // 
            // btn_DeleteID
            // 
            this.btn_DeleteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteID.Location = new System.Drawing.Point(335, 382);
            this.btn_DeleteID.Name = "btn_DeleteID";
            this.btn_DeleteID.Size = new System.Drawing.Size(93, 31);
            this.btn_DeleteID.TabIndex = 27;
            this.btn_DeleteID.Text = "Delete";
            this.btn_DeleteID.UseVisualStyleBackColor = true;
            this.btn_DeleteID.Click += new System.EventHandler(this.btn_DeleteID_Click);
            // 
            // btn_UpdateID
            // 
            this.btn_UpdateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateID.Location = new System.Drawing.Point(434, 382);
            this.btn_UpdateID.Name = "btn_UpdateID";
            this.btn_UpdateID.Size = new System.Drawing.Size(93, 31);
            this.btn_UpdateID.TabIndex = 28;
            this.btn_UpdateID.Text = "Update";
            this.btn_UpdateID.UseVisualStyleBackColor = true;
            this.btn_UpdateID.Click += new System.EventHandler(this.btn_UpdateID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 501);
            this.Controls.Add(this.btn_UpdateID);
            this.Controls.Add(this.btn_DeleteID);
            this.Controls.Add(this.btn_SortName);
            this.Controls.Add(this.lbl_SortName);
            this.Controls.Add(this.btn_SortID);
            this.Controls.Add(this.lbl_SortID);
            this.Controls.Add(this.lbl_SortGrade);
            this.Controls.Add(this.btn_SortGrade);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txtBox_SearchID);
            this.Controls.Add(this.btn_SearchID);
            this.Controls.Add(this.lbl_SearchID);
            this.Controls.Add(this.txtBox_SearchName);
            this.Controls.Add(this.btn_SearchName);
            this.Controls.Add(this.lbl_SearchName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cBox_Sex);
            this.Controls.Add(this.txtBox_Chemistry);
            this.Controls.Add(this.txtBox_Physics);
            this.Controls.Add(this.txtBox_Math);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lbl_Chemistry);
            this.Controls.Add(this.lbl_Physics);
            this.Controls.Add(this.lbl_Math);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Sex);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Math;
        private System.Windows.Forms.Label lbl_Physics;
        private System.Windows.Forms.Label lbl_Chemistry;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.TextBox txtBox_Math;
        private System.Windows.Forms.TextBox txtBox_Physics;
        private System.Windows.Forms.TextBox txtBox_Chemistry;
        private System.Windows.Forms.ComboBox cBox_Sex;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_SearchName;
        private System.Windows.Forms.Button btn_SearchName;
        private System.Windows.Forms.TextBox txtBox_SearchName;
        private System.Windows.Forms.Label lbl_SearchID;
        private System.Windows.Forms.Button btn_SearchID;
        private System.Windows.Forms.TextBox txtBox_SearchID;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SortGrade;
        private System.Windows.Forms.Label lbl_SortGrade;
        private System.Windows.Forms.Label lbl_SortID;
        private System.Windows.Forms.Button btn_SortID;
        private System.Windows.Forms.Label lbl_SortName;
        private System.Windows.Forms.Button btn_SortName;
        private System.Windows.Forms.Button btn_DeleteID;
        private System.Windows.Forms.Button btn_UpdateID;
    }
}

