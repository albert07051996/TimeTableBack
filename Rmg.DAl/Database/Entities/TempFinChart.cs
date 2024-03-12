using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TempFinChart
{
    public string? LinkCode { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? Amount1 { get; set; }

    public string? Amount2 { get; set; }

    public double? AmountValue1 { get; set; }

    public double? AmountValue2 { get; set; }

    public string Parent { get; set; } = null!;

    public string? PeriodPic { get; set; }

    public string? PeriodTitle { get; set; }

    public string? ReplicatePic { get; set; }

    public string? ReplicateTitle { get; set; }

    public string SessionId { get; set; } = null!;
}
