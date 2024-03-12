using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ordlog
{
    public int Id { get; set; }

    public string? Mutvolgnr { get; set; }

    public string? Ordernr { get; set; }

    public string? Regel { get; set; }

    public string? UserId { get; set; }

    public DateTime? Xdate { get; set; }

    public int LogTime { get; set; }

    public string? Fileid { get; set; }

    public string? Exe { get; set; }

    public string? Varname { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? Reason { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
