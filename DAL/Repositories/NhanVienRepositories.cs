using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanVienRepositories
    {
        Da1quanLyCuaHangContext context;
        public NhanVienRepositories()
        {
            context = new Da1quanLyCuaHangContext();
        }
        public bool ValidateUser(string username, string password)
        {
            return context.NhanViens.Any(u => u.Username == username && u.Password == password);
        }
    }
}
