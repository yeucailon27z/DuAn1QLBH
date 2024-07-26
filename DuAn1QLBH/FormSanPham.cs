using BUS.Servisces;
using DAL.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormSanPham : Form
    {
        SanPhamServisces _service; // Đảm bảo tên chính xác là "Services"

        public FormSanPham()
        {
            _service = new SanPhamServisces();
            InitializeComponent();
            // Đảm bảo tên chính xác là "Services"
        }

        private void ptb_SanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imgURL = dialog.FileName;
                    ptb_SanPham.Image = Image.FromFile(imgURL);
                    ptb_SanPham.ImageLocation = imgURL;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở hình ảnh: {ex.Message}");
                }
            }
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            ptb_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_Ma.Text;
                string ten = txt_Ten.Text;
                decimal gia = Convert.ToDecimal(txt_Gia.Text);
                int soluong = (int)nUD_SoLuong.Value;
                string mota = txt_Mota.Text;
                string loai = txt_Loai.Text;
                string ncc = txt_NCC.Text;
                DateOnly ngay = DateOnly.FromDateTime(dtp_Ngay.Value);
                string anh = ptb_SanPham.ImageLocation;
                byte trangthai = (byte)cbb_TrangThai.SelectedIndex;

                SanPham sp = new SanPham()
                {
                    SanPhamId = ma,
                    TenSanPham = ten,
                    Gia = gia,
                    SoLuong = soluong,
                    MoTa = mota,
                    LoaiSanPhamId = loai,
                    MaNhaCungCap = ncc,
                    NgayCapNhat = ngay,
                    Anh = anh,
                    TrangThai = trangthai
                };

                MessageBox.Show(_service.Create(sp));
                LoadData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
        }

        public void LoadData()
        {
            dgv_SanPham.Rows.Clear();
            dgv_SanPham.BorderStyle = BorderStyle.None;

            var allDatas = _service.GetALL();
            dgv_SanPham.ColumnCount = 11;
            dgv_SanPham.Columns[0].HeaderText = "STT";
            dgv_SanPham.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgv_SanPham.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgv_SanPham.Columns[3].HeaderText = "Mã Loại";
            dgv_SanPham.Columns[4].HeaderText = "Mã NCC";
            dgv_SanPham.Columns[5].HeaderText = "Giá";
            dgv_SanPham.Columns[6].HeaderText = "Số Lượng";
            dgv_SanPham.Columns[7].HeaderText = "Ảnh";
            dgv_SanPham.Columns[8].HeaderText = "Mô Tả";
            dgv_SanPham.Columns[9].HeaderText = "Ngày Cập Nhật";
            dgv_SanPham.Columns[10].HeaderText = "Trạng Thái";

            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                int rowIndex = dgv_SanPham.Rows.Add(i, data.SanPhamId, data.TenSanPham, data.LoaiSanPhamId, data.MaNhaCungCap, data.Gia, data.SoLuong, data.Anh, data.MoTa, data.NgayCapNhat, data.TrangThai);

                // Kiểm tra điều kiện và tô màu hàng
                if (data.SoLuong > 0 && data.SoLuong <= 20)
                {
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (data.SoLuong > 20 && data.SoLuong <= 40)
                {
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Orange;
                }
                else if (data.SoLuong > 40 && data.SoLuong <= 60)
                {
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (data.SoLuong > 60)
                {
                    dgv_SanPham.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }

        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_SanPham.Rows.Count)
            {
                DataGridViewRow row = dgv_SanPham.Rows[e.RowIndex];
                txt_Ma.Text = row.Cells[1].Value.ToString();
                txt_Ten.Text = row.Cells[2].Value.ToString();
                txt_Loai.Text = row.Cells[3].Value.ToString();
                txt_NCC.Text = row.Cells[4].Value.ToString();
                txt_Gia.Text = row.Cells[5].Value.ToString();
                nUD_SoLuong.Value = Convert.ToInt32(row.Cells[6].Value);

                string imagePath = row.Cells[7].Value.ToString();
                if (System.IO.File.Exists(imagePath))
                {
                    ptb_SanPham.ImageLocation = imagePath;
                }
                else
                {
                    ptb_SanPham.Image = null;
                }

                txt_Mota.Text = row.Cells[8].Value.ToString();
                dtp_Ngay.Value = DateTime.Parse(row.Cells[9].Value.ToString());
                cbb_TrangThai.SelectedIndex = Convert.ToByte(row.Cells[10].Value);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_Ma.Text;
                string ten = txt_Ten.Text;
                decimal gia = Convert.ToDecimal(txt_Gia.Text);
                int soluong = (int)nUD_SoLuong.Value;
                string mota = txt_Mota.Text;
                string loai = txt_Loai.Text;
                string ncc = txt_NCC.Text;
                DateOnly ngay = DateOnly.FromDateTime(dtp_Ngay.Value);
                string anh = ptb_SanPham.ImageLocation;
                byte trangthai = (byte)cbb_TrangThai.SelectedIndex;

                SanPham sp = new SanPham()
                {
                    SanPhamId = ma,
                    TenSanPham = ten,
                    Gia = gia,
                    SoLuong = soluong,
                    MoTa = mota,
                    LoaiSanPhamId = loai,
                    MaNhaCungCap = ncc,
                    NgayCapNhat = ngay,
                    Anh = anh,
                    TrangThai = trangthai
                };
                MessageBox.Show(_service.Updatee(sp, ma));
                LoadData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Dữ liệu đầu vào không hợp lệ: {ex.Message}");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_Loai.Text = "";
            txt_NCC.Text = "";
            txt_Gia.Text = "";
            nUD_SoLuong.Value = 0;
            ptb_SanPham.Image = null;
            txt_Mota.Text = "";
            dtp_Ngay.Value = DateTime.Now;
            cbb_TrangThai.SelectedIndex = 0;
        }

        private void dgv_SanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_SanPham.Columns[e.ColumnIndex].Name == "Số Lượng" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int soLuong))
                {
                    if (soLuong > 40 && soLuong < 50)
                    {
                        dgv_SanPham.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dgv_SanPham.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
