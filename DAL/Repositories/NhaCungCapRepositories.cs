using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhaCungCapRepositories
    {

        Da1quanLyCuaHangContext _context;
        public NhaCungCapRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<NhaCungCap> GetAll()
        {
            return _context.NhaCungCaps.ToList();
        }
        public List<String> GetMaNCC()
        {
            return _context.NhaCungCaps.Select(c => c.MaNhaCungCap).ToList();
        }
        public NhaCungCap Get(string ma)
        {
            return _context.NhaCungCaps.Find(ma);
        }
        public bool Create(NhaCungCap ncc)
        {
            try
            {
                _context.NhaCungCaps.Add(ncc);
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
                var delete = _context.NhaCungCaps.Find(ma); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                _context.NhaCungCaps.Remove(delete);
                _context.SaveChanges(); // lưu lại db
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateSP(NhaCungCap ncc, string ma) // Sản phẩm đc truyền vào thuộc tính mới
        {
            try
            {
                var updateItems = _context.NhaCungCaps.Find(ma); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                updateItems.MaNhaCungCap = ncc.MaNhaCungCap;
                updateItems.TenNhaCungCap = ncc.TenNhaCungCap;
                updateItems.DiaChi = ncc.DiaChi;
                updateItems.SoDienThoai = ncc.SoDienThoai;
                updateItems.Email = ncc.Email;
                updateItems.TrangThai = ncc.TrangThai;
                _context.NhaCungCaps.Update(updateItems);
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
