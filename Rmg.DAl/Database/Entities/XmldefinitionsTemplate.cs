using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class XmldefinitionsTemplate
{
    public Guid Id { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Definition { get; set; } = null!;

    public string? Version { get; set; }

    public bool Active { get; set; }

    public DateTime? Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime? Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
