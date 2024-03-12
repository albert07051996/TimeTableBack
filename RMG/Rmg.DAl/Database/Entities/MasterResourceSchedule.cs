using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class MasterResourceSchedule
{
    public Guid Id { get; set; }

    public int Resource { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? BreakStart1 { get; set; }

    public DateTime? BreakEnd1 { get; set; }

    public DateTime? BreakStart2 { get; set; }

    public DateTime? BreakEnd2 { get; set; }

    public DateTime? BreakStart3 { get; set; }

    public DateTime? BreakEnd3 { get; set; }

    public Guid? ShiftId { get; set; }

    public string? DayType { get; set; }

    public DateTime EntryDate { get; set; }

    public double WorkingHour { get; set; }

    public string? ItemCode { get; set; }

    public string? Glaccount { get; set; }

    public string? CompanyCode { get; set; }

    public string? CostCenter { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
