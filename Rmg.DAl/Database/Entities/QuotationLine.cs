using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class QuotationLine
{
    public long Id { get; set; }

    public int QuotationId { get; set; }

    public string ItemCode { get; set; } = null!;

    public double Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public double? DiscountPercentage { get; set; }

    public double AmountDc { get; set; }

    public double AmountFc { get; set; }

    public bool IsDeleted { get; set; }

    public string? PriceList { get; set; }

    public double SalesPrice { get; set; }

    public double OriginalTotalPrice { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
