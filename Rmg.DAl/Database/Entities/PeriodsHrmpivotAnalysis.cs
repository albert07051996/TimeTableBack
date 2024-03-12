using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PeriodsHrmpivotAnalysis
{
    public int Id { get; set; }

    public int? Period { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }

    public string? SessionId { get; set; }
}
