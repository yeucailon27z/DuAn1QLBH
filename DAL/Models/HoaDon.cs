using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public Guid HoaDonId { get; set; }

    public DateTime NgayLap { get; set; }

    public string? KhachHangId { get; set; }

    public string? NhanVienId { get; set; }

    public string? GiamGiaId { get; set; }

    public string? HinhThucThanhToan { get; set; }

    public decimal? TongTien { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<DoanhThu> DoanhThus { get; set; } = new List<DoanhThu>();

    public virtual GiamGium? GiamGia { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? KhachHang { get; set; }

    public virtual NhanVien? NhanVien { get; set; }
}
