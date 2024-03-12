using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TimesheetBulkPlanning
{
    public Guid? Id { get; set; }

    public string? Description { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? Friday { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemCode2 { get; set; }

    public bool? Monday { get; set; }

    public string? ProjectNumber { get; set; }

    public string? Remarks { get; set; }

    public int? ResourceId { get; set; }

    public bool? Saturday { get; set; }

    public DateTime? Startdate { get; set; }

    public bool? Sunday { get; set; }

    public bool? Thursday { get; set; }

    public bool? Tuesday { get; set; }

    public bool? Wednesday { get; set; }

    public string? Location { get; set; }

    public string? DeliverableCode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
