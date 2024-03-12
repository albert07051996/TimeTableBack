using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Artom
{
    public int Id { get; set; }

    public string? ExArtcode { get; set; }

    public string? Oms200 { get; set; }

    public string? Oms201 { get; set; }

    public string? Oms202 { get; set; }

    public string? Oms203 { get; set; }

    public string? Oms204 { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
