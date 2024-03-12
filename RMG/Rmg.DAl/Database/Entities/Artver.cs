using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Artver
{
    public int Id { get; set; }

    public string? Artcode { get; set; }

    public string? Subart { get; set; }

    public short Priority { get; set; }

    public bool? Sales { get; set; }

    public bool? Production { get; set; }

    public bool? Mrp { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
