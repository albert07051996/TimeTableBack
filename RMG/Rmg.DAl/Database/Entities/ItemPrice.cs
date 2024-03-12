using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemPrice
{
    public Guid Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? CountryCode { get; set; }

    public DateTime ValidFrom { get; set; }

    public int Quantity { get; set; }

    public bool DefaultPrice { get; set; }

    public string? Description { get; set; }

    public string? SalesCurrency { get; set; }

    public double SalesPrice { get; set; }

    public double SalesPriceTotal { get; set; }

    public double SalesVatperc { get; set; }

    public bool SalesVatincl { get; set; }

    public double SalesMarginPerc { get; set; }

    public double SalesMarginDefaultPerc { get; set; }

    public short? Division { get; set; }

    public string? PriceFrequency { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
