using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TempMonthPeriod
{
    public int Period { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Description { get; set; } = null!;

    public int PeriodsPerYear { get; set; }

    public double AverageDays { get; set; }

    public string SessionId { get; set; } = null!;
}
