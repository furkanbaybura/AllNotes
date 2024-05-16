using System;
using System.Collections.Generic;

namespace DBFirstUygulama1.Models;

public partial class Kisiler
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public virtual ICollection<Arabalar> Arabalars { get; set; } = new List<Arabalar>();
}
