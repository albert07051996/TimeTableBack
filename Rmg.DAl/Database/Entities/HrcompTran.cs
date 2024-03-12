using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrcompTran
{
    public int Id { get; set; }

    public short? PayrollYear { get; set; }

    public int ResId { get; set; }

    public short Period { get; set; }

    public short RunNumber { get; set; }

    public DateTime Calculationdate { get; set; }

    public string CompCode { get; set; } = null!;

    public string? Country { get; set; }

    public string? Currency { get; set; }

    public string? CompType { get; set; }

    public string? CompSubType { get; set; }

    public string? Status { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Entryorigin { get; set; }

    public string? PaidBy { get; set; }

    public string? Unit { get; set; }

    public double EntryAmount { get; set; }

    public double EntryPercentage { get; set; }

    public double Number { get; set; }

    public double Hourlywage { get; set; }

    public double NumberDaysPeriod { get; set; }

    public double NumberDaysAbsent { get; set; }

    public double AmountToBePaid { get; set; }

    public double AmountCosts { get; set; }

    public double BaseValue { get; set; }

    public double CalcCountryFloat1 { get; set; }

    public double CalcCountryFloat2 { get; set; }

    public double CalcCountryFloat3 { get; set; }

    public string? CreditorAccount { get; set; }

    public string? CreditorCostcenter { get; set; }

    public string? CreditorCostunit { get; set; }

    public string? LedgerAccount { get; set; }

    public string? LedgerCostcenter { get; set; }

    public string? LedgerCostunit { get; set; }

    public string? Creditor { get; set; }

    public string? Bankaccount { get; set; }

    public string? Companycode { get; set; }

    public byte DeclarationMade { get; set; }

    public DateTime? DeclarationDate { get; set; }

    public string? DeclarationNumber { get; set; }

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

    public Guid? DocAttachmentId { get; set; }

    public Guid? Notes { get; set; }

    public string? DeviatingDescr50 { get; set; }

    public string? Formulafield { get; set; }

    public string? Yourreference { get; set; }

    public string? Ourreference { get; set; }

    public string? Project { get; set; }

    public string? StateCode { get; set; }

    public string? LocalCode { get; set; }

    public short Priority { get; set; }

    public string? ReferenceNr1 { get; set; }

    public string? ReferenceNr2 { get; set; }

    public string? ItemCode { get; set; }

    public double NumberDaysComponent { get; set; }

    public Guid? ComponentGuid { get; set; }

    public short Contract { get; set; }

    public short? DeclarationPeriod { get; set; }

    public short? DeclarationSequence { get; set; }

    public DateTime? VoidDate { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
