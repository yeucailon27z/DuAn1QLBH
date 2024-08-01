using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    public class NhaCungCapServices
    {
        NhaCungCapRepositories _Repo;
        public NhaCungCapServices()
        {
            _Repo = new NhaCungCapRepositories();
        }
        public List<NhaCungCap> GetALL()
        {
            return _Repo.GetAll();
        }
        public string Create(NhaCungCap ncc)
        {
            if (_Repo.Create(ncc))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public List<string> GetMaNCC()
        {
            return _Repo.GetMaNCC();
        }
        public string Delete(string ma)
        {
            if (_Repo.Delete(ma))
            {
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Thất Bại";
            }
        }
        public string Updatee(NhaCungCap ncc, string ma)
        {
            if (_Repo.UpdateSP(ncc, ma))
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
