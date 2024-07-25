using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public int HoaDonId { get; set; }

    public DateOnly? NgayLap { get; set; }

    public int? KhachHangId { get; set; }

    public int? NhanVienId { get; set; }

    public int? GiamGiaId { get; set; }

    public string? HinhThucThanhToan { get; set; }

    public decimal? TongTien { get; set; }

    public byte? TrangThai { get; set; }

    public virtual GiamGium? GiamGia { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? KhachHang { get; set; }

    public virtual NhanVien? NhanVien { get; set; }
}
