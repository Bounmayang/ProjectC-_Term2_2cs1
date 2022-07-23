namespace WindowsFormsApp1
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpGens = new System.Windows.Forms.Label();
            this.EmpEdus = new System.Windows.Forms.Label();
            this.EmpDOBs = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Empidlbl = new System.Windows.Forms.Label();
            this.EmpPho = new System.Windows.Forms.Label();
            this.EmpPos = new System.Windows.Forms.Label();
            this.EmpAdd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpidTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printPD = new System.Windows.Forms.PrintPreviewDialog();
            this.printD = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "ລາຍລະອຽດຂອງພະນັກງານ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1249, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 45);
            this.label10.TabIndex = 9;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpGens);
            this.panel1.Controls.Add(this.EmpEdus);
            this.panel1.Controls.Add(this.EmpDOBs);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Empidlbl);
            this.panel1.Controls.Add(this.EmpPho);
            this.panel1.Controls.Add(this.EmpPos);
            this.panel1.Controls.Add(this.EmpAdd);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpidTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel1.Location = new System.Drawing.Point(13, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 597);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(677, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 38);
            this.label9.TabIndex = 41;
            this.label9.Text = "ເພດ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(677, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 38);
            this.label8.TabIndex = 40;
            this.label8.Text = "ລະດັບການສຶກສາ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(677, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 38);
            this.label6.TabIndex = 39;
            this.label6.Text = "ວັນເດືອນປີເກີດ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(677, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 38);
            this.label3.TabIndex = 38;
            this.label3.Text = "ຊື່ພະນັກງານ :";
            // 
            // EmpGens
            // 
            this.EmpGens.AutoSize = true;
            this.EmpGens.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpGens.ForeColor = System.Drawing.Color.Black;
            this.EmpGens.Location = new System.Drawing.Point(937, 215);
            this.EmpGens.Name = "EmpGens";
            this.EmpGens.Size = new System.Drawing.Size(213, 38);
            this.EmpGens.TabIndex = 37;
            this.EmpGens.Text = "Employee Gender";
            this.EmpGens.Visible = false;
            // 
            // EmpEdus
            // 
            this.EmpEdus.AutoSize = true;
            this.EmpEdus.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpEdus.ForeColor = System.Drawing.Color.Black;
            this.EmpEdus.Location = new System.Drawing.Point(937, 346);
            this.EmpEdus.Name = "EmpEdus";
            this.EmpEdus.Size = new System.Drawing.Size(240, 38);
            this.EmpEdus.TabIndex = 36;
            this.EmpEdus.Text = "Employee Education";
            this.EmpEdus.Visible = false;
            // 
            // EmpDOBs
            // 
            this.EmpDOBs.AutoSize = true;
            this.EmpDOBs.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpDOBs.ForeColor = System.Drawing.Color.Black;
            this.EmpDOBs.Location = new System.Drawing.Point(937, 280);
            this.EmpDOBs.Name = "EmpDOBs";
            this.EmpDOBs.Size = new System.Drawing.Size(174, 38);
            this.EmpDOBs.TabIndex = 35;
            this.EmpDOBs.Text = "EmployeeDOB";
            this.EmpDOBs.Visible = false;
            // 
            // EmpName
            // 
            this.EmpName.AutoSize = true;
            this.EmpName.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpName.ForeColor = System.Drawing.Color.Black;
            this.EmpName.Location = new System.Drawing.Point(937, 149);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(197, 38);
            this.EmpName.TabIndex = 34;
            this.EmpName.Text = "Employee Name";
            this.EmpName.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Saysettha OT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(684, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 54);
            this.button2.TabIndex = 33;
            this.button2.Text = "ກັບຄືນ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Empidlbl
            // 
            this.Empidlbl.AutoSize = true;
            this.Empidlbl.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empidlbl.ForeColor = System.Drawing.Color.Black;
            this.Empidlbl.Location = new System.Drawing.Point(376, 140);
            this.Empidlbl.Name = "Empidlbl";
            this.Empidlbl.Size = new System.Drawing.Size(0, 38);
            this.Empidlbl.TabIndex = 28;
            this.Empidlbl.Visible = false;
            // 
            // EmpPho
            // 
            this.EmpPho.AutoSize = true;
            this.EmpPho.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPho.ForeColor = System.Drawing.Color.Black;
            this.EmpPho.Location = new System.Drawing.Point(376, 356);
            this.EmpPho.Name = "EmpPho";
            this.EmpPho.Size = new System.Drawing.Size(202, 38);
            this.EmpPho.TabIndex = 27;
            this.EmpPho.Text = "Employee Phone";
            this.EmpPho.Visible = false;
            // 
            // EmpPos
            // 
            this.EmpPos.AutoSize = true;
            this.EmpPos.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPos.ForeColor = System.Drawing.Color.Black;
            this.EmpPos.Location = new System.Drawing.Point(376, 280);
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.Size = new System.Drawing.Size(218, 38);
            this.EmpPos.TabIndex = 26;
            this.EmpPos.Text = "Employee Position";
            this.EmpPos.Visible = false;
            // 
            // EmpAdd
            // 
            this.EmpAdd.AutoSize = true;
            this.EmpAdd.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAdd.ForeColor = System.Drawing.Color.Black;
            this.EmpAdd.Location = new System.Drawing.Point(376, 215);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Size = new System.Drawing.Size(221, 38);
            this.EmpAdd.TabIndex = 25;
            this.EmpAdd.Text = "Employee Address";
            this.EmpAdd.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(129, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 38);
            this.label11.TabIndex = 24;
            this.label11.Text = "ລະຫັດພະນັກງານ :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Saysettha OT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(440, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 54);
            this.button3.TabIndex = 23;
            this.button3.Text = "ພິມ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Saysettha OT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(752, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "ເບິ່ງລາຍລະອຽດ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(129, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "ເບີຕິດຕໍໍ່ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(129, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "ຕຳແຫນ່ງ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(129, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "ທີ່ຢູ່ :";
            // 
            // EmpidTb
            // 
            this.EmpidTb.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmpidTb.ForeColor = System.Drawing.Color.Black;
            this.EmpidTb.Location = new System.Drawing.Point(524, 43);
            this.EmpidTb.Name = "EmpidTb";
            this.EmpidTb.Size = new System.Drawing.Size(198, 35);
            this.EmpidTb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(288, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "ໃສ່ລະຫັດພະນັກງານ :";
            // 
            // printPD
            // 
            this.printPD.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPD.ClientSize = new System.Drawing.Size(400, 300);
            this.printPD.Document = this.printD;
            this.printPD.Enabled = true;
            this.printPD.Icon = ((System.Drawing.Icon)(resources.GetObject("printPD.Icon")));
            this.printPD.Name = "printPD";
            this.printPD.Visible = false;
            this.printPD.Load += new System.EventHandler(this.printPD_Load);
            // 
            // printD
            // 
            this.printD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printD_PrintPage);
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1251, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpidTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Empidlbl;
        private System.Windows.Forms.Label EmpPho;
        private System.Windows.Forms.Label EmpPos;
        private System.Windows.Forms.Label EmpAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label EmpGens;
        private System.Windows.Forms.Label EmpEdus;
        private System.Windows.Forms.Label EmpDOBs;
        private System.Windows.Forms.Label EmpName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPD;
        private System.Drawing.Printing.PrintDocument printD;
    }
}