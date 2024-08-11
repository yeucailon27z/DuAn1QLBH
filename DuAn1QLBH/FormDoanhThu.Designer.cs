namespace PRL
{
    partial class FormDoanhThu
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
            dtg_DoanhThu = new DataGridView();
            panel1 = new Panel();
            lbl_soHD = new Label();
            lbl_ngayHD = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lbl_dtNgayValue = new Label();
            lbl_dtNgay = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lbl_dtThangValue = new Label();
            lbl_dtThang = new Label();
            label9 = new Label();
            panel4 = new Panel();
            lbl_dtNamValue = new Label();
            lbl_dtNam = new Label();
            label12 = new Label();
            label13 = new Label();
            dtp_Ngay = new DateTimePicker();
            btn_Loc = new Button();
            groupBox1 = new GroupBox();
            dtp_search1 = new DateTimePicker();
            dtp_search2 = new DateTimePicker();
            groupBox2 = new GroupBox();
            button1 = new Button();
            lbl_searchDT = new Label();
            label5 = new Label();
            lbl_searhsoHD = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_DoanhThu).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_DoanhThu
            // 
            dtg_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DoanhThu.Location = new Point(19, 24);
            dtg_DoanhThu.Name = "dtg_DoanhThu";
            dtg_DoanhThu.Size = new Size(1229, 313);
            dtg_DoanhThu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbl_soHD);
            panel1.Controls.Add(lbl_ngayHD);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 206);
            panel1.TabIndex = 1;
            // 
            // lbl_soHD
            // 
            lbl_soHD.AutoSize = true;
            lbl_soHD.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_soHD.Location = new Point(113, 126);
            lbl_soHD.Name = "lbl_soHD";
            lbl_soHD.Size = new Size(28, 30);
            lbl_soHD.TabIndex = 2;
            lbl_soHD.Text = "...";
            // 
            // lbl_ngayHD
            // 
            lbl_ngayHD.AutoSize = true;
            lbl_ngayHD.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lbl_ngayHD.Location = new Point(145, 57);
            lbl_ngayHD.Name = "lbl_ngayHD";
            lbl_ngayHD.Size = new Size(27, 25);
            lbl_ngayHD.TabIndex = 1;
            lbl_ngayHD.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(241, 21);
            label1.TabIndex = 0;
            label1.Text = "Số hóa đơn đã bán trong tháng:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lbl_dtNgayValue);
            panel2.Controls.Add(lbl_dtNgay);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(366, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 206);
            panel2.TabIndex = 2;
            // 
            // lbl_dtNgayValue
            // 
            lbl_dtNgayValue.AutoSize = true;
            lbl_dtNgayValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_dtNgayValue.Location = new Point(121, 126);
            lbl_dtNgayValue.Name = "lbl_dtNgayValue";
            lbl_dtNgayValue.Size = new Size(28, 30);
            lbl_dtNgayValue.TabIndex = 5;
            lbl_dtNgayValue.Text = "...";
            // 
            // lbl_dtNgay
            // 
            lbl_dtNgay.AutoSize = true;
            lbl_dtNgay.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lbl_dtNgay.Location = new Point(158, 27);
            lbl_dtNgay.Name = "lbl_dtNgay";
            lbl_dtNgay.Size = new Size(27, 25);
            lbl_dtNgay.TabIndex = 4;
            lbl_dtNgay.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 27);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 3;
            label6.Text = "Doanh thu ngày:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 128);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lbl_dtThangValue);
            panel3.Controls.Add(lbl_dtThang);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(683, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 206);
            panel3.TabIndex = 2;
            // 
            // lbl_dtThangValue
            // 
            lbl_dtThangValue.AutoSize = true;
            lbl_dtThangValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_dtThangValue.Location = new Point(126, 126);
            lbl_dtThangValue.Name = "lbl_dtThangValue";
            lbl_dtThangValue.Size = new Size(28, 30);
            lbl_dtThangValue.TabIndex = 8;
            lbl_dtThangValue.Text = "...";
            // 
            // lbl_dtThang
            // 
            lbl_dtThang.AutoSize = true;
            lbl_dtThang.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lbl_dtThang.Location = new Point(175, 27);
            lbl_dtThang.Name = "lbl_dtThang";
            lbl_dtThang.Size = new Size(27, 25);
            lbl_dtThang.TabIndex = 7;
            lbl_dtThang.Text = "...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 27);
            label9.Name = "label9";
            label9.Size = new Size(135, 21);
            label9.TabIndex = 6;
            label9.Text = "Doanh thu tháng:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(lbl_dtNamValue);
            panel4.Controls.Add(lbl_dtNam);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(1002, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 206);
            panel4.TabIndex = 2;
            // 
            // lbl_dtNamValue
            // 
            lbl_dtNamValue.AutoSize = true;
            lbl_dtNamValue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbl_dtNamValue.ForeColor = Color.White;
            lbl_dtNamValue.Location = new Point(134, 126);
            lbl_dtNamValue.Name = "lbl_dtNamValue";
            lbl_dtNamValue.Size = new Size(28, 30);
            lbl_dtNamValue.TabIndex = 8;
            lbl_dtNamValue.Text = "...";
            // 
            // lbl_dtNam
            // 
            lbl_dtNam.AutoSize = true;
            lbl_dtNam.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lbl_dtNam.ForeColor = Color.White;
            lbl_dtNam.Location = new Point(170, 24);
            lbl_dtNam.Name = "lbl_dtNam";
            lbl_dtNam.Size = new Size(27, 25);
            lbl_dtNam.TabIndex = 7;
            lbl_dtNam.Text = "...";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(19, 27);
            label12.Name = "label12";
            label12.Size = new Size(124, 21);
            label12.TabIndex = 6;
            label12.Text = "Doanh thu năm:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(42, 9);
            label13.Name = "label13";
            label13.Size = new Size(463, 54);
            label13.TabIndex = 3;
            label13.Text = "Thống Kê Doanh Thu";
            // 
            // dtp_Ngay
            // 
            dtp_Ngay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_Ngay.Format = DateTimePickerFormat.Short;
            dtp_Ngay.Location = new Point(196, 75);
            dtp_Ngay.Name = "dtp_Ngay";
            dtp_Ngay.Size = new Size(295, 29);
            dtp_Ngay.TabIndex = 4;
            // 
            // btn_Loc
            // 
            btn_Loc.BackColor = Color.FromArgb(255, 128, 255);
            btn_Loc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Loc.Location = new Point(537, 76);
            btn_Loc.Name = "btn_Loc";
            btn_Loc.Size = new Size(133, 31);
            btn_Loc.TabIndex = 5;
            btn_Loc.Text = "Lọc";
            btn_Loc.UseVisualStyleBackColor = false;
            btn_Loc.Click += btn_Loc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_DoanhThu);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 349);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng Doanh Thu";
            // 
            // dtp_search1
            // 
            dtp_search1.Format = DateTimePickerFormat.Short;
            dtp_search1.Location = new Point(107, 28);
            dtp_search1.Name = "dtp_search1";
            dtp_search1.Size = new Size(238, 29);
            dtp_search1.TabIndex = 7;
            // 
            // dtp_search2
            // 
            dtp_search2.Format = DateTimePickerFormat.Short;
            dtp_search2.Location = new Point(443, 28);
            dtp_search2.Name = "dtp_search2";
            dtp_search2.Size = new Size(238, 29);
            dtp_search2.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(lbl_searchDT);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lbl_searhsoHD);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtp_search1);
            groupBox2.Controls.Add(dtp_search2);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(46, 694);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1260, 84);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Location = new Point(1092, 34);
            button1.Name = "button1";
            button1.Size = new Size(133, 31);
            button1.TabIndex = 14;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_searchDT
            // 
            lbl_searchDT.AutoSize = true;
            lbl_searchDT.Location = new Point(997, 34);
            lbl_searchDT.Name = "lbl_searchDT";
            lbl_searchDT.Size = new Size(22, 21);
            lbl_searchDT.TabIndex = 13;
            lbl_searchDT.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(847, 34);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 12;
            label5.Text = "Tổng doanh thu:";
            // 
            // lbl_searhsoHD
            // 
            lbl_searhsoHD.AutoSize = true;
            lbl_searhsoHD.Location = new Point(799, 34);
            lbl_searhsoHD.Name = "lbl_searhsoHD";
            lbl_searhsoHD.Size = new Size(22, 21);
            lbl_searhsoHD.TabIndex = 11;
            lbl_searhsoHD.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(696, 34);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 10;
            label4.Text = "Số hóa đơn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 34);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 9;
            label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 34);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 9;
            label2.Text = "Từ ngày:";
            // 
            // FormDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 790);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_Loc);
            Controls.Add(dtp_Ngay);
            Controls.Add(label13);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDoanhThu";
            Load += FormDoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_DoanhThu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_DoanhThu;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lbl_soHD;
        private Label lbl_ngayHD;
        private Label label1;
        private Label lbl_dtNgayValue;
        private Label lbl_dtNgay;
        private Label label6;
        private Label lbl_dtThangValue;
        private Label lbl_dtThang;
        private Label label9;
        private Label lbl_dtNamValue;
        private Label lbl_dtNam;
        private Label label12;
        private Label label13;
        private DateTimePicker dtp_Ngay;
        private Button btn_Loc;
        private GroupBox groupBox1;
        private DateTimePicker dtp_search1;
        private DateTimePicker dtp_search2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label lbl_searchDT;
        private Label label5;
        private Label lbl_searhsoHD;
    }
}