using BUS.Servisces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{

    public partial class FormDoanhThu : Form
    {
        DoanhThuServices _services;
        public FormDoanhThu()
        {
            _services = new DoanhThuServices();
            InitializeComponent();
            dtg_DoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dtg_DoanhThu.Rows.Clear();
            dtg_DoanhThu.BorderStyle = BorderStyle.None;

            var allDatas = _services.GetAll();
            dtg_DoanhThu.ColumnCount = 5;
            dtg_DoanhThu.Columns[0].HeaderText = "STT";
            dtg_DoanhThu.Columns[1].HeaderText = "Mã Doanh Thu";
            dtg_DoanhThu.Columns[2].HeaderText = "Thời Gian";
            dtg_DoanhThu.Columns[3].HeaderText = "Doanh Thu";
            dtg_DoanhThu.Columns[4].HeaderText = "Mã Hóa Đơn";
            int i = 0;
            foreach (var data in allDatas)
            {
                i++;
                dtg_DoanhThu.Rows.Add(i, data.DoanhThuId, data.Ngay, data.TongDoanhThu, data.HoaDonId);
            }
        }



        private void btn_Loc_Click(object sender, EventArgs e)
        {
            lbl_ngayHD.Text = dtp_Ngay.Value.ToString("MM/yyyy");
            lbl_dtNgay.Text = dtp_Ngay.Value.ToString("dd/MM/yyyy");
            lbl_dtThang.Text = dtp_Ngay.Value.ToString("MM/yyyy");
            lbl_dtNam.Text = dtp_Ngay.Value.Year.ToString();
            int month = dtp_Ngay.Value.Month;
            int year = dtp_Ngay.Value.Year;
            int day = dtp_Ngay.Value.Day;

            lbl_soHD.Text = _services.GetAll()
     .Where(p => p.Ngay.Value.Month == month && p.Ngay.Value.Year == year)
     .Count()
     .ToString();
            lbl_dtNgayValue.Text = _services.GetAll()
     .Where(p => p.Ngay.Value.Day == day)
     .Sum(p => p.TongDoanhThu)
     .ToString();
            lbl_dtThangValue.Text = _services.GetAll()
     .Where(p => p.Ngay.Value.Month == month)
     .Sum(p => p.TongDoanhThu)
     .ToString();
            lbl_dtNamValue.Text = _services.GetAll()
     .Where(p => p.Ngay.Value.Year == year)
     .Sum(p => p.TongDoanhThu)
     .ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị thời gian từ DateTimePicker
            DateOnly dateFirst = DateOnly.FromDateTime(dtp_search1.Value);
            DateOnly dateEnd = DateOnly.FromDateTime(dtp_search2.Value);

            // Lấy danh sách DoanhThu dựa trên khoảng thời gian tìm kiếm
            List<DoanhThu> allDT = _services.GetAll()
                .Where(p => p.Ngay >= dateFirst && p.Ngay <= dateEnd)
                .ToList();

            // Cấu hình lại các cột của DataGridView
            dtg_DoanhThu.ColumnCount = 5;
            dtg_DoanhThu.Columns[0].HeaderText = "STT";
            dtg_DoanhThu.Columns[1].HeaderText = "Mã Doanh Thu";
            dtg_DoanhThu.Columns[2].HeaderText = "Thời Gian";
            dtg_DoanhThu.Columns[3].HeaderText = "Doanh Thu";
            dtg_DoanhThu.Columns[4].HeaderText = "Mã Hóa Đơn";

            // Xóa tất cả các hàng hiện có để chuẩn bị cho dữ liệu mới
            dtg_DoanhThu.Rows.Clear();

            // Thêm dữ liệu mới vào DataGridView
            int i = 0;
            foreach (var data in allDT)
            {
                i++;
                dtg_DoanhThu.Rows.Add(
                    i,
                    data.DoanhThuId,
                    data.Ngay, // Ngày đã có định dạng phù hợp
                    data.TongDoanhThu,// Định dạng tiền tệ
                    data.HoaDonId
                );
            }

            // Hiển thị số lượng hóa đơn và tổng doanh thu
            lbl_searhsoHD.Text = allDT.Count.ToString();
            lbl_searchDT.Text = allDT.Sum(p => p.TongDoanhThu).ToString();


        }
    }
}
