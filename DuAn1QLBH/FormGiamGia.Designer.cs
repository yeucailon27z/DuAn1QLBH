namespace PRL
{
    partial class FormGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiamGia));
            dgv_BangPhieuGiamGia = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_magg = new TextBox();
            tb_PhanTrum = new TextBox();
            tb_mote = new TextBox();
            cb_tthai = new ComboBox();
            dtp_nbd = new DateTimePicker();
            dtp_nkt = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txt_SearchTen = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tb_max = new TextBox();
            label12 = new Label();
            tb_min = new TextBox();
            tb_tengg = new TextBox();
            label7 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            txt_KhoangGG = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_BangPhieuGiamGia).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_BangPhieuGiamGia
            // 
            dgv_BangPhieuGiamGia.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgv_BangPhieuGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BangPhieuGiamGia.Location = new Point(6, 27);
            dgv_BangPhieuGiamGia.Margin = new Padding(3, 2, 3, 2);
            dgv_BangPhieuGiamGia.Name = "dgv_BangPhieuGiamGia";
            dgv_BangPhieuGiamGia.RowHeadersWidth = 51;
            dgv_BangPhieuGiamGia.Size = new Size(660, 400);
            dgv_BangPhieuGiamGia.TabIndex = 0;
            dgv_BangPhieuGiamGia.CellClick += dgv_BangPhieuGiamGia_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 1;
            label1.Text = "Mã giảm giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(16, 135);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 2;
            label2.Text = "Phần trăm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(16, 180);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 3;
            label3.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(16, 221);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 4;
            label4.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(16, 336);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 5;
            label5.Text = "Trạng thái:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(17, 377);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 6;
            label6.Text = "Mô tả:";
            // 
            // tb_magg
            // 
            tb_magg.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            tb_magg.Location = new Point(149, 47);
            tb_magg.Margin = new Padding(3, 2, 3, 2);
            tb_magg.Name = "tb_magg";
            tb_magg.Size = new Size(296, 27);
            tb_magg.TabIndex = 7;
            // 
            // tb_PhanTrum
            // 
            tb_PhanTrum.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            tb_PhanTrum.Location = new Point(149, 134);
            tb_PhanTrum.Margin = new Padding(3, 2, 3, 2);
            tb_PhanTrum.Name = "tb_PhanTrum";
            tb_PhanTrum.Size = new Size(296, 27);
            tb_PhanTrum.TabIndex = 8;
            // 
            // tb_mote
            // 
            tb_mote.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            tb_mote.Location = new Point(149, 372);
            tb_mote.Margin = new Padding(3, 2, 3, 2);
            tb_mote.Multiline = true;
            tb_mote.Name = "tb_mote";
            tb_mote.Size = new Size(296, 55);
            tb_mote.TabIndex = 9;
            // 
            // cb_tthai
            // 
            cb_tthai.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            cb_tthai.FormattingEnabled = true;
            cb_tthai.Items.AddRange(new object[] { "Không hoạt động", "Hoạt động" });
            cb_tthai.Location = new Point(149, 335);
            cb_tthai.Margin = new Padding(3, 2, 3, 2);
            cb_tthai.Name = "cb_tthai";
            cb_tthai.Size = new Size(296, 27);
            cb_tthai.TabIndex = 10;
            // 
            // dtp_nbd
            // 
            dtp_nbd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtp_nbd.Format = DateTimePickerFormat.Short;
            dtp_nbd.Location = new Point(149, 176);
            dtp_nbd.Margin = new Padding(3, 2, 3, 2);
            dtp_nbd.Name = "dtp_nbd";
            dtp_nbd.Size = new Size(296, 27);
            dtp_nbd.TabIndex = 11;
            // 
            // dtp_nkt
            // 
            dtp_nkt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dtp_nkt.Format = DateTimePickerFormat.Short;
            dtp_nkt.Location = new Point(149, 217);
            dtp_nkt.Margin = new Padding(3, 2, 3, 2);
            dtp_nkt.Name = "dtp_nkt";
            dtp_nkt.Size = new Size(296, 27);
            dtp_nkt.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Image = Properties.Resources.Add;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(38, 32);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 42);
            button1.TabIndex = 13;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Image = Properties.Resources.Edit;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(210, 32);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(144, 42);
            button2.TabIndex = 14;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(386, 32);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(144, 42);
            button3.TabIndex = 15;
            button3.Text = "Làm mới";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt_SearchTen
            // 
            txt_SearchTen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_SearchTen.Location = new Point(559, 47);
            txt_SearchTen.Margin = new Padding(3, 2, 3, 2);
            txt_SearchTen.Name = "txt_SearchTen";
            txt_SearchTen.PlaceholderText = "Tìm kiếm...";
            txt_SearchTen.Size = new Size(206, 27);
            txt_SearchTen.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_BangPhieuGiamGia);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(575, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 436);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng các phiếu giảm giá";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_max);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(tb_min);
            groupBox2.Controls.Add(tb_tengg);
            groupBox2.Controls.Add(tb_magg);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tb_PhanTrum);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tb_mote);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cb_tthai);
            groupBox2.Controls.Add(dtp_nkt);
            groupBox2.Controls.Add(dtp_nbd);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(72, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 436);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu giảm giá";
            // 
            // tb_max
            // 
            tb_max.Location = new Point(149, 293);
            tb_max.Name = "tb_max";
            tb_max.Size = new Size(296, 29);
            tb_max.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(17, 296);
            label12.Name = "label12";
            label12.Size = new Size(80, 21);
            label12.TabIndex = 15;
            label12.Text = "Tiền Max:";
            // 
            // tb_min
            // 
            tb_min.Location = new Point(149, 255);
            tb_min.Name = "tb_min";
            tb_min.Size = new Size(296, 29);
            tb_min.TabIndex = 14;
            // 
            // tb_tengg
            // 
            tb_tengg.Location = new Point(149, 90);
            tb_tengg.Name = "tb_tengg";
            tb_tengg.Size = new Size(296, 29);
            tb_tengg.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(16, 93);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 1;
            label7.Text = "Tên giảm giá:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(17, 258);
            label11.Name = "label11";
            label11.Size = new Size(77, 21);
            label11.TabIndex = 5;
            label11.Text = "Tiền Min:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(txt_KhoangGG);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(txt_SearchTen);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(72, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1175, 94);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các chức năng";
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Image = Properties.Resources.Search;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1014, 32);
            button4.Name = "button4";
            button4.Size = new Size(144, 42);
            button4.TabIndex = 20;
            button4.Text = "Lọc";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txt_KhoangGG
            // 
            txt_KhoangGG.Location = new Point(781, 45);
            txt_KhoangGG.Name = "txt_KhoangGG";
            txt_KhoangGG.Size = new Size(210, 29);
            txt_KhoangGG.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(781, 24);
            label9.Name = "label9";
            label9.Size = new Size(136, 21);
            label9.TabIndex = 18;
            label9.Text = "Khoảng giảm giá:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 24);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 17;
            label8.Text = "Tên phiếu giảm giá:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(496, 66);
            label10.Name = "label10";
            label10.Size = new Size(534, 54);
            label10.TabIndex = 28;
            label10.Text = "Quản Lý Phiếu Giảm Giá";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FormGiamGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 790);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormGiamGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGiamGia";
            Load += FormGiamGia_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_BangPhieuGiamGia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_BangPhieuGiamGia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_magg;
        private TextBox tb_PhanTrum;
        private TextBox tb_mote;
        private ComboBox cb_tthai;
        private DateTimePicker dtp_nbd;
        private DateTimePicker dtp_nkt;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txt_SearchTen;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tb_tengg;
        private Label label7;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Button button4;
        private TextBox txt_KhoangGG;
        private Label label10;
        private TextBox tb_min;
        private Label label11;
        private TextBox tb_max;
        private Label label12;
        private PictureBox pictureBox1;
    }
}