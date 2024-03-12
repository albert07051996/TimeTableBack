using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrcomponent
{
    public int Id { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Descr500 { get; set; }

    public string? Descr501 { get; set; }

    public string? Descr502 { get; set; }

    public string? Descr503 { get; set; }

    public string? Descr504 { get; set; }

    public string? Country { get; set; }

    public string? CompType { get; set; }

    public string? CompSubType { get; set; }

    public string? PaidBy { get; set; }

    public string? PaymentPeriod { get; set; }

    public double DefaultAmount { get; set; }

    public double DefaultPercentage { get; set; }

    public byte EditResourceLevel { get; set; }

    public string? CreditorAccount { get; set; }

    public string? CreditorCostcenter { get; set; }

    public string? CreditorCostunit { get; set; }

    public string? LedgerAccount { get; set; }

    public string? LedgerCostcenter { get; set; }

    public string? LedgerCostunit { get; set; }

    public string? Creditor { get; set; }

    public string? Bankaccount { get; set; }

    public byte Payroll { get; set; }

    public string? Currency { get; set; }

    public string? JobActivity { get; set; }

    public string? MainType { get; set; }

    public string? Scale { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public Guid? Notes { get; set; }

    public string? Unit { get; set; }

    public byte Blocked { get; set; }

    public string? CompVisible { get; set; }

    public string? CountryChar1 { get; set; }

    public string? CountryChar2 { get; set; }

    public string? CountryChar3 { get; set; }

    public string? CountryChar4 { get; set; }

    public string? CountryChar5 { get; set; }

    public string? CountryChar6 { get; set; }

    public string? CountryChar7 { get; set; }

    public string? CountryChar8 { get; set; }

    public string? CountryChar9 { get; set; }

    public byte CountryNy1 { get; set; }

    public byte CountryNy2 { get; set; }

    public byte CountryNy3 { get; set; }

    public byte CountryNy4 { get; set; }

    public byte CountryNy5 { get; set; }

    public byte CountryNy6 { get; set; }

    public byte CountryNy7 { get; set; }

    public byte CountryNy8 { get; set; }

    public byte CountryNy9 { get; set; }

    public byte CountryNy10 { get; set; }

    public byte CountryNy11 { get; set; }

    public byte CountryNy12 { get; set; }

    public byte CountryNy13 { get; set; }

    public byte CountryNy14 { get; set; }

    public byte CountryNy15 { get; set; }

    public byte CountryNy16 { get; set; }

    public byte CountryNy17 { get; set; }

    public byte CountryNy18 { get; set; }

    public double CountryFloat1 { get; set; }

    public double CountryFloat2 { get; set; }

    public double CountryFloat3 { get; set; }

    public double CountryFloat4 { get; set; }

    public double CountryFloat5 { get; set; }

    public double CountryFloat6 { get; set; }

    public string? CountryString1 { get; set; }

    public string? Formulafield { get; set; }

    public string? ParentCode { get; set; }

    public string? CompStatus { get; set; }

    public string? LedgerType { get; set; }

    public double CountryFloat7 { get; set; }

    public double CountryFloat8 { get; set; }

    public double CountryFloat9 { get; set; }

    public double CountryFloat10 { get; set; }

    public double CountryFloat11 { get; set; }

    public double CountryFloat12 { get; set; }

    public string? StateCode { get; set; }

    public string? LocalCode { get; set; }

    public Guid? Account { get; set; }

    public string Origin { get; set; } = null!;

    public short Age { get; set; }

    public Guid? CountryGuid1 { get; set; }

    public Guid? CountryGuid2 { get; set; }

    public string? OriginalCode { get; set; }

    public short? Division { get; set; }

    public string? CompanyCode { get; set; }

    public short Priority { get; set; }

    public double DefaultHourlyWage { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
