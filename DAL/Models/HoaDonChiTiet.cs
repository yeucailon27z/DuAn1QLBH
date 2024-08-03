using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HoaDonChiTietID { get; set; }

    public Guid? HoaDonID { get; set; }
    public string? SanPhamID { get; set; }
    public int? SoLuong { get; set; }
    public decimal? DonGia { get; set; }

    public virtual HoaDon? HoaDon { get; set; }

    public virtual SanPham? SanPham { get; set; }
}
