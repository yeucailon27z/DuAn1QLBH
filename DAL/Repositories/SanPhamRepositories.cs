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
        QuanLyCuaHangContext _qlCuahang;
        public SanPhamRepositories()
        {
            _qlCuahang = new QuanLyCuaHangContext();
        }
        public List<SanPham> GetAll()
        {
            return _qlCuahang.SanPhams.ToList();
        }
        public SanPham Get(int id)
        {
            return _qlCuahang.SanPhams.Find(id);
        }
        public bool Create(SanPham sp)
        {
            try
            {
                _qlCuahang.SanPhams.Add(sp);
                _qlCuahang.SaveChanges();
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
                var delete = _qlCuahang.SanPhams.Find(id); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                _qlCuahang.SanPhams.Remove(delete);
                _qlCuahang.SaveChanges(); // lưu lại db
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(SanPham sp, string id) // Sản phẩm đc truyền vào thuộc tính mới
        {
            try
            {
                var update = _qlCuahang.SanPhams.Find(id); // Phương Thức này tìm kiếm đối tượng theo khóa chính
                update = sp;
                _qlCuahang.SanPhams.Update(update);
                _qlCuahang.SaveChanges(); // lưu lại db
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
