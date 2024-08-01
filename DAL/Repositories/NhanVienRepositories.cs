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
        public string? GetNhanVienId(string? username, string? password)
        {
            return context.NhanViens
                          .Where(p => p.Username == username && p.Password == password)
                          .Select(kh => kh.NhanVienId)
                          .FirstOrDefault();
        }
        public string? GetNhanVienName(string? username, string? password)
        {
            return context.NhanViens
                          .Where(p => p.Username == username && p.Password == password)
                          .Select(kh => kh.HoTen)
                          .FirstOrDefault();
        }
        public List<string> GetNhanVienId()
        {
            return context.NhanViens.Select(kh=>kh.NhanVienId).ToList();
        }


        public String ValidateUser(string username, string password)
        {
            try
            {
                   var check = context.NhanViens.SingleOrDefault(p=> p.Username == username&& p.Password==password);
                if (check != null) {
                    return check.NhanVienId.ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {

                return "1";
            }
        }
    }
}
