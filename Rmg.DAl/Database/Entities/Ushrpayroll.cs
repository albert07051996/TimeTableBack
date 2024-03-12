using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ushrpayroll
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

    public string? EmpType { get; set; }

    public DateTime? EmpTypeDate { get; set; }

    public string? Workshift { get; set; }

    public DateTime? AdjustedDate { get; set; }

    public string? TimeIndicator { get; set; }

    public string? FwtCalculation { get; set; }

    public string? FicaCode { get; set; }

    public string? FuiCode { get; set; }

    public string? OtherTax { get; set; }

    public string? MotorvehType { get; set; }

    public double InsuranceFaceValue { get; set; }

    public string? EicStatus { get; set; }

    public double EicCurrentAmount { get; set; }

    public string? SalaryIndicator { get; set; }

    public string? Marital { get; set; }

    public double Exempts { get; set; }

    public double Fwtextra { get; set; }

    public byte Statutory { get; set; }

    public byte RetirementPlan { get; set; }

    public byte SickPay { get; set; }

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
