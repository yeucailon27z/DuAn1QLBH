using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    public class NhanVienServices
    {
        NhanVienRepositories _repos;
        public NhanVienServices()
        {
            _repos = new NhanVienRepositories(); 
        }

        public string Login(string username, string password)
        {
            // Thêm các logic nghiệp vụ nếu cần
            return _repos.ValidateUser(username, password);
        }
        public string GetNVID(string? username, string? password)
        {
           
                return _repos.GetNhanVienId(username,password); 
        }
        public string GetNVName(string? username, string? password)
        {

            return _repos.GetNhanVienName(username, password);
        }
        public List<string> GetNhanVienId()
        {
            return _repos.GetNhanVienId();
        }

    }
}
