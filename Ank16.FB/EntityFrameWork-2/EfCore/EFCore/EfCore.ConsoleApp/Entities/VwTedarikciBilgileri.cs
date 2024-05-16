using System;
using System.Collections.Generic;

namespace EfCore.ConsoleApp.Entities;

public partial class VwTedarikciBilgileri
{
    public int TedarikciId { get; set; }

    public string SirketAdi { get; set; } = null!;

    public string? KontakUnvani { get; set; }

    public string? KontakAdiSoyadi { get; set; }

    public string? SehirAdi { get; set; }

    public string? UlkeAdi { get; set; }
}
