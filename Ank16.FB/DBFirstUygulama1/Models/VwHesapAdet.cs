using System;
using System.Collections.Generic;

namespace DBFirstUygulama1.Models;

public partial class VwHesapAdet
{
    public decimal? Hesap { get; set; }

    public int EmployeeId { get; set; }

    public int? SatisAdet { get; set; }
}
