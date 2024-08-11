using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonRepositories
    {
        Da1quanLyCuaHangContext _context;
        public HoaDonRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<HoaDon> GetAll()
        {
            return _context.HoaDons.ToList();
        }
        public HoaDon Get(string ma)
        {
            return _context.HoaDons.Find(ma);
        }
        public bool Create(HoaDon hoaDon)
        {
            try
            {
                _context.HoaDons.Add(hoaDon);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdateHD(Guid id, byte statuc, decimal? totalMoney,string?httt,string magg)
        {
            try
            {
                var hd = _context.HoaDons.Find(id);
                hd.TrangThai = statuc;
                hd.HinhThucThanhToan = httt;
                hd.NgayLap = DateTime.Now;
                hd.GiamGiaId = magg;
                if (totalMoney != null)
                {
                    hd.TongTien = totalMoney;
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteHD(Guid id)
        {
            try
            {
                // Lấy danh sách chi tiết hóa đơn theo id của hóa đơn
                var allHDCT = _context.HoaDonChiTiets.Where(p => p.HoaDonID == id).ToList();

                // Hoàn trả lại số lượng sản phẩm đã mua
                foreach (var hdct in allHDCT)
                {
                    var product = _context.SanPhams.Find(hdct.SanPhamID);
                    if (product != null)
                    {
                        product.SoLuong += hdct.SoLuong;
                    }
                }

                // Tìm và cập nhật trạng thái của hóa đơn về 3 (Đã hủy)
                var hd = _context.HoaDons.Find(id);
                if (hd != null)
                {
                    hd.TrangThai = 3; // Chuyển trạng thái hóa đơn về 3 (Đã hủy)
                    _context.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateHDStatusIfExpired(Guid id)
        {
            try
            {
                // Tìm hóa đơn theo id
                var hd = _context.HoaDons.Find(id);
                if (hd != null && hd.TrangThai == 2)
                {
                    // Kiểm tra nếu hóa đơn đã quá 2 ngày từ ngày tạo
                    if (hd.NgayLap.AddDays(2) < DateTime.Now)
                    {
                        // Lấy danh sách chi tiết hóa đơn
                        var allHDCT = _context.HoaDonChiTiets.Where(p => p.HoaDonID == id).ToList();

                        // Hoàn trả lại số lượng sản phẩm đã mua
                        foreach (var hdct in allHDCT)
                        {
                            var product = _context.SanPhams.Find(hdct.SanPhamID);
                            if (product != null)
                            {
                                product.SoLuong += hdct.SoLuong;
                            }
                        }

                        // Chuyển trạng thái hóa đơn về 4 (Hết hạn)
                        hd.TrangThai = 4;
                        _context.SaveChanges();

                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}
