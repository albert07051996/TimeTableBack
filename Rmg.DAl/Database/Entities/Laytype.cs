using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Laytype
{
    public int Id { get; set; }

    public int Laytype1 { get; set; }

    public string Suffix { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
