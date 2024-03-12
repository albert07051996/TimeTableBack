using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Aehrpayroll
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public short Contract { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Description { get; set; }

    public string? JobTitle { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public short? Payrollyear { get; set; }

    public int ResId { get; set; }

    public short Period { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Country { get; set; }

    public string? ResidentStatus { get; set; }

    public string? Sliptext1 { get; set; }

    public string? Sliptext2 { get; set; }

    public string? Sliptext3 { get; set; }

    public byte Contractterminated { get; set; }

    public string? UnpaidLeave { get; set; }

    public string? Check { get; set; }

    public string? RatioAmount { get; set; }

    public double Percentage { get; set; }

    public double Amount { get; set; }

    public byte IncludeContribution { get; set; }

    public byte PaymentVacation { get; set; }

    public double Ges { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
