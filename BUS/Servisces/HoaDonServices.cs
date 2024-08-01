using DAL.Models;
using DAL.Repositories;
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
        public HoaDonServices()
        {
            _repos = new HoaDonRepositories();
        }
        public List<HoaDon> GetALL()
        {
            return _repos.GetAll();
        }
        public string Creates(Guid idHD,string idNV, string idKH)
        {
            HoaDon hoaDon = new HoaDon()
            {
                HoaDonId = idHD,
                
                NhanVienId = idNV,KhachHangId = idKH,
                NgayLap = DateTime.Now,
                TongTien = 0,
                HinhThucThanhToan = "",
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
        public string Update(Guid idHD, byte trangthai, long? totolMoney)
        {
            if (_repos.UpdateHD(idHD, trangthai, totolMoney))
            {
                return "Cập nhật đơn hàng thành công";
            }
            else
            {
                return "Thất bại";
            }
        }
    }
}
