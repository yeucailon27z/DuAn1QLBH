using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LoaiSanPham
{
    public string LoaiSanPhamId { get; set; } = null!;

    public string? TenLoai { get; set; }

    public string? MoTa { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
