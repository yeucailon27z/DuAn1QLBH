using DAL.Models;
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
        public List<KhachHang> GetALL()
        {
            return _repos.GetAll();
        }
        public string Create(KhachHang kh)
        {
            if (_repos.Create(kh))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string Delete(string id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Thất Bại";
            }
        }
        public string Updatee(KhachHang kh, string id)
        {
            if (_repos.UpdateSP(kh, id))
            {
                return "Sửa Thành Công";
            }
            else
            {
                return "Sửa Thất Bại";
            }
        }
    }
}
