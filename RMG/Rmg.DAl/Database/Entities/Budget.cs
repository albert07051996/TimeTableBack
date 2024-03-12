using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Budget
{
    public Guid BudgetId { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string ScenarioCode { get; set; } = null!;

    public int ScenarioVersion { get; set; }

    public int FinYear { get; set; }

    public int FinPeriod { get; set; }

    public string? CompanyAccountCategory { get; set; }

    public string? CompanyAccountCode { get; set; }

    public string? CompanyCostcenterCode { get; set; }

    public string? CompanyCostunitCode { get; set; }

    public string? CurrencyCode { get; set; }

    public double Rate { get; set; }

    public double Amount { get; set; }

    public string CurrencyAliasAc { get; set; } = null!;

    public double AmountAc { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? ItemCode { get; set; }

    public short? Division { get; set; }

    public double? Quantity { get; set; }
}
