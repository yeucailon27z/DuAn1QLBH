namespace DuAn1QLBH
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lbl_QuenMK = new LinkLabel();
            lblDangKi = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            chk_HienThiMk = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            btn_DangNhap = new Button();
            panel2 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_QuenMK);
            panel1.Controls.Add(lblDangKi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chk_HienThiMk);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(txt_Username);
            panel1.Controls.Add(btn_DangNhap);
            panel1.Location = new Point(159, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 310);
            panel1.TabIndex = 2;
            // 
            // lbl_QuenMK
            // 
            lbl_QuenMK.AutoSize = true;
            lbl_QuenMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_QuenMK.Location = new Point(102, 267);
            lbl_QuenMK.Name = "lbl_QuenMK";
            lbl_QuenMK.Size = new Size(124, 21);
            lbl_QuenMK.TabIndex = 7;
            lbl_QuenMK.TabStop = true;
            lbl_QuenMK.Text = "Quên mật khẩu?";
            // 
            // lblDangKi
            // 
            lblDangKi.AutoSize = true;
            lblDangKi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDangKi.Location = new Point(248, 243);
            lblDangKi.Name = "lblDangKi";
            lblDangKi.Size = new Size(64, 21);
            lblDangKi.TabIndex = 6;
            lblDangKi.TabStop = true;
            lblDangKi.Text = "Đăng Kí";
            lblDangKi.LinkClicked += lblDangKi_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 243);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
            label4.TabIndex = 5;
            label4.Text = "Bạn chưa có tài khoản?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(163, 215);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 4;
            label3.Text = "OR";
            // 
            // chk_HienThiMk
            // 
            chk_HienThiMk.AutoSize = true;
            chk_HienThiMk.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chk_HienThiMk.Location = new Point(37, 146);
            chk_HienThiMk.Name = "chk_HienThiMk";
            chk_HienThiMk.Size = new Size(127, 21);
            chk_HienThiMk.TabIndex = 3;
            chk_HienThiMk.Text = "Hiện thị mật khẩu";
            chk_HienThiMk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 84);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản:";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Password.Location = new Point(37, 107);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Password";
            txt_Password.Size = new Size(298, 33);
            txt_Password.TabIndex = 1;
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(37, 43);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "Username";
            txt_Username.Size = new Size(298, 33);
            txt_Username.TabIndex = 1;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.FromArgb(0, 192, 0);
            btn_DangNhap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangNhap.ForeColor = Color.White;
            btn_DangNhap.Location = new Point(102, 173);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(172, 39);
            btn_DangNhap.TabIndex = 0;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(159, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 53);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(95, 10);
            label5.Name = "label5";
            label5.Size = new Size(189, 37);
            label5.TabIndex = 0;
            label5.Text = "ĐĂNG NHẬP";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private LinkLabel lbl_QuenMK;
        private LinkLabel lblDangKi;
        private Label label4;
        private Label label3;
        private CheckBox chk_HienThiMk;
        private Label label2;
        private Label label1;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_DangNhap;
        private Panel panel2;
        private Label label5;
    }
}
