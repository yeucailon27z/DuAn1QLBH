using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DoanhThu
{
    public int DoanhThuId { get; set; }

    public DateOnly? Ngay { get; set; }

    public decimal? TongDoanhThu { get; set; }
}
