using System;
using System.Collections.Generic;

namespace EfCore.ConsoleApp.Entities;

public partial class VwCategoryOnlyHasPicture
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }
}
