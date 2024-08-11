namespace PRL
{
    partial class FormLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiSP));
            groupBox3 = new GroupBox();
            cb_trangThai = new ComboBox();
            btn_Search = new Button();
            label9 = new Label();
            label8 = new Label();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            txt_TenloaiSearch = new TextBox();
            groupBox2 = new GroupBox();
            dgv_LoaiSP = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txt_Mota = new TextBox();
            txt_MaLoai = new TextBox();
            label3 = new Label();
            cbb_TrangThai = new ComboBox();
            txt_TenLoai = new TextBox();
            label7 = new Label();
            label14 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_LoaiSP).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cb_trangThai);
            groupBox3.Controls.Add(btn_Search);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btn_Them);
            groupBox3.Controls.Add(btn_Sua);
            groupBox3.Controls.Add(btn_Xoa);
            groupBox3.Controls.Add(txt_TenloaiSearch);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(73, 166);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1175, 94);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các chức năng";
            // 
            // cb_trangThai
            // 
            cb_trangThai.FormattingEnabled = true;
            cb_trangThai.Items.AddRange(new object[] { "Ngưng hoạt động", "Hoạt động" });
            cb_trangThai.Location = new Point(781, 45);
            cb_trangThai.Name = "cb_trangThai";
            cb_trangThai.Size = new Size(191, 29);
            cb_trangThai.TabIndex = 21;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.Yellow;
            btn_Search.Image = Properties.Resources.Search;
            btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Search.Location = new Point(1014, 32);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(140, 42);
            btn_Search.TabIndex = 20;
            btn_Search.Text = "Lọc";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(781, 24);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 18;
            label9.Text = "Trạng thái:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(559, 24);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 17;
            label8.Text = "Tên loại:";
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.Fuchsia;
            btn_Them.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Them.Image = Properties.Resources.Add;
            btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Them.Location = new Point(38, 32);
            btn_Them.Margin = new Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(140, 42);
            btn_Them.TabIndex = 13;
            btn_Them.Text = "Thêm ";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click_1;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.Fuchsia;
            btn_Sua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Sua.Image = Properties.Resources.Edit;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(210, 32);
            btn_Sua.Margin = new Padding(3, 2, 3, 2);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(140, 42);
            btn_Sua.TabIndex = 14;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click_1;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.Fuchsia;
            btn_Xoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Xoa.Image = Properties.Resources.reset;
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(386, 32);
            btn_Xoa.Margin = new Padding(3, 2, 3, 2);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(140, 42);
            btn_Xoa.TabIndex = 15;
            btn_Xoa.Text = "Làm mới";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click_1;
            // 
            // txt_TenloaiSearch
            // 
            txt_TenloaiSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_TenloaiSearch.Location = new Point(559, 47);
            txt_TenloaiSearch.Margin = new Padding(3, 2, 3, 2);
            txt_TenloaiSearch.Name = "txt_TenloaiSearch";
            txt_TenloaiSearch.PlaceholderText = "Tìm kiếm...";
            txt_TenloaiSearch.Size = new Size(206, 27);
            txt_TenloaiSearch.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_LoaiSP);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(581, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 423);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dgv_LoaiSP
            // 
            dgv_LoaiSP.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgv_LoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_LoaiSP.Location = new Point(6, 27);
            dgv_LoaiSP.Margin = new Padding(3, 2, 3, 2);
            dgv_LoaiSP.Name = "dgv_LoaiSP";
            dgv_LoaiSP.RowHeadersWidth = 51;
            dgv_LoaiSP.Size = new Size(651, 391);
            dgv_LoaiSP.TabIndex = 20;
            dgv_LoaiSP.CellClick += dgv_LoaiSP_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Mota);
            groupBox1.Controls.Add(txt_MaLoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbb_TrangThai);
            groupBox1.Controls.Add(txt_TenLoai);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label14);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(80, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 423);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông loại sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 201);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 29;
            label1.Text = "Mô tả:";
            // 
            // txt_Mota
            // 
            txt_Mota.Location = new Point(141, 164);
            txt_Mota.Multiline = true;
            txt_Mota.Name = "txt_Mota";
            txt_Mota.Size = new Size(289, 97);
            txt_Mota.TabIndex = 28;
            // 
            // txt_MaLoai
            // 
            txt_MaLoai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_MaLoai.Location = new Point(141, 69);
            txt_MaLoai.Name = "txt_MaLoai";
            txt_MaLoai.Size = new Size(289, 29);
            txt_MaLoai.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 69);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 26;
            label3.Text = "Mã loại:";
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Items.AddRange(new object[] { "Ngưng hoạt động", "Hoạt động" });
            cbb_TrangThai.Location = new Point(141, 285);
            cbb_TrangThai.Margin = new Padding(3, 2, 3, 2);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(289, 29);
            cbb_TrangThai.TabIndex = 25;
            // 
            // txt_TenLoai
            // 
            txt_TenLoai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_TenLoai.Location = new Point(141, 115);
            txt_TenLoai.Margin = new Padding(3, 2, 3, 2);
            txt_TenLoai.Name = "txt_TenLoai";
            txt_TenLoai.Size = new Size(289, 29);
            txt_TenLoai.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(30, 288);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 19;
            label7.Text = "Trạng thái:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(30, 115);
            label14.Name = "label14";
            label14.Size = new Size(69, 21);
            label14.TabIndex = 14;
            label14.Text = "Tên loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(449, 60);
            label2.Name = "label2";
            label2.Size = new Size(521, 54);
            label2.TabIndex = 27;
            label2.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FormLoaiSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 811);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormLoaiSP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLoaiSP";
            Load += FormLoaiSP_Load_1;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_LoaiSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button btn_Search;
        private Label label9;
        private Label label8;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private TextBox txt_TenloaiSearch;
        private GroupBox groupBox2;
        private DataGridView dgv_LoaiSP;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txt_Mota;
        private TextBox txt_MaLoai;
        private Label label3;
        private ComboBox cbb_TrangThai;
        private TextBox txt_TenLoai;
        private Label label7;
        private Label label14;
        private Label label2;
        private ComboBox cb_trangThai;
        private PictureBox pictureBox1;
    }
}