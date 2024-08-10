using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GiamGiaRepositories
    {
       
            Da1quanLyCuaHangContext _context;
            public GiamGiaRepositories()
            {
                _context = new Da1quanLyCuaHangContext();
            }
            public List<string> GetMaGiamGia()
            {
                return _context.GiamGia.Select(gg => gg.MaGiamGia).ToList();
            }


        public List<GiamGium> GetAll()
        {
            return _context.GiamGia.ToList();
        }
        public GiamGium Get(string ma)
        {
            return _context.GiamGia.Find(ma);
        }
        public bool Create(GiamGium gg)
        {
            try
            {
                _context.GiamGia.Add(gg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string ma)
        {
            try
            {
                var delete = _context.GiamGia.Find(ma); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                _context.GiamGia.Remove(delete);
                _context.SaveChanges(); // lưu lại db
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateSP(GiamGium gg, string ma) // Sản phẩm đc truyền vào thuộc tính mới
        {
            try
            {
                var updateItems = _context.GiamGia.Find(ma); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                updateItems.MaGiamGia = gg.MaGiamGia;
                updateItems.MoTa = gg.MoTa;
                updateItems.TienMin = gg.TienMin;
                updateItems.TienMax = gg.TienMax;
                updateItems.PhanTramGiam = gg.PhanTramGiam;
                updateItems.NgayBatDau = gg.NgayBatDau;
                updateItems.NgayKetThuc = gg.NgayKetThuc;
                updateItems.TrangThai = gg.TrangThai;
                _context.GiamGia.Update(updateItems);
                _context.SaveChanges(); // lưu lại db
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
