using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Kplvrd
{
    public int Id { get; set; }

    public string? Kstplcode { get; set; }

    public string? Targetkpl { get; set; }

    public double Eenheden { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
