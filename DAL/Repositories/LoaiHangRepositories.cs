using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LoaiHangRepositories
    {
        Da1quanLyCuaHangContext _context;
        public LoaiHangRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<string> GetLoaiHangID()
        {
            return _context.LoaiSanPhams.Select(lh => lh.LoaiSanPhamId).ToList();
        }
        public List<LoaiSanPham> GetAll()
        {
            return _context.LoaiSanPhams.ToList();
        }

        public bool Create(LoaiSanPham loaiSanPham)
        {
            try
            {
                _context.LoaiSanPhams.Add(loaiSanPham);
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
                var deleteItem = _context.LoaiSanPhams.Find(id);
                _context.LoaiSanPhams.Remove(deleteItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(LoaiSanPham lsp, string id)
        {
            try
            {
                var updateItem = _context.LoaiSanPhams.Find(id);
                updateItem.TenLoai = lsp.TenLoai;
                updateItem.MoTa = lsp.MoTa;
                updateItem.TrangThai = lsp.TrangThai;
                _context.LoaiSanPhams.Update(updateItem);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
