namespace PRL
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            pictureBox1 = new PictureBox();
            mstr_Menu = new MenuStrip();
            tool_BanHang = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            nhàToolStripMenuItem = new ToolStripMenuItem();
            loạiHàngToolStripMenuItem = new ToolStripMenuItem();
            giảmGiáToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            pn_content = new Panel();
            pictureBox2 = new PictureBox();
            lb_Time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_TenNV = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mstr_Menu.SuspendLayout();
            pn_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Remove_bg1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // mstr_Menu
            // 
            mstr_Menu.BackColor = Color.FromArgb(200, 215, 50);
            mstr_Menu.Dock = DockStyle.Left;
            mstr_Menu.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mstr_Menu.GripStyle = ToolStripGripStyle.Visible;
            mstr_Menu.ImageScalingSize = new Size(20, 20);
            mstr_Menu.Items.AddRange(new ToolStripItem[] { tool_BanHang, sảnPhẩmToolStripMenuItem, hóaĐơnToolStripMenuItem, nhàToolStripMenuItem, loạiHàngToolStripMenuItem, giảmGiáToolStripMenuItem, kháchHàngToolStripMenuItem, doanhThuToolStripMenuItem, nhânViênToolStripMenuItem, thoátToolStripMenuItem });
            mstr_Menu.Location = new Point(0, 0);
            mstr_Menu.Name = "mstr_Menu";
            mstr_Menu.Padding = new Padding(6, 180, 0, 2);
            mstr_Menu.Size = new Size(246, 840);
            mstr_Menu.TabIndex = 2;
            mstr_Menu.Text = "menuStrip1";
            mstr_Menu.ItemClicked += mstr_Menu_ItemClicked;
            // 
            // tool_BanHang
            // 
            tool_BanHang.Image = (Image)resources.GetObject("tool_BanHang.Image");
            tool_BanHang.ImageAlign = ContentAlignment.MiddleLeft;
            tool_BanHang.ImageScaling = ToolStripItemImageScaling.None;
            tool_BanHang.Name = "tool_BanHang";
            tool_BanHang.Padding = new Padding(0, 9, 0, 9);
            tool_BanHang.Size = new Size(233, 65);
            tool_BanHang.Text = "Bán Hàng       ";
            tool_BanHang.Click += tool_BanHang_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Image = (Image)resources.GetObject("sảnPhẩmToolStripMenuItem.Image");
            sảnPhẩmToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            sảnPhẩmToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            sảnPhẩmToolStripMenuItem.Size = new Size(233, 62);
            sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm      ";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Image = (Image)resources.GetObject("hóaĐơnToolStripMenuItem.Image");
            hóaĐơnToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            hóaĐơnToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            hóaĐơnToolStripMenuItem.Size = new Size(233, 64);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn        ";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // nhàToolStripMenuItem
            // 
            nhàToolStripMenuItem.Image = (Image)resources.GetObject("nhàToolStripMenuItem.Image");
            nhàToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            nhàToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            nhàToolStripMenuItem.Name = "nhàToolStripMenuItem";
            nhàToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            nhàToolStripMenuItem.Size = new Size(233, 66);
            nhàToolStripMenuItem.Text = "Nhà Cung Cấp";
            nhàToolStripMenuItem.Click += nhàToolStripMenuItem_Click;
            // 
            // loạiHàngToolStripMenuItem
            // 
            loạiHàngToolStripMenuItem.Image = (Image)resources.GetObject("loạiHàngToolStripMenuItem.Image");
            loạiHàngToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            loạiHàngToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            loạiHàngToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            loạiHàngToolStripMenuItem.Size = new Size(233, 62);
            loạiHàngToolStripMenuItem.Text = "Loại Hàng      ";
            loạiHàngToolStripMenuItem.Click += loạiHàngToolStripMenuItem_Click;
            // 
            // giảmGiáToolStripMenuItem
            // 
            giảmGiáToolStripMenuItem.Image = (Image)resources.GetObject("giảmGiáToolStripMenuItem.Image");
            giảmGiáToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            giảmGiáToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            giảmGiáToolStripMenuItem.Name = "giảmGiáToolStripMenuItem";
            giảmGiáToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            giảmGiáToolStripMenuItem.Size = new Size(233, 62);
            giảmGiáToolStripMenuItem.Text = "Giảm Giá      ";
            giảmGiáToolStripMenuItem.Click += giảmGiáToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Image = (Image)resources.GetObject("kháchHàngToolStripMenuItem.Image");
            kháchHàngToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            kháchHàngToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            kháchHàngToolStripMenuItem.Size = new Size(233, 66);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Image = (Image)resources.GetObject("doanhThuToolStripMenuItem.Image");
            doanhThuToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            doanhThuToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            doanhThuToolStripMenuItem.Size = new Size(233, 62);
            doanhThuToolStripMenuItem.Text = "Doanh Thu";
            doanhThuToolStripMenuItem.Click += doanhThuToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Image = (Image)resources.GetObject("nhânViênToolStripMenuItem.Image");
            nhânViênToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            nhânViênToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            nhânViênToolStripMenuItem.Size = new Size(233, 72);
            nhânViênToolStripMenuItem.Text = "Nhân Viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = Properties.Resources.cancelpng;
            thoátToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            thoátToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Padding = new Padding(0, 9, 0, 9);
            thoátToolStripMenuItem.Size = new Size(233, 55);
            thoátToolStripMenuItem.Text = "  Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // pn_content
            // 
            pn_content.BackColor = Color.FromArgb(255, 224, 192);
            pn_content.Controls.Add(pictureBox2);
            pn_content.Location = new Point(243, 23);
            pn_content.Name = "pn_content";
            pn_content.Size = new Size(1361, 828);
            pn_content.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1350, 868);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lb_Time
            // 
            lb_Time.AutoSize = true;
            lb_Time.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lb_Time.Location = new Point(352, 1);
            lb_Time.Name = "lb_Time";
            lb_Time.Size = new Size(50, 21);
            lb_Time.TabIndex = 20;
            lb_Time.Text = "00:00";
            lb_Time.Click += lb_Time_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbl_TenNV
            // 
            lbl_TenNV.AutoSize = true;
            lbl_TenNV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_TenNV.LinkColor = Color.Black;
            lbl_TenNV.Location = new Point(1242, 0);
            lbl_TenNV.Name = "lbl_TenNV";
            lbl_TenNV.Size = new Size(22, 21);
            lbl_TenNV.TabIndex = 21;
            lbl_TenNV.TabStop = true;
            lbl_TenNV.Text = "...";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(1468, 1);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(83, 21);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng xuất";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1453, 0);
            label1.Name = "label1";
            label1.Size = new Size(14, 21);
            label1.TabIndex = 23;
            label1.Text = "|";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1167, 1);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 23;
            label2.Text = "Xin chào,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(265, 1);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 24;
            label3.Text = "Thời gian:";
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1584, 840);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(lbl_TenNV);
            Controls.Add(lb_Time);
            Controls.Add(pn_content);
            Controls.Add(pictureBox1);
            Controls.Add(mstr_Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mstr_Menu;
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTrangChu";
            Load += FormTrangChu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mstr_Menu.ResumeLayout(false);
            mstr_Menu.PerformLayout();
            pn_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip mstr_Menu;
        private ToolStripMenuItem tool_BanHang;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem nhàToolStripMenuItem;
        private ToolStripMenuItem loạiHàngToolStripMenuItem;
        private ToolStripMenuItem giảmGiáToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private Panel pn_content;
        private PictureBox pictureBox2;
        private Label lb_Time;
        private System.Windows.Forms.Timer timer1;
        private LinkLabel lbl_TenNV;
        private LinkLabel linkLabel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
    }
}