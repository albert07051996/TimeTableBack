using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Pred
{
    public int Id { get; set; }

    public string? Predcode { get; set; }

    public string? AanOms { get; set; }

    public string? Aanhef { get; set; }

    public string? Abbreviation { get; set; }

    public byte? Defaulttitle { get; set; }

    public string? Language { get; set; }

    public string? Gender { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
