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

        public bool Login(string username, string password)
        {
            // Thêm các logic nghiệp vụ nếu cần
            return _repos.ValidateUser(username, password);
        }

    }
}
