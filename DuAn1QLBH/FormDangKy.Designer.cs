namespace PRL
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(741, 501);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(173, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 53);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 8);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 0;
            label1.Text = "Đăng Ký";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(173, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 387);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(102, 346);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 8;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 294);
            label8.Name = "label8";
            label8.Size = new Size(40, 17);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 247);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 7;
            label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 200);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 7;
            label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 153);
            label5.Name = "label5";
            label5.Size = new Size(88, 17);
            label5.TabIndex = 7;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 106);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 7;
            label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 59);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 12);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 7;
            label2.Text = "Tài khoản:";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 11.25F);
            textBox7.Location = new Point(40, 267);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(289, 27);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11.25F);
            textBox6.Location = new Point(40, 314);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(289, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11.25F);
            textBox5.Location = new Point(40, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(289, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11.25F);
            textBox4.Location = new Point(40, 173);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(289, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F);
            textBox3.Location = new Point(40, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F);
            textBox2.Location = new Point(40, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F);
            textBox1.Location = new Point(40, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 0;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 502);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}