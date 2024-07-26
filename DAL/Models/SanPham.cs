







using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public string SanPhamId { get; set; } = null!;

    public string? TenSanPham { get; set; }

    public string? LoaiSanPhamId { get; set; }

    public string? MaNhaCungCap { get; set; }

    public decimal? Gia { get; set; }

    public int? SoLuong { get; set; }

    public string? Anh { get; set; }

    public string? MoTa { get; set; }

    public DateOnly? NgayCapNhat { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual LoaiSanPham? LoaiSanPham { get; set; }

    public virtual NhaCungCap? MaNhaCungCapNavigation { get; set; }
}
