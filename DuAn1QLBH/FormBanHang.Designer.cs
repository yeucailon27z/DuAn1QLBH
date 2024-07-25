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
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            groupBox3 = new GroupBox();
            lbl_ttsp = new Label();
            label13 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            lbl_tthd = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            groupBox4 = new GroupBox();
            button6 = new Button();
            label12 = new Label();
            label11 = new Label();
            comboBox3 = new ComboBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label3.Location = new Point(361, 785);
            label3.Name = "label3";
            label3.Size = new Size(43, 22);
            label3.TabIndex = 6;
            label3.Text = "<<<";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label2.Location = new Point(492, 785);
            label2.Name = "label2";
            label2.Size = new Size(43, 22);
            label2.TabIndex = 5;
            label2.Text = ">>>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 781);
            label1.Name = "label1";
            label1.Size = new Size(21, 24);
            label1.TabIndex = 4;
            label1.Text = "1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(884, 12);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(438, 255);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn chờ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.Location = new Point(266, 23);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(165, 29);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(160, 25);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 2;
            label4.Text = "Mã hóa đơn:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(23, 22);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 32);
            button1.TabIndex = 1;
            button1.Text = "Tạo hóa đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 182);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
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
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(8, 26);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(422, 190);
            dataGridView2.TabIndex = 0;
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
            groupBox3.Controls.Add(lbl_ttsp);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(lbl_tthd);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(887, 504);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(435, 291);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tổng hợp";
            // 
            // lbl_ttsp
            // 
            lbl_ttsp.AutoSize = true;
            lbl_ttsp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ttsp.Location = new Point(243, 22);
            lbl_ttsp.Name = "lbl_ttsp";
            lbl_ttsp.Size = new Size(32, 25);
            lbl_ttsp.TabIndex = 34;
            lbl_ttsp.Text = "....";
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
            button5.Location = new Point(293, 249);
            button5.Name = "button5";
            button5.Size = new Size(135, 36);
            button5.TabIndex = 32;
            button5.Text = "Thanh toán";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(8, 249);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(135, 36);
            button4.TabIndex = 31;
            button4.Text = "Hủy";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(149, 249);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(135, 36);
            button3.TabIndex = 30;
            button3.Text = "Tách hóa đơn";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox3.Location = new Point(131, 213);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 29);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.Location = new Point(131, 172);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 29);
            textBox2.TabIndex = 28;
            // 
            // lbl_tthd
            // 
            lbl_tthd.AutoSize = true;
            lbl_tthd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tthd.Location = new Point(243, 134);
            lbl_tthd.Name = "lbl_tthd";
            lbl_tthd.Size = new Size(32, 25);
            lbl_tthd.TabIndex = 27;
            lbl_tthd.Text = "....";
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
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(129, 97);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(298, 29);
            comboBox2.TabIndex = 20;
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 57);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 29);
            comboBox1.TabIndex = 22;
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
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(7, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(871, 88);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Location = new Point(737, 33);
            button6.Name = "button6";
            button6.Size = new Size(116, 31);
            button6.TabIndex = 4;
            button6.Text = "Tìm kiếm";
            button6.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(474, 39);
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(549, 36);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(169, 29);
            comboBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 33);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(325, 29);
            textBox4.TabIndex = 0;
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
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBanHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button button2;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lbl_tthd;
        private Label label10;
        private Label label9;
        private Label label7;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private GroupBox groupBox4;
        private Button button6;
        private Label label12;
        private Label label11;
        private ComboBox comboBox3;
        private TextBox textBox4;
        private Label lbl_ttsp;
        private Label label13;
    }
}