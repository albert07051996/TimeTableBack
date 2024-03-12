using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Balance
{
    public Guid Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public int FinYear { get; set; }

    public int FinPeriod { get; set; }

    public string CompanyAccountCode { get; set; } = null!;

    public string? CompanyCostcenterCode { get; set; }

    public string? CompanyCostunitCode { get; set; }

    public string? CurrencyCode { get; set; }

    public double AmountDebit { get; set; }

    public double AmountCredit { get; set; }

    public string? CurrencyAliasAc { get; set; }

    public double AmountDebitAc { get; set; }

    public double AmountCreditAc { get; set; }

    public string Transtype { get; set; } = null!;

    public string? Warehouse { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? ItemCode { get; set; }

    public double? Quantity { get; set; }

    public double ReportingAmountDebit { get; set; }

    public double ReportingAmountCredit { get; set; }

    public double ReportingAmountDebitAc { get; set; }

    public double ReportingAmountCreditAc { get; set; }

    public double? ReportingQuantity { get; set; }

    public short? Division { get; set; }
}
