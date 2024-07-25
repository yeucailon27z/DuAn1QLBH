using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GiamGium
{
    public int GiamGiaId { get; set; }

    public string? MaGiamGia { get; set; }

    public string? MoTa { get; set; }

    public decimal? PhanTramGiam { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
