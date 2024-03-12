using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmcompetenceGroup
{
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public int Levels { get; set; }

    public string? Remark { get; set; }

    public Guid? DocumentId { get; set; }

    public short? Division { get; set; }

    public bool AddObjectives { get; set; }

    public bool ShowObjectives { get; set; }

    public string RateObjectives { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
