using System;
using System.Collections.Generic;

namespace EfCore.ConsoleApp.Entities;

public partial class CloneCategory
{
    public int Id { get; set; }

    public string? KategoriAdi { get; set; }

    public string? Aciklama { get; set; }

    public byte[]? Resim { get; set; }
}
