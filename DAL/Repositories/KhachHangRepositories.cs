using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhachHangRepositories
    {
        Da1quanLyCuaHangContext _context;
        public KhachHangRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<string> GetKhachHangNames()
        {
            return _context.KhachHangs.Select(kh => kh.KhachHangId).ToList();
        }
        public List<KhachHang> GetAll()
        {
            return _context.KhachHangs.ToList();
        }
        public KhachHang Get(string Id)
        {
            return _context.KhachHangs.Find(Id);
        }
        public bool Create(KhachHang kh)
        {
            try
            {
                _context.KhachHangs.Add(kh);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string Id)
        {
            try
            {
                var delete = _context.KhachHangs.Find(Id); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                _context.KhachHangs.Remove(delete);
                _context.SaveChanges(); // lưu lại db
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateSP(KhachHang kh, string Id) // Sản phẩm đc truyền vào thuộc tính mới
        {
            try
            {
                var updateItems = _context.KhachHangs.Find(Id); // Phương Thức này tìm kiếm đối tượng theo khóa chính

                updateItems.HoTen = kh.HoTen;
                updateItems.DiaChi = kh.DiaChi;
                updateItems.NgaySinh = kh.NgaySinh;
                updateItems.DienThoai = kh.DienThoai;
                updateItems.Email = kh.Email;
                updateItems.TrangThai = kh.TrangThai;
                _context.KhachHangs.Update(updateItems);
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
