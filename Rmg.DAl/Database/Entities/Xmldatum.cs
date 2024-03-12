using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Xmldatum
{
    public Guid Id { get; set; }

    public string Data { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
