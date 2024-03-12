using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Taxtransactionsview
{
    public int Id { get; set; }

    public short? FinancialYear { get; set; }

    public string? Period { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? Afldat { get; set; }

    public string? Journal { get; set; }

    public string? Account { get; set; }

    public string? CostAccount { get; set; }

    public string? Description { get; set; }

    public string? EntryNumber { get; set; }

    public string? OurRef { get; set; }

    public string? YourRef { get; set; }

    public Guid? Idgbkmut { get; set; }

    public DateTime? DocumentDate { get; set; }

    public string? Companycode { get; set; }

    public int PostingNumber { get; set; }

    public int Posted { get; set; }

    public string? ReportNumberTax { get; set; }

    public string? ReportNumberIct { get; set; }

    public string? DebCrdNumber { get; set; }

    public string? DebCrdName { get; set; }

    public string? Vatnumber { get; set; }

    public string? DebVatCode { get; set; }

    public string? DebCountryCode { get; set; }

    public string? JournalType { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxDescription { get; set; }

    public double? TaxPercentage { get; set; }

    public string? Currency { get; set; }

    public double ExchangeRate { get; set; }

    public double? AmountTaxBase { get; set; }

    public double? AmountTaxBaseCurrency { get; set; }

    public double? AmountTaxCurrency { get; set; }

    public double? AmountTaxCharge { get; set; }

    public double? AmountTaxChargeCurrency { get; set; }

    public double? AmountTax { get; set; }

    public Guid? Entryguid { get; set; }
}
