using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servisces
{
    
    public class HDCTServices
    {
        HDCTRepositories _repos;
        public HDCTServices()
        {
            _repos = new HDCTRepositories();
        }
        public List<HoaDonChiTiet> GetHDCTbyIDHD(Guid id)
        {
            return _repos.GetHDCTbyIDHD(id);
        }

        public string CheckSPinHD(string idsp, Guid idhd, int soluong)
        {
            var allhdct = _repos.GetHDCTbyIDHD(idhd);
            var hdct = allhdct.FirstOrDefault(p => p.SanPhamID == idsp);
            //return hdct != null;//nếu nó không null nghĩa là tồn tại rồi => true nếu chưa thí false
            if (hdct != null)
            {
                HDCTRepositories repos = new HDCTRepositories();
                repos.UpdateSL(soluong, hdct.HoaDonChiTietID);
                return "Thành công";
            }
            else
            {
                if (_repos.CreateHDCT(soluong, idhd, idsp))
                {
                    return "Thành công";
                }
                else
                {
                    return "Thất bại";
                }
            }

        }
        public long Caculator(Guid idHD)
        {
            List<HoaDonChiTiet> hdcts = _repos.GetHDCTbyIDHD(idHD);
            long sum = 0;
            foreach (var item in hdcts)
            {
                sum += (long)item.DonGia * (long)item.SoLuong;
            }
            return sum;
        }
    }
}
