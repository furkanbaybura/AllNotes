using System;
using System.Collections.Generic;

namespace EfCore.ConsoleApp.Entities;

public partial class Ogrencidersleri
{
    public int? OgrenciId { get; set; }

    public int? DersId { get; set; }

    public virtual Dersler? Ders { get; set; }

    public virtual Ogrenciler? Ogrenci { get; set; }
}
