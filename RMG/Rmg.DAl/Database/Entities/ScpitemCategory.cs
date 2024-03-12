using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpitemCategory
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public int? Sequence { get; set; }

    public string? ParentCode { get; set; }

    public bool? UseDates { get; set; }

    public Guid? PortalId { get; set; }
}
