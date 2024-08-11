using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{

    public class HoaDonServices
    {
        HoaDonRepositories _repos;
        NhanVienRepositories _NVrepos;
        KhachHangRepositories _KHrepos;
        GiamGiaRepositories _GGrepos;
        public HoaDonServices()
        {
            _KHrepos = new KhachHangRepositories();
            _NVrepos = new NhanVienRepositories();
            _repos = new HoaDonRepositories();
            _GGrepos = new GiamGiaRepositories();

        }
        public List<HoaDon> GetALL()
        {
            return _repos.GetAll();
        }
        public List<HoaDonViewModel> GetViewModel()
        {
            var hd = _repos.GetAll();
            var nv = _NVrepos.GetAccont();
            var kh = _KHrepos.GetAll();
            var gg = _GGrepos.GetAll();
            var query = from p in hd
                        join x in kh on p.KhachHangId equals x.KhachHangId

                        join z in nv on p.NhanVienId equals z.NhanVienId
                        join y in gg on p.GiamGiaId equals y.GiamGiaId
                        select new HoaDonViewModel
                        {
                            HoaDonId = p.HoaDonId,
                            NgayLap = p.NgayLap,
                            TenKhachHang = x.HoTen,
                            TenNhanVien = z.HoTen,
                            GiamGiaId = p.GiamGiaId,
                            MaGiamGia = y.MaGiamGia,// Nếu có thuộc tính này trong HoaDon
                            HinhThucThanhToan = p.HinhThucThanhToan, // Nếu có thuộc tính này trong HoaDon
                            TongTien = p.TongTien, // Nếu có thuộc tính này trong HoaDon
                            TrangThai = p.TrangThai,
                            KhachHangId = p.KhachHangId,
                            NhanVienId = p.NhanVienId
                        };

            return query.ToList();
        }
        public string Creates(Guid idHD, string idNV, string idKH)
        {
            HoaDon hoaDon = new HoaDon()
            {
                HoaDonId = idHD,
                NhanVienId = idNV,
                KhachHangId = idKH,
                NgayLap = DateTime.Now,
                TongTien = 0,
                TrangThai = 1
            };
            if (_repos.Create(hoaDon))
            {
                return "Tạo thành công";
            }
            else
            {
                return "Tạo thất bại";
            };
        }
        public List<HoaDon> GetAllnotPaid()
        {
            return _repos.GetAll().Where(p => p.TrangThai == 1).ToList();


        }
        public string Update(Guid idHD, byte trangthai, decimal? totolMoney, string? httt, string magg)
        {
            if (_repos.UpdateHD(idHD, trangthai, totolMoney, httt, magg))
            {
                return "Cập nhật đơn hàng thành công";
            }
            else
            {
                return "Thất bại";
            }
        }
        public string DeleteHD(Guid id)
        {
            if (_repos.DeleteHD(id))
            {
                return "Hủy hóa đơn thành công";
            }
            else
            {
                return "Hủy hóa đơn thất bại";
            }
        }
        public class HoaDonViewModel()
        {
            public Guid HoaDonId { get; set; }

            public DateTime NgayLap { get; set; }

            public string? TenKhachHang { get; set; }

            public string? TenNhanVien { get; set; }

            public string? MaGiamGia { get; set; }

            public string? HinhThucThanhToan { get; set; }

            public decimal? TongTien { get; set; }

            public byte? TrangThai { get; set; }
            public string? GiamGiaId { get; set; }
            public string? KhachHangId { get; set; }

            public string? NhanVienId { get; set; }

        }
    }
}
