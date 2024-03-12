using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Fadprt
{
    public int Id { get; set; }

    public string? Deprmeth { get; set; }

    public string? Deprseqnum { get; set; }

    public double Deprperc { get; set; }

    public double Depramt { get; set; }

    public double Perfamt { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
