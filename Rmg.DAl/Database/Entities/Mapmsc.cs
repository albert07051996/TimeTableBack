using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Mapmsc
{
    public int Id { get; set; }

    public string? Laytype { get; set; }

    public string? Label { get; set; }

    public string? Expr { get; set; }

    public short Dimtype { get; set; }

    public string? Descr { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
