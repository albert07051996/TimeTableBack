using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Xmldefinition
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;

    public string Definition { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
