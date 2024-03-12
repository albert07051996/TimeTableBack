using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Slrconfig
{
    public string Name { get; set; } = null!;

    public string? ValString { get; set; }

    public decimal? ValDecimal { get; set; }

    public int? ValInt { get; set; }

    public string? Reknr { get; set; }

    public string? Crdnr { get; set; }

    public decimal? ValDecimal4 { get; set; }

    public DateTime? ValDate { get; set; }
}
