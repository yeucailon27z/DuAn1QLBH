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
            return context.NhanViens.Select(kh => kh.NhanVienId).ToList();
        }


        public String ValidateUser(string username, string password)
        {
            try
            {
                var check = context.NhanViens.Where(p=>p.TrangThai==0).SingleOrDefault(p => p.Username == username && p.Password == password);
                if (check != null)
                {
                    return check.ChucVu + ":" + check.HoTen;
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
        public List<NhanVien> GetAccont()
        {
            return context.NhanViens.ToList();
        }
        public string LockAccount(string idnv)
        {
            var account = context.NhanViens.Find(idnv);
            if (account.ChucVu == 0)
            {
                return "Không Thể Xóa Tài Khoản ADMIN";
            }
            else if (account.TrangThai == 1)
            {
                return "Tài Khoản Đã Bị Khóa , Không Thể Khóa Thêm";
            }
            account.TrangThai = 1;
            try
            {
                context.NhanViens.Update(account);
                context.SaveChanges();
                return "Đã Khóa Tài Khoản " + account.Username;

            }
            catch (Exception e)
            {
                return "Khóa Thất Bại " + e.Message;
            }
        }
        public string Unlock(string idnv)
        {
            var account = context.NhanViens.Find(idnv);
            if (account.TrangThai != 1)
            {
                return "Không Thể Mở Khóa Tài Khoản Không Bị Khóa";
            }
            account.TrangThai = 0;
            try
            {
                context.NhanViens.Update(account);
                context.SaveChanges();
                return "Đã Mở Khóa Tài Khoản " + account.Username;
            }
            catch (Exception e)
            {
                return "Mở Khóa Thất Bại " + e.Message;
            }
        }
        public string CreateAcc(NhanVien nv)
        {
            var account = context.NhanViens.Find(nv.NhanVienId);
            var username = context.NhanViens.FirstOrDefault(p=>p.Username == nv.Username);
            if(account != null)
            {
                return "Không được tạo ID nhân viên trùng lặp";
            }else if (username != null)
            {
                return "Không được tạo trùng tài khoản";
            }
            else { 
            try
            {
             context.NhanViens.Add(nv);
            context.SaveChanges();
                return "Thêm thành công";
            }
            catch (Exception)
            {
                return "Thêm thất bại";
            } }
           
         
        } 
        public string updateAcc(NhanVien nv, string idnv)
        {
            var account = context.NhanViens.Find(idnv);
            if (account == null)
            {
                return "Không tìm thấy tài khoản cần sửa";
            }
            else
            {
                try
                {
                    account.Username=nv.Username;
                    account.Password = nv.Password;
                    account.HoTen = nv.HoTen;
                    account.DienThoai = nv.DienThoai;
                    account.ChucVu = nv.ChucVu;
                    account.TrangThai = nv.TrangThai;
                    context.NhanViens.Update(account);
                    context.SaveChanges();
                    return "Sửa Thành Công";
                }
                catch (Exception e)
                {
                    return "Sửa Thất Bại" + e.Message;
                }
            }

        }
    }
}
