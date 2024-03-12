using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WorkspaceSharedDivision
{
    public int Id { get; set; }

    public int Workspace { get; set; }

    public string Division { get; set; } = null!;

    public int SecurityLevel { get; set; }

    public int Rights { get; set; }

    public int PinnedBy { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
