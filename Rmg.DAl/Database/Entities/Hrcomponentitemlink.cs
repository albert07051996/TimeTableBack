using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrcomponentitemlink
{
    public int Id { get; set; }

    public string CompCode { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? RelCode { get; set; }

    public string Type { get; set; } = null!;

    public string? Assortment { get; set; }

    public string? LedgerAccount { get; set; }

    public string? PayrollComponent { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
