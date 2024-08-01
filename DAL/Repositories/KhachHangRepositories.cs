using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhachHangRepositories
    {
        Da1quanLyCuaHangContext _context;
        public KhachHangRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<string> GetKhachHangNames()
        {
            return _context.KhachHangs.Select(kh => kh.KhachHangId).ToList();
        }
    }
}
