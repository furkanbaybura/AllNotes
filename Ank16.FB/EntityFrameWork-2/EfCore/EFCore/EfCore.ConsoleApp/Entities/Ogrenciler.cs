﻿using System;
using System.Collections.Generic;

namespace EfCore.ConsoleApp.Entities;

public partial class Ogrenciler
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? Adisoyadi { get; set; }
}
