using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class StepRelation
{
    public int Id { get; set; }

    public string Routing { get; set; } = null!;

    public int Step { get; set; }

    public int Predecessor { get; set; }

    public string? DependencyType { get; set; }

    public double Lag { get; set; }

    public string? LagType { get; set; }

    public string? ItemCode { get; set; }

    public string? Version { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
