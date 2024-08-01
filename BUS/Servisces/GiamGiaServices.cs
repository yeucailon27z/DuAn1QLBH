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
    }
}
