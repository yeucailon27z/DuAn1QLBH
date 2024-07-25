using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhanVien
{
    public int NhanVienId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? HoTen { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
