using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    public class SanPhamServisces
    {
        SanPhamRepositories _Repo;
        public SanPhamServisces()
        {
            _Repo = new SanPhamRepositories();
        }
        public List<SanPham> GetALL()
        {
            return _Repo.GetAll();
        }
        public string Create(SanPham sp)
        {
            if (_Repo.Create(sp))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Delete(string id)
        {
            if (_Repo.Delete(id))
            {
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Thất Bại";
            }
        }
        public string Updatee(SanPham sp, string id)
        {
            if (_Repo.Update(sp, id))
            {
                return "Sửa Thành Công";
            }
            else
            {
                return "Sửa Thất Bại";
            }
        }
    }
}
