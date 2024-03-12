using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrcompResource
{
    public int Id { get; set; }

    public int ResId { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? DeviatingDescr50 { get; set; }

    public string? PaidBy { get; set; }

    public double Amount { get; set; }

    public double Percentage { get; set; }

    public double NumberDaysPeriod { get; set; }

    public double Number { get; set; }

    public double Hourlywage { get; set; }

    public string? CreditorAccount { get; set; }

    public string? CreditorCostcenter { get; set; }

    public string? CreditorCostunit { get; set; }

    public string? LedgerAccount { get; set; }

    public string? LedgerCostcenter { get; set; }

    public string? LedgerCostunit { get; set; }

    public string? Creditor { get; set; }

    public string? Bankaccount { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public Guid? Notes { get; set; }

    public string? StateCode { get; set; }

    public string? LocalCode { get; set; }

    public short Priority { get; set; }

    public string? ReferenceNr1 { get; set; }

    public string? ReferenceNr2 { get; set; }

    public string? CompanyCode { get; set; }

    public double CountryFloat1 { get; set; }

    public double CountryFloat2 { get; set; }

    public double CountryFloat3 { get; set; }

    public double CountryFloat4 { get; set; }

    public double CountryFloat5 { get; set; }

    public string? CountryChar1 { get; set; }

    public string? CountryChar2 { get; set; }

    public string? CountryChar3 { get; set; }

    public byte CountryNy1 { get; set; }

    public byte CountryNy2 { get; set; }

    public byte CountryNy3 { get; set; }

    public DateTime? CountryDate1 { get; set; }

    public DateTime? CountryDate2 { get; set; }

    public string? JobTitle { get; set; }

    public string? Scale { get; set; }

    public string? Project { get; set; }

    public string? ReferenceCode { get; set; }

    public Guid ComponentGuid { get; set; }

    public short Contract { get; set; }

    public string? SalaryScale { get; set; }

    public string? Currency { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
