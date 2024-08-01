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
            groupBox3 = new GroupBox();
            button4 = new Button();
            label9 = new Label();
            label8 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
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
            cb_trangThai = new ComboBox();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_LoaiSP).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cb_trangThai);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(txt_TenloaiSearch);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(73, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1175, 94);
            groupBox3.TabIndex = 26;
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
            button4.Size = new Size(140, 42);
            button4.TabIndex = 20;
            button4.Text = "Lọc";
            button4.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(781, 24);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 18;
            label9.Text = "Mã loại:";
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
            // button5
            // 
            button5.BackColor = Color.Fuchsia;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button5.Image = Properties.Resources.Add;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(38, 32);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(140, 42);
            button5.TabIndex = 13;
            button5.Text = "Thêm ";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Fuchsia;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button6.Image = Properties.Resources.Edit;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(210, 32);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(140, 42);
            button6.TabIndex = 14;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Fuchsia;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button7.Image = Properties.Resources.Delete;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(386, 32);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(140, 42);
            button7.TabIndex = 15;
            button7.Text = "Xóa";
            button7.UseVisualStyleBackColor = false;
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
            groupBox2.Location = new Point(581, 244);
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
            groupBox1.Location = new Point(80, 244);
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
            label2.Location = new Point(355, 60);
            label2.Name = "label2";
            label2.Size = new Size(521, 54);
            label2.TabIndex = 27;
            label2.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // cb_trangThai
            // 
            cb_trangThai.FormattingEnabled = true;
            cb_trangThai.Location = new Point(781, 45);
            cb_trangThai.Name = "cb_trangThai";
            cb_trangThai.Size = new Size(191, 29);
            cb_trangThai.TabIndex = 21;
            // 
            // FormLoaiSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 811);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button button4;
        private Label label9;
        private Label label8;
        private Button button5;
        private Button button6;
        private Button button7;
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
    }
}