using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SanPhamRepositories
    {
        Da1quanLyCuaHangContext _context;
        public SanPhamRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<SanPham> GetAll()
        {
            return _context.SanPhams.ToList();
        }
        public SanPham Get(int id)
        {
            return _context.SanPhams.Find(id);
        }
        public bool Create(SanPham sp)
        {
            try
            {
                _context.SanPhams.Add(sp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                var delete = _context.SanPhams.Find(id); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                _context.SanPhams.Remove(delete);
                _context.SaveChanges(); // lưu lại db
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateSP(SanPham sp, string id) // Sản phẩm đc truyền vào thuộc tính mới
        {
            try
            {
                var updateItems = _context.SanPhams.Find(id); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                updateItems.TenSanPham=sp.TenSanPham;
                updateItems.LoaiSanPhamId=sp.LoaiSanPhamId;
                updateItems.MaNhaCungCap = sp.MaNhaCungCap;
                updateItems.NgayCapNhat = sp.NgayCapNhat;
                updateItems.Anh = sp.Anh;
                updateItems.MoTa = sp.MoTa;
                updateItems.SoLuong = sp.SoLuong;
                updateItems.Gia = sp.Gia;
                updateItems.TrangThai = sp.TrangThai;
                _context.SanPhams.Update(updateItems);
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
