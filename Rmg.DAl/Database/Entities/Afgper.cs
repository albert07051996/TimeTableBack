using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Afgper
{
    public int Id { get; set; }

    public string? Periode { get; set; }

    public string? Dagbknr { get; set; }

    public short? Bkjrcode { get; set; }

    public DateTime Syscreated { get; set; }

    public int PagnrJournalRep { get; set; }

    public int PagnrCentrJournalRep { get; set; }

    public short? Division { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
