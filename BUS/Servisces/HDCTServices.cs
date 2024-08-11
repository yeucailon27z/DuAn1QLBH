using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    
    public class HDCTServices
    {
        HDCTRepositories _repos;
        SanPhamRepositories _sprepos;
        public HDCTServices()
        {
            _repos = new HDCTRepositories();
            _sprepos = new SanPhamRepositories();
        }
        public List<HoaDonChiTiet> GetHDCTbyIDHD(Guid id)
        {
            return _repos.GetHDCTbyIDHD(id);
        }

        public string CheckSPinHD(string idsp, Guid idhd, int soluong)
        {
            var allhdct = _repos.GetHDCTbyIDHD(idhd);
            var hdct = allhdct.FirstOrDefault(p => p.SanPhamID == idsp);
            //return hdct != null;//nếu nó không null nghĩa là tồn tại rồi => true nếu chưa thí false
            if (hdct != null)
            {
                HDCTRepositories repos = new HDCTRepositories();
                repos.UpdateSL(soluong, hdct.HoaDonChiTietID);
                return "Thành công";
            }
            else
            {
                if (_repos.CreateHDCT(soluong, idhd, idsp))
                {
                    return "Thành công";
                }
                else
                {
                    return "Thất bại";
                }
            }

        }
        public decimal Caculator(Guid idHD)
        {
            List<HoaDonChiTiet> hdcts = _repos.GetHDCTbyIDHD(idHD);
            decimal sum = 0;
            foreach (var item in hdcts)
            {
                sum += (decimal)item.DonGia * (decimal)item.SoLuong;
            }
            return sum;
        }
        public List<HDCTViewModel> GetHDCTViewModel(Guid idhd)
        {
            var hdct = _repos.GetHDCTbyIDHD(idhd);
            var sp = _sprepos.GetAll();
            var hdctjoin = from p in hdct
                           join c in sp
                          on p.SanPhamID equals c.SanPhamId
                           select new HDCTViewModel
                           {
                               HoaDonChiTietID = p.HoaDonChiTietID,
                               HoaDonID = p.HoaDonID,
                               TenSanPham = c.TenSanPham,
                               SoLuong = p.SoLuong,
                               DonGia = p.DonGia*p.SoLuong,
                               SanPhamID = p.SanPhamID
                           };
            return hdctjoin.ToList();
        }
        public class HDCTViewModel()
        {
            public int HoaDonChiTietID { get; set; }

            public Guid? HoaDonID { get; set; }
            public string? TenSanPham { get; set; }
            public int? SoLuong { get; set; }
            public decimal? DonGia { get; set; }
            public string? SanPhamID { get; set; }
        }
    }
}
