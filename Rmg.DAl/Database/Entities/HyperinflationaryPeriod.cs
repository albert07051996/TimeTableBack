using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HyperinflationaryPeriod
{
    public int Id { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public bool Hyperinflationary { get; set; }

    public short YearFrom { get; set; }

    public string PeriodFrom { get; set; } = null!;

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
