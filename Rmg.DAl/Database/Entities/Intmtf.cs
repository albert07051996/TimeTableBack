using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Intmtf
{
    public int Id { get; set; }

    public string? Maatstaf { get; set; }

    public string? Oms60 { get; set; }

    public byte Tonen { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
