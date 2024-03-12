using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TempFinMap
{
    public string? CountryCode { get; set; }

    public string? ColumnType { get; set; }

    public double? Amount { get; set; }

    public string SessionId { get; set; } = null!;
}
