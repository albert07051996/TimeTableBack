using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OrganizationStructure
{
    public int Id { get; set; }

    public string? Parent { get; set; }

    public string Status { get; set; } = null!;

    public short ParentStartYear { get; set; }

    public string ParentStartPeriod { get; set; } = null!;

    public short? ParentEndYear { get; set; }

    public string? ParentEndPeriod { get; set; }

    public string Division { get; set; } = null!;

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
