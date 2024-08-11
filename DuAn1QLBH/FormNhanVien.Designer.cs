namespace PRL
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cbb_ChucVu = new ComboBox();
            txt_Ma = new TextBox();
            label1 = new Label();
            cbb_TrangThai = new ComboBox();
            txt_SDT = new TextBox();
            txt_Password = new TextBox();
            txt_Ten = new TextBox();
            txt_Username = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            dgv_NhanVien = new DataGridView();
            groupBox2 = new GroupBox();
            btn_Lock = new Button();
            txt_SearchTenNV = new TextBox();
            groupBox3 = new GroupBox();
            btn_Unlock = new Button();
            cbb_SearchTT = new ComboBox();
            btn_Search = new Button();
            label9 = new Label();
            label8 = new Label();
            btn_Them = new Button();
            btn_Sua = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NhanVien).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(526, 77);
            label2.Name = "label2";
            label2.Size = new Size(424, 54);
            label2.TabIndex = 33;
            label2.Text = "Quản Lý Nhân Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbb_ChucVu);
            groupBox1.Controls.Add(txt_Ma);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbb_TrangThai);
            groupBox1.Controls.Add(txt_SDT);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label14);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(80, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 423);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // cbb_ChucVu
            // 
            cbb_ChucVu.FormattingEnabled = true;
            cbb_ChucVu.Items.AddRange(new object[] { "Admin", "Nhân viên" });
            cbb_ChucVu.Location = new Point(141, 297);
            cbb_ChucVu.Name = "cbb_ChucVu";
            cbb_ChucVu.Size = new Size(289, 29);
            cbb_ChucVu.TabIndex = 28;
            // 
            // txt_Ma
            // 
            txt_Ma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Ma.Location = new Point(141, 45);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(289, 29);
            txt_Ma.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 26;
            label1.Text = "Mã Nhân Viên:";
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Đã bị khóa" });
            cbb_TrangThai.Location = new Point(141, 347);
            cbb_TrangThai.Margin = new Padding(3, 2, 3, 2);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(289, 29);
            cbb_TrangThai.TabIndex = 25;
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_SDT.Location = new Point(141, 240);
            txt_SDT.Margin = new Padding(3, 2, 3, 2);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(289, 29);
            txt_SDT.TabIndex = 24;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Password.Location = new Point(141, 141);
            txt_Password.Margin = new Padding(3, 2, 3, 2);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(289, 29);
            txt_Password.TabIndex = 23;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Ten.Location = new Point(141, 188);
            txt_Ten.Margin = new Padding(3, 2, 3, 2);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(289, 29);
            txt_Ten.TabIndex = 22;
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Username.Location = new Point(141, 95);
            txt_Username.Margin = new Padding(3, 2, 3, 2);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(289, 29);
            txt_Username.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(17, 297);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 19;
            label3.Text = "Chức vụ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(17, 355);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 19;
            label7.Text = "Trạng thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(20, 240);
            label10.Name = "label10";
            label10.Size = new Size(43, 21);
            label10.TabIndex = 18;
            label10.Text = "SĐT:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(20, 144);
            label11.Name = "label11";
            label11.Size = new Size(83, 21);
            label11.TabIndex = 17;
            label11.Text = "Password:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(20, 188);
            label12.Name = "label12";
            label12.Size = new Size(64, 21);
            label12.TabIndex = 16;
            label12.Text = "Họ tên:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(20, 95);
            label14.Name = "label14";
            label14.Size = new Size(87, 21);
            label14.TabIndex = 14;
            label14.Text = "Username:";
            // 
            // dgv_NhanVien
            // 
            dgv_NhanVien.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgv_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NhanVien.Location = new Point(6, 27);
            dgv_NhanVien.Margin = new Padding(3, 2, 3, 2);
            dgv_NhanVien.Name = "dgv_NhanVien";
            dgv_NhanVien.RowHeadersWidth = 51;
            dgv_NhanVien.Size = new Size(651, 391);
            dgv_NhanVien.TabIndex = 20;
            dgv_NhanVien.CellClick += dgv_NhanVien_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_NhanVien);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(581, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 423);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // btn_Lock
            // 
            btn_Lock.BackColor = Color.Fuchsia;
            btn_Lock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Lock.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Lock.Location = new Point(310, 32);
            btn_Lock.Margin = new Padding(3, 2, 3, 2);
            btn_Lock.Name = "btn_Lock";
            btn_Lock.Size = new Size(129, 42);
            btn_Lock.TabIndex = 15;
            btn_Lock.Text = "Khóa";
            btn_Lock.UseVisualStyleBackColor = false;
            btn_Lock.Click += btn_Lock_Click;
            // 
            // txt_SearchTenNV
            // 
            txt_SearchTenNV.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_SearchTenNV.Location = new Point(594, 47);
            txt_SearchTenNV.Margin = new Padding(3, 2, 3, 2);
            txt_SearchTenNV.Name = "txt_SearchTenNV";
            txt_SearchTenNV.PlaceholderText = "Tìm kiếm...";
            txt_SearchTenNV.Size = new Size(206, 27);
            txt_SearchTenNV.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Unlock);
            groupBox3.Controls.Add(cbb_SearchTT);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btn_Them);
            groupBox3.Controls.Add(btn_Sua);
            groupBox3.Controls.Add(btn_Lock);
            groupBox3.Controls.Add(txt_SearchTenNV);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(49, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1206, 94);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các chức năng";
            // 
            // btn_Unlock
            // 
            btn_Unlock.BackColor = Color.Fuchsia;
            btn_Unlock.Location = new Point(455, 32);
            btn_Unlock.Name = "btn_Unlock";
            btn_Unlock.Size = new Size(129, 42);
            btn_Unlock.TabIndex = 22;
            btn_Unlock.Text = "Mở Khóa";
            btn_Unlock.UseVisualStyleBackColor = false;
            btn_Unlock.Click += btn_Unlock_Click;
            // 
            // cbb_SearchTT
            // 
            cbb_SearchTT.FormattingEnabled = true;
            cbb_SearchTT.Items.AddRange(new object[] { "Đang hoạt động", "Đã bị khóa" });
            cbb_SearchTT.Location = new Point(816, 45);
            cbb_SearchTT.Name = "cbb_SearchTT";
            cbb_SearchTT.Size = new Size(185, 29);
            cbb_SearchTT.TabIndex = 21;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.Yellow;
            btn_Search.Image = Properties.Resources.Search;
            btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Search.Location = new Point(1049, 32);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(144, 42);
            btn_Search.TabIndex = 20;
            btn_Search.Text = "Lọc";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(816, 24);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 18;
            label9.Text = "Trạng Thái:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(594, 24);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 17;
            label8.Text = "Tên nhân viên:";
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.Fuchsia;
            btn_Them.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Them.Image = Properties.Resources.Add;
            btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Them.Location = new Point(20, 32);
            btn_Them.Margin = new Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(129, 42);
            btn_Them.TabIndex = 13;
            btn_Them.Text = "  Thêm ";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.Fuchsia;
            btn_Sua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Sua.Image = Properties.Resources.Edit;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(165, 32);
            btn_Sua.Margin = new Padding(3, 2, 3, 2);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(129, 42);
            btn_Sua.TabIndex = 14;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 790);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            Load += FormNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NhanVien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txt_Ma;
        private Label label1;
        private ComboBox cbb_TrangThai;
        private TextBox txt_SDT;
        private TextBox txt_Password;
        private TextBox txt_Ten;
        private TextBox txt_Username;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private DataGridView dgv_NhanVien;
        private GroupBox groupBox2;
        private Button btn_Lock;
        private TextBox txt_SearchTenNV;
        private GroupBox groupBox3;
        private ComboBox cbb_SearchTT;
        private Button btn_Search;
        private Label label9;
        private Label label8;
        private Button btn_Them;
        private Button btn_Sua;
        private ComboBox cbb_ChucVu;
        private Label label3;
        private Button btn_Unlock;
    }
}