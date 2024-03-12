using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Intfac
{
    public int Id { get; set; }

    public string? Statfactor { get; set; }

    public string? Oms25 { get; set; }

    public double IntFactor { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
