using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Land
{
    public int Id { get; set; }

    public string? Landcode { get; set; }

    public string? LandIsonr { get; set; }

    public string? Oms600 { get; set; }

    public string? Oms601 { get; set; }

    public string? Oms602 { get; set; }

    public string? Oms603 { get; set; }

    public string? Oms604 { get; set; }

    public byte LidEu { get; set; }

    public string? LandCbs { get; set; }

    public string? BtwLand { get; set; }

    public string? Swiftvalcd { get; set; }

    public string? IsoValcd { get; set; }

    public string? Btwvrtnr { get; set; }

    public DateTime Syscreated { get; set; }

    public byte Active { get; set; }

    public string? Class01 { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public string? Class02 { get; set; }

    public string? Oms300 { get; set; }

    public int Sysmodifier { get; set; }

    public string? Class03 { get; set; }

    public Guid Sysguid { get; set; }

    public string? Class04 { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
