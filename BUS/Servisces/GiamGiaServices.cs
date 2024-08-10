using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    public class GiamGiaServices
    {
        GiamGiaRepositories _repos;
        public GiamGiaServices()
        {
            _repos = new GiamGiaRepositories();
        }
        public List<string> GetMaGG()
        {
            return _repos.GetMaGiamGia();
        }
        public List<GiamGium> GetAll()
        {
            return _repos.GetAll();
        }
        public string Create(GiamGium gg)
        {
            if (_repos.Create(gg))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Delete(string gg)
        {
            if (_repos.Delete(gg))
            {
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Thất Bại";
            }
        }
        public string UpdateGG(GiamGium gg, string ma)
        {
            if (_repos.UpdateSP(gg, ma))
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
