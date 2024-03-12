using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankBalancePerCurrencyView
{
    public string Currency { get; set; } = null!;

    public string? Description { get; set; }

    public int? NumberOfAccounts { get; set; }

    public double? ClosingBalance { get; set; }

    public int ClosingBalanceEur { get; set; }
}
