using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ebmodule
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string ProgId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? Assembly { get; set; }

    public string? AssemblyClass { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
