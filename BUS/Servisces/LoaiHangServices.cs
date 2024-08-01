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
    public class LoaiHangServices
    {
        LoaiHangRepositories _repos;
        public LoaiHangServices()
        {
            _repos = new LoaiHangRepositories();
        }
        public List<string> GetLoaiHangIDs()
        {
            return _repos.GetLoaiHangID();
        }
        public List<LoaiSanPham> GetAll()
        {
            return _repos.GetAll();
        }
        public string CreateLoaiSP(LoaiSanPham loaiSanPham)
        {
            if (_repos.Create(loaiSanPham))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string DeleteLoaiSP(string id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }
        public string UpdateLoaiSP(LoaiSanPham loaiSanPham, string id)
        {
            if (_repos.Update(loaiSanPham, id))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

    }
}
