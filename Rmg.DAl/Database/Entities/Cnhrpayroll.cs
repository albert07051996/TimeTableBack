using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Cnhrpayroll
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public short Contract { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Description { get; set; }

    public string? JobTitle { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public short? PayrollYear { get; set; }

    public int ResId { get; set; }

    public short Period { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Country { get; set; }

    public string? BaseValueMethod { get; set; }

    public double FixedValue { get; set; }

    public string? District { get; set; }

    public string? Sliptext1 { get; set; }

    public string? Sliptext2 { get; set; }

    public string? Sliptext3 { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
