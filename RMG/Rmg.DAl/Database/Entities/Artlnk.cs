using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Artlnk
{
    public int Id { get; set; }

    public string? Artcode { get; set; }

    public string? Bestand { get; set; }

    public string? Document { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public Guid? DocGuid { get; set; }
}
