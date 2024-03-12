using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TempPsascheduledTable
{
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? TotalRealized { get; set; }

    public double? TotalPlanned { get; set; }

    public double? TotalSchedule { get; set; }

    public string SessionId { get; set; } = null!;
}
