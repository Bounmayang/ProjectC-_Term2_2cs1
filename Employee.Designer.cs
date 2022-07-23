namespace WindowsFormsApp1
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpGenCb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpEduCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpDob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpPosCb = new System.Windows.Forms.ComboBox();
            this.EmpPhoneTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpAddTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIDTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "ຈັດການຂໍ້ມູນພະນັກງານ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpGenCb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.EmpEduCb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpDob);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpPosCb);
            this.panel1.Controls.Add(this.EmpPhoneTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpAddTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIDTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel1.Location = new System.Drawing.Point(-4, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 638);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmpDGV
            // 
            this.EmpDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmpDGV.Location = new System.Drawing.Point(486, 12);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersWidth = 62;
            this.EmpDGV.RowTemplate.Height = 28;
            this.EmpDGV.Size = new System.Drawing.Size(775, 579);
            this.EmpDGV.TabIndex = 25;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Saysettha OT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(243, 540);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 47);
            this.button4.TabIndex = 24;
            this.button4.Text = "ກັບຄືນ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Saysettha OT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(243, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 47);
            this.button3.TabIndex = 23;
            this.button3.Text = "ລືບ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Saysettha OT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(60, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "ເພີ່ມ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(257, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "ເພດ";
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpGenCb.FormattingEnabled = true;
            this.EmpGenCb.Items.AddRange(new object[] {
            "ຍິງ",
            "ຊາຍ"});
            this.EmpGenCb.Location = new System.Drawing.Point(259, 197);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(216, 32);
            this.EmpGenCb.TabIndex = 19;
            this.EmpGenCb.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Saysettha OT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(60, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 47);
            this.button2.TabIndex = 22;
            this.button2.Text = "ແກ້ໄຂ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(262, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "ການສຶກສາ";
            // 
            // EmpEduCb
            // 
            this.EmpEduCb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpEduCb.FormattingEnabled = true;
            this.EmpEduCb.Items.AddRange(new object[] {
            "BTech",
            "MTech",
            "BBA",
            "BCA",
            "MBA"});
            this.EmpEduCb.Location = new System.Drawing.Point(264, 425);
            this.EmpEduCb.Name = "EmpEduCb";
            this.EmpEduCb.Size = new System.Drawing.Size(216, 32);
            this.EmpEduCb.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "ເບີໂທ";
            // 
            // EmpDob
            // 
            this.EmpDob.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpDob.Location = new System.Drawing.Point(264, 312);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.Size = new System.Drawing.Size(211, 35);
            this.EmpDob.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(262, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "ວັນເດືອນປີເກີດ";
            // 
            // EmpPosCb
            // 
            this.EmpPosCb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpPosCb.ForeColor = System.Drawing.Color.Black;
            this.EmpPosCb.FormattingEnabled = true;
            this.EmpPosCb.Items.AddRange(new object[] {
            "Manager",
            "Serior Developer",
            "junice Developer",
            "Accountant",
            "Receptionist"});
            this.EmpPosCb.Location = new System.Drawing.Point(7, 316);
            this.EmpPosCb.Name = "EmpPosCb";
            this.EmpPosCb.Size = new System.Drawing.Size(228, 32);
            this.EmpPosCb.TabIndex = 13;
            this.EmpPosCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpPhoneTb.ForeColor = System.Drawing.Color.Black;
            this.EmpPhoneTb.Location = new System.Drawing.Point(12, 425);
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.Size = new System.Drawing.Size(223, 35);
            this.EmpPhoneTb.TabIndex = 12;
            this.EmpPhoneTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "ຕຳແຫນ່ງ";
            // 
            // EmpAddTb
            // 
            this.EmpAddTb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpAddTb.ForeColor = System.Drawing.Color.Black;
            this.EmpAddTb.Location = new System.Drawing.Point(7, 194);
            this.EmpAddTb.Name = "EmpAddTb";
            this.EmpAddTb.Size = new System.Drawing.Size(228, 35);
            this.EmpAddTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "ທີ່ຢູ່";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpNameTb.ForeColor = System.Drawing.Color.Black;
            this.EmpNameTb.Location = new System.Drawing.Point(259, 80);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(216, 35);
            this.EmpNameTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(262, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "ຊື່ພະນັກງານ";
            // 
            // EmpIDTb
            // 
            this.EmpIDTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EmpIDTb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EmpIDTb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIDTb.ForeColor = System.Drawing.Color.Black;
            this.EmpIDTb.Location = new System.Drawing.Point(12, 80);
            this.EmpIDTb.Name = "EmpIDTb";
            this.EmpIDTb.Size = new System.Drawing.Size(228, 35);
            this.EmpIDTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "ລະຫັດພະນັກງານ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1221, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 45);
            this.label10.TabIndex = 5;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1310, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.MinimizeBox = false;
            this.Name = "Employee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EmpPosCb;
        private System.Windows.Forms.TextBox EmpPhoneTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmpAddTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpIDTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EmpDob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox EmpEduCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox EmpGenCb;
        private System.Windows.Forms.DataGridView EmpDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}