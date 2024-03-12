using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OppPivotCurrency
{
    public int Id { get; set; }

    public string? Currency { get; set; }

    public double? Rate { get; set; }

    public string? SessionId { get; set; }
}
