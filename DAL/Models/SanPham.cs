using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public int SanPhamId { get; set; }

    public string? TenSanPham { get; set; }

    public int? LoaiSanPhamId { get; set; }

    public int? MaNhaCungCap { get; set; }

    public decimal? Gia { get; set; }

    public int? SoLuong { get; set; }

    public string? Anh { get; set; }

    public string? Mota { get; set; }

    public DateOnly? NgayCapNhat { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual LoaiSanPham? LoaiSanPham { get; set; }

    public virtual NhaCungCap? MaNhaCungCapNavigation { get; set; }
}
