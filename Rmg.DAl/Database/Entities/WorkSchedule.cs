using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WorkSchedule
{
    public Guid Id { get; set; }

    public string? CompanyCode { get; set; }

    public int? EmpId { get; set; }

    public int WeekDay { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? ScheduleType { get; set; }

    public Guid? ShiftId { get; set; }

    public string DayType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
