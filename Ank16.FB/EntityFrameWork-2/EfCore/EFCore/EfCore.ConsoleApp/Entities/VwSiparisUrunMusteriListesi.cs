using System;
using System.Collections.Generic;

namespace EfCore.ConsoleApp.Entities;

public partial class VwSiparisUrunMusteriListesi
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? ProductUnitPrice { get; set; }

    public short Quantity { get; set; }

    public decimal OrderDetailPrice { get; set; }

    public float Discount { get; set; }

    public decimal? Freight { get; set; }

    public string CustomerId { get; set; } = null!;

    public string? ContactTitle { get; set; }

    public string? ContactName { get; set; }

    public DateTime? OrderDate { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ShipCity { get; set; }

    public string? ShipCountry { get; set; }
}
