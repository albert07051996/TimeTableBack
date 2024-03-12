using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WorkspaceCustomization
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public int Workspace { get; set; }

    public string AssignTo { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
