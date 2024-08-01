using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GiamGiaRepositories
    {
       
            Da1quanLyCuaHangContext _context;
            public GiamGiaRepositories()
            {
                _context = new Da1quanLyCuaHangContext();
            }
            public List<string> GetMaGiamGia()
            {
                return _context.GiamGia.Select(gg => gg.MaGiamGia).ToList();
            }
       
    }
}
