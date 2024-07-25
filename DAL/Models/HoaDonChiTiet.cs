using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public int HoaDonChiTietId { get; set; }

    public int? HoaDonId { get; set; }

    public int? SanPhamId { get; set; }

    public int? SoLuong { get; set; }

    public decimal? DonGia { get; set; }

    public virtual HoaDon? HoaDon { get; set; }

    public virtual SanPham? SanPham { get; set; }
}
