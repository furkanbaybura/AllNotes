using System;
using System.Collections.Generic;

namespace DBFirstUygulama1.Models;

public partial class Arabalar
{
    public int Id { get; set; }

    public string? Marka { get; set; }

    public int? KisiId { get; set; }

    public virtual Kisiler? Kisi { get; set; }
}
