using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    public class KhachHangServices
    {
        KhachHangRepositories _repos;
        public KhachHangServices()
        {
            _repos = new KhachHangRepositories();
        }
        public List<String> GetKhachHangNames()
        {
            return _repos.GetKhachHangNames();
        }
    }
}
