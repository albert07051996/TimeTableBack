using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TempSchedule
{
    public DateTime? ScheduleEntryDate { get; set; }

    public DateTime? ScheduleStartTime { get; set; }

    public DateTime? ScheduleEndTime { get; set; }

    public double? ScheduleHours { get; set; }

    public string SessionId { get; set; } = null!;
}
