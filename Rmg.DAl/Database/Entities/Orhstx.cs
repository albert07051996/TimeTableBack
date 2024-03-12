using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Orhstx
{
    public int Id { get; set; }

    public string? PakbonNr { get; set; }

    public DateTime? PakbonDat { get; set; }

    public string? Regel { get; set; }

    public string? Tekst { get; set; }

    public string? Ordernr { get; set; }

    public string? TextDescription { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
