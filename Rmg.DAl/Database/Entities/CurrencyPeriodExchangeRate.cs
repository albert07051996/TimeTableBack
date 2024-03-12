using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CurrencyPeriodExchangeRate
{
    public Guid Id { get; set; }

    public string BaseCurrencyCode { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public int FinYear { get; set; }

    public int FinPeriod { get; set; }

    public double ExchangeRateAvgPeriod { get; set; }

    public double ExchangeRateEndPeriod { get; set; }

    public double ExchangeRateBudgetPeriod { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
