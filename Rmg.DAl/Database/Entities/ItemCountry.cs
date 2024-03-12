using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemCountry
{
    public Guid Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public string? OwnerCompany { get; set; }

    public int? OwnerPerson { get; set; }

    public DateTime? AvailableFrom { get; set; }

    public DateTime? AvailableUntil { get; set; }

    public string? AccountAltProfitLoss { get; set; }

    public string? AccountAltBalance { get; set; }

    public string? Glstock { get; set; }

    public string? Glrevenue { get; set; }

    public string? GlcostPrice { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
