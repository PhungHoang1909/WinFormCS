namespace _7_20_2023
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.MathBox = new System.Windows.Forms.TextBox();
            this.PhyBox = new System.Windows.Forms.TextBox();
            this.CheBox = new System.Windows.Forms.TextBox();
            this.AddSV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.UpdateSV = new System.Windows.Forms.Button();
            this.FindOp = new System.Windows.Forms.Label();
            this.ShowSV = new System.Windows.Forms.Button();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.ShowID = new System.Windows.Forms.Label();
            this.ShowName = new System.Windows.Forms.Label();
            this.ShowGender = new System.Windows.Forms.Label();
            this.ShowAge = new System.Windows.Forms.Label();
            this.ShowMath = new System.Windows.Forms.Label();
            this.ShowPhy = new System.Windows.Forms.Label();
            this.ShowChe = new System.Windows.Forms.Label();
            this.ShowAvg = new System.Windows.Forms.Label();
            this.ShowRank = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.UpdateIDlbl = new System.Windows.Forms.Label();
            this.FunctionBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Math";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Physics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chemistry";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(178, 40);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(206, 22);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // GenderBox
            // 
            this.GenderBox.Location = new System.Drawing.Point(178, 98);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(206, 22);
            this.GenderBox.TabIndex = 7;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(178, 152);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(206, 22);
            this.AgeBox.TabIndex = 8;
            // 
            // MathBox
            // 
            this.MathBox.Location = new System.Drawing.Point(178, 200);
            this.MathBox.Name = "MathBox";
            this.MathBox.Size = new System.Drawing.Size(206, 22);
            this.MathBox.TabIndex = 9;
            // 
            // PhyBox
            // 
            this.PhyBox.Location = new System.Drawing.Point(178, 259);
            this.PhyBox.Name = "PhyBox";
            this.PhyBox.Size = new System.Drawing.Size(206, 22);
            this.PhyBox.TabIndex = 10;
            // 
            // CheBox
            // 
            this.CheBox.Location = new System.Drawing.Point(178, 319);
            this.CheBox.Name = "CheBox";
            this.CheBox.Size = new System.Drawing.Size(206, 22);
            this.CheBox.TabIndex = 11;
            // 
            // AddSV
            // 
            this.AddSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSV.Location = new System.Drawing.Point(35, 449);
            this.AddSV.Name = "AddSV";
            this.AddSV.Size = new System.Drawing.Size(88, 54);
            this.AddSV.TabIndex = 12;
            this.AddSV.Text = "Add";
            this.AddSV.UseVisualStyleBackColor = true;
            this.AddSV.Click += new System.EventHandler(this.AddSV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(753, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(884, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 27);
            this.label10.TabIndex = 16;
            this.label10.Text = "Age";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(988, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 27);
            this.label11.TabIndex = 17;
            this.label11.Text = "Math";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1091, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 27);
            this.label12.TabIndex = 18;
            this.label12.Text = "Physics";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1206, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 27);
            this.label13.TabIndex = 19;
            this.label13.Text = "Chemistry";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1345, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 27);
            this.label14.TabIndex = 20;
            this.label14.Text = "Average";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1458, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 27);
            this.label15.TabIndex = 21;
            this.label15.Text = "Rank";
            // 
            // UpdateSV
            // 
            this.UpdateSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSV.Location = new System.Drawing.Point(33, 579);
            this.UpdateSV.Name = "UpdateSV";
            this.UpdateSV.Size = new System.Drawing.Size(120, 37);
            this.UpdateSV.TabIndex = 22;
            this.UpdateSV.Text = "Apply";
            this.UpdateSV.UseVisualStyleBackColor = true;
            this.UpdateSV.Click += new System.EventHandler(this.UpdateSV_Click);
            // 
            // FindOp
            // 
            this.FindOp.AutoSize = true;
            this.FindOp.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindOp.Location = new System.Drawing.Point(29, 386);
            this.FindOp.Name = "FindOp";
            this.FindOp.Size = new System.Drawing.Size(119, 30);
            this.FindOp.TabIndex = 23;
            this.FindOp.Text = "Sort Type";
            this.FindOp.Click += new System.EventHandler(this.FindOp_Click);
            // 
            // ShowSV
            // 
            this.ShowSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSV.Location = new System.Drawing.Point(163, 449);
            this.ShowSV.Name = "ShowSV";
            this.ShowSV.Size = new System.Drawing.Size(89, 54);
            this.ShowSV.TabIndex = 25;
            this.ShowSV.Text = "Show";
            this.ShowSV.UseVisualStyleBackColor = true;
            this.ShowSV.Click += new System.EventHandler(this.ShowSV_Click);
            // 
            // SortBox
            // 
            this.SortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Items.AddRange(new object[] {
            "Sort By ID (Default)",
            "Sort By GPA",
            "Sort By Name"});
            this.SortBox.Location = new System.Drawing.Point(178, 386);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(206, 33);
            this.SortBox.TabIndex = 26;
            this.SortBox.Text = "Sort By ID (Default)";
            // 
            // ShowID
            // 
            this.ShowID.AutoSize = true;
            this.ShowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowID.Location = new System.Drawing.Point(481, 76);
            this.ShowID.Name = "ShowID";
            this.ShowID.Size = new System.Drawing.Size(12, 25);
            this.ShowID.TabIndex = 27;
            this.ShowID.Text = "\r\n";
            // 
            // ShowName
            // 
            this.ShowName.AutoSize = true;
            this.ShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowName.Location = new System.Drawing.Point(538, 76);
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(12, 25);
            this.ShowName.TabIndex = 28;
            this.ShowName.Text = "\r\n";
            // 
            // ShowGender
            // 
            this.ShowGender.AutoSize = true;
            this.ShowGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGender.Location = new System.Drawing.Point(755, 76);
            this.ShowGender.Name = "ShowGender";
            this.ShowGender.Size = new System.Drawing.Size(12, 25);
            this.ShowGender.TabIndex = 29;
            this.ShowGender.Text = "\r\n";
            // 
            // ShowAge
            // 
            this.ShowAge.AutoSize = true;
            this.ShowAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAge.Location = new System.Drawing.Point(886, 76);
            this.ShowAge.Name = "ShowAge";
            this.ShowAge.Size = new System.Drawing.Size(12, 25);
            this.ShowAge.TabIndex = 30;
            this.ShowAge.Text = "\r\n";
            // 
            // ShowMath
            // 
            this.ShowMath.AutoSize = true;
            this.ShowMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMath.Location = new System.Drawing.Point(990, 76);
            this.ShowMath.Name = "ShowMath";
            this.ShowMath.Size = new System.Drawing.Size(12, 25);
            this.ShowMath.TabIndex = 31;
            this.ShowMath.Text = "\r\n";
            // 
            // ShowPhy
            // 
            this.ShowPhy.AutoSize = true;
            this.ShowPhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPhy.Location = new System.Drawing.Point(1093, 76);
            this.ShowPhy.Name = "ShowPhy";
            this.ShowPhy.Size = new System.Drawing.Size(12, 25);
            this.ShowPhy.TabIndex = 32;
            this.ShowPhy.Text = "\r\n";
            // 
            // ShowChe
            // 
            this.ShowChe.AutoSize = true;
            this.ShowChe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowChe.Location = new System.Drawing.Point(1208, 76);
            this.ShowChe.Name = "ShowChe";
            this.ShowChe.Size = new System.Drawing.Size(12, 25);
            this.ShowChe.TabIndex = 33;
            this.ShowChe.Text = "\r\n";
            // 
            // ShowAvg
            // 
            this.ShowAvg.AutoSize = true;
            this.ShowAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAvg.Location = new System.Drawing.Point(1347, 76);
            this.ShowAvg.Name = "ShowAvg";
            this.ShowAvg.Size = new System.Drawing.Size(12, 25);
            this.ShowAvg.TabIndex = 34;
            this.ShowAvg.Text = "\r\n";
            // 
            // ShowRank
            // 
            this.ShowRank.AutoSize = true;
            this.ShowRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRank.Location = new System.Drawing.Point(1458, 76);
            this.ShowRank.Name = "ShowRank";
            this.ShowRank.Size = new System.Drawing.Size(12, 25);
            this.ShowRank.TabIndex = 35;
            this.ShowRank.Text = "\r\n";
            this.ShowRank.Click += new System.EventHandler(this.ShowRank_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(295, 449);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(89, 54);
            this.ResetButton.TabIndex = 36;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(217, 534);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(178, 30);
            this.IDBox.TabIndex = 37;
            // 
            // UpdateIDlbl
            // 
            this.UpdateIDlbl.AutoSize = true;
            this.UpdateIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateIDlbl.Location = new System.Drawing.Point(173, 591);
            this.UpdateIDlbl.Name = "UpdateIDlbl";
            this.UpdateIDlbl.Size = new System.Drawing.Size(0, 25);
            this.UpdateIDlbl.TabIndex = 39;
            // 
            // FunctionBox
            // 
            this.FunctionBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionBox.FormattingEnabled = true;
            this.FunctionBox.Items.AddRange(new object[] {
            "Update By ID",
            "Delete By ID",
            "Find By Name"});
            this.FunctionBox.Location = new System.Drawing.Point(34, 532);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(177, 30);
            this.FunctionBox.TabIndex = 40;
            this.FunctionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 645);
            this.Controls.Add(this.FunctionBox);
            this.Controls.Add(this.UpdateIDlbl);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ShowRank);
            this.Controls.Add(this.ShowAvg);
            this.Controls.Add(this.ShowChe);
            this.Controls.Add(this.ShowPhy);
            this.Controls.Add(this.ShowMath);
            this.Controls.Add(this.ShowAge);
            this.Controls.Add(this.ShowGender);
            this.Controls.Add(this.ShowName);
            this.Controls.Add(this.ShowID);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.ShowSV);
            this.Controls.Add(this.FindOp);
            this.Controls.Add(this.UpdateSV);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddSV);
            this.Controls.Add(this.CheBox);
            this.Controls.Add(this.PhyBox);
            this.Controls.Add(this.MathBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox GenderBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox MathBox;
        private System.Windows.Forms.TextBox PhyBox;
        private System.Windows.Forms.TextBox CheBox;
        private System.Windows.Forms.Button AddSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button UpdateSV;
        private System.Windows.Forms.Label FindOp;
        private System.Windows.Forms.Button ShowSV;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.Label ShowID;
        private System.Windows.Forms.Label ShowName;
        private System.Windows.Forms.Label ShowGender;
        private System.Windows.Forms.Label ShowAge;
        private System.Windows.Forms.Label ShowMath;
        private System.Windows.Forms.Label ShowPhy;
        private System.Windows.Forms.Label ShowChe;
        private System.Windows.Forms.Label ShowAvg;
        private System.Windows.Forms.Label ShowRank;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label UpdateIDlbl;
        private System.Windows.Forms.ComboBox FunctionBox;
    }
}

