namespace PRL
{
    partial class FormBanHang
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Trai = new Label();
            lbl_Phai = new Label();
            lbl_Trang = new Label();
            groupBox1 = new GroupBox();
            lbl_MaHD = new Label();
            label1 = new Label();
            cbb_MaKH = new ComboBox();
            btn_TaoHoaDon = new Button();
            dgv_HoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            dgv_HDCT = new DataGridView();
            button2 = new Button();
            groupBox3 = new GroupBox();
            btn_Sua = new Button();
            lbl_ttsp = new Label();
            label13 = new Label();
            button5 = new Button();
            btn_Xoa = new Button();
            txt_TienThua = new TextBox();
            txt_TienKhach = new TextBox();
            lbl_tthd = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            cbb_PTTT = new ComboBox();
            label6 = new Label();
            cbb_Voucher = new ComboBox();
            label5 = new Label();
            groupBox4 = new GroupBox();
            cbb_LoaiHang = new ComboBox();
            button6 = new Button();
            label12 = new Label();
            label11 = new Label();
            txt_SearchTen = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(7, 111);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(871, 662);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_Trai
            // 
            lbl_Trai.AutoSize = true;
            lbl_Trai.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbl_Trai.Location = new Point(361, 785);
            lbl_Trai.Name = "lbl_Trai";
            lbl_Trai.Size = new Size(43, 22);
            lbl_Trai.TabIndex = 6;
            lbl_Trai.Text = "<<<";
            lbl_Trai.Click += lbl_Trai_Click;
            // 
            // lbl_Phai
            // 
            lbl_Phai.AutoSize = true;
            lbl_Phai.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lbl_Phai.Location = new Point(492, 785);
            lbl_Phai.Name = "lbl_Phai";
            lbl_Phai.Size = new Size(43, 22);
            lbl_Phai.TabIndex = 5;
            lbl_Phai.Text = ">>>";
            lbl_Phai.Click += lbl_Phai_Click;
            // 
            // lbl_Trang
            // 
            lbl_Trang.AutoSize = true;
            lbl_Trang.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Trang.Location = new Point(434, 781);
            lbl_Trang.Name = "lbl_Trang";
            lbl_Trang.Size = new Size(21, 24);
            lbl_Trang.TabIndex = 4;
            lbl_Trang.Text = "1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_MaHD);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbb_MaKH);
            groupBox1.Controls.Add(btn_TaoHoaDon);
            groupBox1.Controls.Add(dgv_HoaDon);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(884, 12);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(438, 255);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // lbl_MaHD
            // 
            lbl_MaHD.AutoSize = true;
            lbl_MaHD.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_MaHD.Location = new Point(137, -3);
            lbl_MaHD.Name = "lbl_MaHD";
            lbl_MaHD.Size = new Size(17, 17);
            lbl_MaHD.TabIndex = 4;
            lbl_MaHD.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 3;
            label1.Text = "Mã KH:";
            // 
            // cbb_MaKH
            // 
            cbb_MaKH.FormattingEnabled = true;
            cbb_MaKH.Location = new Point(268, 27);
            cbb_MaKH.Name = "cbb_MaKH";
            cbb_MaKH.Size = new Size(162, 29);
            cbb_MaKH.TabIndex = 2;
            // 
            // btn_TaoHoaDon
            // 
            btn_TaoHoaDon.BackColor = Color.FromArgb(255, 128, 128);
            btn_TaoHoaDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_TaoHoaDon.ForeColor = Color.Black;
            btn_TaoHoaDon.Image = (Image)resources.GetObject("btn_TaoHoaDon.Image");
            btn_TaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TaoHoaDon.Location = new Point(16, 23);
            btn_TaoHoaDon.Margin = new Padding(3, 2, 3, 2);
            btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            btn_TaoHoaDon.Size = new Size(164, 34);
            btn_TaoHoaDon.TabIndex = 1;
            btn_TaoHoaDon.Text = "     Tạo hóa đơn";
            btn_TaoHoaDon.UseVisualStyleBackColor = false;
            btn_TaoHoaDon.Click += button1_Click;
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.BackgroundColor = Color.FromArgb(0, 192, 192);
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Location = new Point(7, 62);
            dgv_HoaDon.Margin = new Padding(3, 2, 3, 2);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.RowHeadersWidth = 51;
            dgv_HoaDon.Size = new Size(424, 182);
            dgv_HoaDon.TabIndex = 0;
            dgv_HoaDon.CellClick += dgv_HoaDon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_HDCT);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(884, 271);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(438, 228);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dgv_HDCT
            // 
            dgv_HDCT.BackgroundColor = Color.FromArgb(0, 192, 192);
            dgv_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HDCT.Location = new Point(8, 26);
            dgv_HDCT.Margin = new Padding(3, 2, 3, 2);
            dgv_HDCT.Name = "dgv_HDCT";
            dgv_HDCT.RowHeadersWidth = 51;
            dgv_HDCT.Size = new Size(422, 190);
            dgv_HDCT.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1377, 694);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(135, 36);
            button2.TabIndex = 16;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Sua);
            groupBox3.Controls.Add(lbl_ttsp);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(btn_Xoa);
            groupBox3.Controls.Add(txt_TienThua);
            groupBox3.Controls.Add(txt_TienKhach);
            groupBox3.Controls.Add(lbl_tthd);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cbb_PTTT);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cbb_Voucher);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(887, 504);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(435, 291);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tổng hợp";
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.FromArgb(255, 128, 128);
            btn_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Sua.Image = Properties.Resources.Edit;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(150, 249);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(125, 36);
            btn_Sua.TabIndex = 35;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            // 
            // lbl_ttsp
            // 
            lbl_ttsp.AutoSize = true;
            lbl_ttsp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ttsp.Location = new Point(243, 22);
            lbl_ttsp.Name = "lbl_ttsp";
            lbl_ttsp.Size = new Size(23, 25);
            lbl_ttsp.TabIndex = 34;
            lbl_ttsp.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 25);
            label13.Name = "label13";
            label13.Size = new Size(157, 21);
            label13.TabIndex = 33;
            label13.Text = "Tổng tiền sản phẩm:";
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(284, 249);
            button5.Name = "button5";
            button5.Size = new Size(144, 36);
            button5.TabIndex = 32;
            button5.Text = "    Thanh toán";
            button5.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.FromArgb(255, 128, 128);
            btn_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Xoa.Image = (Image)resources.GetObject("btn_Xoa.Image");
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(8, 249);
            btn_Xoa.Margin = new Padding(3, 2, 3, 2);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(125, 36);
            btn_Xoa.TabIndex = 31;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // txt_TienThua
            // 
            txt_TienThua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_TienThua.Location = new Point(131, 213);
            txt_TienThua.Margin = new Padding(3, 2, 3, 2);
            txt_TienThua.Name = "txt_TienThua";
            txt_TienThua.ReadOnly = true;
            txt_TienThua.Size = new Size(298, 29);
            txt_TienThua.TabIndex = 29;
            txt_TienThua.Text = "0";
            // 
            // txt_TienKhach
            // 
            txt_TienKhach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_TienKhach.Location = new Point(131, 172);
            txt_TienKhach.Margin = new Padding(3, 2, 3, 2);
            txt_TienKhach.Name = "txt_TienKhach";
            txt_TienKhach.Size = new Size(296, 29);
            txt_TienKhach.TabIndex = 28;
            txt_TienKhach.Text = "0";
            txt_TienKhach.TextChanged += txt_TienKhach_TextChanged;
            // 
            // lbl_tthd
            // 
            lbl_tthd.AutoSize = true;
            lbl_tthd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tthd.Location = new Point(243, 134);
            lbl_tthd.Name = "lbl_tthd";
            lbl_tthd.Size = new Size(23, 25);
            lbl_tthd.TabIndex = 27;
            lbl_tthd.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(10, 216);
            label10.Name = "label10";
            label10.Size = new Size(82, 21);
            label10.TabIndex = 24;
            label10.Text = "Tiền thừa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(10, 175);
            label9.Name = "label9";
            label9.Size = new Size(123, 21);
            label9.TabIndex = 25;
            label9.Text = "Tiền khách đưa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(10, 137);
            label7.Name = "label7";
            label7.Size = new Size(148, 21);
            label7.TabIndex = 26;
            label7.Text = "Tổng tiền hóa đơn:";
            // 
            // cbb_PTTT
            // 
            cbb_PTTT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbb_PTTT.FormattingEnabled = true;
            cbb_PTTT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản ngân hàng", "Quẹt thẻ tín dụng" });
            cbb_PTTT.Location = new Point(129, 97);
            cbb_PTTT.Margin = new Padding(3, 2, 3, 2);
            cbb_PTTT.Name = "cbb_PTTT";
            cbb_PTTT.Size = new Size(298, 29);
            cbb_PTTT.TabIndex = 20;
            cbb_PTTT.Tag = "";
            cbb_PTTT.SelectedIndexChanged += cbb_PTTT_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(10, 100);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 23;
            label6.Text = "Phương thức:";
            // 
            // cbb_Voucher
            // 
            cbb_Voucher.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbb_Voucher.FormattingEnabled = true;
            cbb_Voucher.Location = new Point(128, 57);
            cbb_Voucher.Margin = new Padding(3, 2, 3, 2);
            cbb_Voucher.Name = "cbb_Voucher";
            cbb_Voucher.Size = new Size(299, 29);
            cbb_Voucher.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(10, 60);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 21;
            label5.Text = "Voucher:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbb_LoaiHang);
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txt_SearchTen);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(7, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(871, 88);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // cbb_LoaiHang
            // 
            cbb_LoaiHang.FormattingEnabled = true;
            cbb_LoaiHang.Location = new Point(510, 33);
            cbb_LoaiHang.Name = "cbb_LoaiHang";
            cbb_LoaiHang.Size = new Size(169, 29);
            cbb_LoaiHang.TabIndex = 5;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Image = Properties.Resources.Search;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(712, 28);
            button6.Name = "button6";
            button6.Size = new Size(134, 41);
            button6.TabIndex = 4;
            button6.Text = "Tìm kiếm";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(435, 39);
            label12.Name = "label12";
            label12.Size = new Size(69, 21);
            label12.TabIndex = 3;
            label12.Text = "Tên loại:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 36);
            label11.Name = "label11";
            label11.Size = new Size(112, 21);
            label11.TabIndex = 2;
            label11.Text = "Tên sản phẩm:";
            // 
            // txt_SearchTen
            // 
            txt_SearchTen.Location = new Point(124, 33);
            txt_SearchTen.Name = "txt_SearchTen";
            txt_SearchTen.PlaceholderText = "Tìm tên sản phẩm...";
            txt_SearchTen.Size = new Size(284, 29);
            txt_SearchTen.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 811);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lbl_Trai);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_Phai);
            Controls.Add(lbl_Trang);
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBanHang";
            Load += FormBanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_Trai;
        private Label lbl_Phai;
        private Label lbl_Trang;
        private GroupBox groupBox1;
        private Button btn_TaoHoaDon;
        private DataGridView dgv_HoaDon;
        private GroupBox groupBox2;
        private DataGridView dgv_HDCT;
        private Button button2;
        private GroupBox groupBox3;
        private Button button5;
        private Button btn_Xoa;
        private TextBox txt_TienThua;
        private TextBox txt_TienKhach;
        private Label lbl_tthd;
        private Label label10;
        private Label label9;
        private Label label7;
        private ComboBox cbb_PTTT;
        private Label label6;
        private ComboBox cbb_Voucher;
        private Label label5;
        private GroupBox groupBox4;
        private Button button6;
        private Label label12;
        private Label label11;
        private ComboBox comboBox3;
        private TextBox txt_SearchTen;
        private Label lbl_ttsp;
        private Label label13;
        private ComboBox cbb_LoaiHang;
        private Button btn_Sua;
        private Label lbl_MaHD;
        private Label label1;
        private ComboBox cbb_MaKH;
        private System.Windows.Forms.Timer timer1;
    }
}