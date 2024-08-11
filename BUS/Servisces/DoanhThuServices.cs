using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    public class DoanhThuServices
    {
        DoanhThuRepositories _repos;
        public DoanhThuServices() {
            _repos = new DoanhThuRepositories();
        }
        public List<DoanhThu> GetAll()
        {
            return _repos.GetAll();
        }
        public string AddDoanhThu(Guid idhd, decimal gia)
        {
            if (_repos.AddDoanhThu(idhd, gia))
            {
                return "Thành công";
            }
            else
            {
                return "Thất bại";
            }
        }
    }
}
