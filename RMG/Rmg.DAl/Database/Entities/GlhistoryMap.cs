using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class GlhistoryMap
{
    public int Id { get; set; }

    public string Parent { get; set; } = null!;

    public string? ParentGl { get; set; }

    public int? ExchangeRateType { get; set; }

    public short ParentYear { get; set; }

    public string ParentPeriod { get; set; } = null!;

    public DateTime? HistoricalDate { get; set; }

    public string DivisionGl { get; set; } = null!;

    public string Division { get; set; } = null!;

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
