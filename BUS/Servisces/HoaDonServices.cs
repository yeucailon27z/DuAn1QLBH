using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    
    public class HoaDonServices
    {
        HoaDonRepositories _repos;
        public HoaDonServices()
        {
            _repos = new HoaDonRepositories();
        }
        public List<HoaDon> GetALL()
        {
            return _repos.GetAll();
        }
    }
}
