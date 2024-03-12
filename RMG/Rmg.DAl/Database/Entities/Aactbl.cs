using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Aactbl
{
    public int Id { get; set; }

    public string? AnalytFld { get; set; }

    public string? AnalytCde { get; set; }

    public string? Descr300 { get; set; }

    public string? Descr301 { get; set; }

    public string? Descr302 { get; set; }

    public string? Descr303 { get; set; }

    public string? Descr304 { get; set; }

    public byte Active { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
