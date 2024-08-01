using BUS.Servisces;
using DAL.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormSanPham : Form
    {
        LoaiHangServices _servicesLH;
        NhaCungCapServices _servicesNCC;
        SanPhamServisces _service;

        public FormSanPham()
        {
            _servicesLH = new LoaiHangServices();
            _servicesNCC = new NhaCungCapServices();
            _service = new SanPhamServisces();
            InitializeComponent();
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
            List<string> loaiHangName = _servicesLH.GetLoaiHangIDs();
            cbb_LoaiSP.DataSource = loaiHangName;

            List<string> NCCName = _servicesNCC.GetMaNCC();
            cbb_NCC.DataSource = NCCName;

            
            cbb_Loai.DataSource = loaiHangName;
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
                int soluong = Convert.ToInt32(txt_SoLuong.Text);
                string mota = txt_Mota.Text;
                string loai = cbb_LoaiSP.Text;
                string ncc = cbb_NCC.Text;
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
                cbb_LoaiSP.Text = row.Cells[3].Value.ToString();
                cbb_NCC.Text = row.Cells[4].Value.ToString();
                txt_Gia.Text = row.Cells[5].Value.ToString();
                txt_SoLuong.Text = row.Cells[6].Value.ToString();

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
                int soluong = Convert.ToInt32(txt_SoLuong.Text);
                string mota = txt_Mota.Text;
                string loai = cbb_LoaiSP.Text;
                string ncc = cbb_NCC.Text;
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
            cbb_LoaiSP.Text = "";
            cbb_NCC.Text = "";
            txt_Gia.Text = "";
            txt_SoLuong.Text = "";
            ptb_SanPham.Image = null;
            txt_Mota.Text = "";
            dtp_Ngay.Value = DateTime.Now;
            cbb_TrangThai.SelectedIndex = 0;
        }

        private void dgv_SanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView control
            dgv_SanPham.Rows.Clear();

            // Get the selected index of the combo box for TrangThai
            int trangthai = cbb_tt.SelectedIndex;

            // Get the search text, converted to lower case for case-insensitive comparison
            string ten = txt_Search.Text.ToLower();

            // Get the selected text from the combo box for Loai
            string loai = cbb_Loai.Text;

            // Retrieve and filter the data
            var searchResults = _service.GetALL()
                .Where(sp => (trangthai == -1 || sp.TrangThai == trangthai) &&
                             (string.IsNullOrEmpty(ten) || sp.TenSanPham.ToLower().Contains(ten)) &&
                             (string.IsNullOrEmpty(loai) || sp.LoaiSanPhamId==loai))
                .ToList();

            // Initialize a counter
            int i = 0;

            // Iterate through the filtered results and add them to the DataGridView
            foreach (var data in searchResults)
            {
                i++;
                dgv_SanPham.Rows.Add(i, data.SanPhamId, data.TenSanPham, data.LoaiSanPhamId, data.MaNhaCungCap, data.Gia, data.SoLuong, data.Anh, data.MoTa, data.NgayCapNhat, data.TrangThai);
            }

            cbb_Loai.Text = "";
            cbb_LoaiSP.Text = "";
            txt_Search.Text = "";
        }
    }
}
