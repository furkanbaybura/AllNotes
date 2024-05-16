using System;
using System.Collections.Generic;

namespace EfCore.ConsoleApp.Entities;

public partial class Tablo2
{
    public int Id { get; set; }

    public string? Aciklama { get; set; }

    public string? Bilgi { get; set; }
}
