using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TempBalGraph
{
    public string? Currency { get; set; }

    public string? CurrDesc { get; set; }

    public int? Period { get; set; }

    public int? PeriodDesc { get; set; }

    public double? Amount { get; set; }

    public string SessionId { get; set; } = null!;
}
