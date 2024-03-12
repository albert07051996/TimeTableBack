using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemCopyRelease
{
    public Guid Id { get; set; }

    public DateTime ScheduleDate { get; set; }

    public DateTime? ExecutionStartDate { get; set; }

    public DateTime? ExecutionEndDate { get; set; }

    public string ReleaseFrom { get; set; } = null!;

    public string ReleaseTo { get; set; } = null!;

    public string Assortment { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public string? ErrorMessage { get; set; }

    public int? TotalRecord { get; set; }
}
