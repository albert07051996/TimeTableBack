using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EblogEntry
{
    public int Id { get; set; }

    public int DataQueueId { get; set; }

    public int Type { get; set; }

    public int ErrorNumber { get; set; }

    public string Message { get; set; } = null!;

    public string ProgId { get; set; } = null!;

    public DateTime Time { get; set; }

    public string? Bedrnr { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
