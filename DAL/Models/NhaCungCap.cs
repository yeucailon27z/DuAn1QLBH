using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhaCungCap
{
    public int MaNhaCungCap { get; set; }

    public string TenNhaCungCap { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
