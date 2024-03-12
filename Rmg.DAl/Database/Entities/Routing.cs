using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Routing
{
    public int Id { get; set; }

    public string Routing1 { get; set; } = null!;

    public int Step { get; set; }

    public string? Description { get; set; }

    public string Workcenter { get; set; } = null!;

    public string Operation { get; set; } = null!;

    public double Throughput { get; set; }

    public byte? Blocked { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
