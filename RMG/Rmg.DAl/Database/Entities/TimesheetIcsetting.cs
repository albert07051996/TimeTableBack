using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TimesheetIcsetting
{
    public Guid Id { get; set; }

    public string? DivisionResource { get; set; }

    public string? DivisionProject { get; set; }

    public string? ProjectNr { get; set; }

    public string? Iccosts { get; set; }

    public string? IcinvTbr { get; set; }

    public string? CostCenter { get; set; }

    public string? CostUnit { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }

    public Guid Sysguid { get; set; }
}
