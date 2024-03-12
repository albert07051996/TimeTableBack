using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemDivisionAssortment
{
    public int Id { get; set; }

    public string DivisionCode { get; set; } = null!;

    public int Assortment { get; set; }

    public string? GlaccountAsset { get; set; }

    public string? GlaccountCost { get; set; }

    public string? GlaccountDiscount { get; set; }

    public string? GlaccountDistribution { get; set; }

    public string? Glrevenue { get; set; }

    public string? GlaccountStkChange { get; set; }

    public string? GlaccountStkCoverage { get; set; }

    public string? GlaccountPriceDifferences { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
