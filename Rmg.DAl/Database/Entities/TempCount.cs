using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TempCount
{
    public int ResId { get; set; }

    public int Period { get; set; }

    public double? Fte { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? OldValue2 { get; set; }

    public string? NewValue2 { get; set; }

    public double? Fte2 { get; set; }

    public bool? Inflow { get; set; }

    public bool? Outflow { get; set; }

    public DateTime? ContEndDate { get; set; }

    public DateTime? Ldatuitdienst { get; set; }

    public string SessionId { get; set; } = null!;

    public DateTime? HreffectiveDate { get; set; }
}
