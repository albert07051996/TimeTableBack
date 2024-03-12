using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Evloc
{
    public int Id { get; set; }

    public string? Magcode { get; set; }

    public string? Maglok { get; set; }

    public string? Oms30 { get; set; }

    public string? TypeLoc { get; set; }

    public string? Pickbulk { get; set; }

    public byte Intake { get; set; }

    public byte Issue { get; set; }

    public string? FixedItem { get; set; }

    public double MinStock { get; set; }

    public double MaxStock { get; set; }

    public byte BlockedIn { get; set; }

    public byte BlockedOut { get; set; }

    public double? NumberField1 { get; set; }

    public double? NumberField2 { get; set; }

    public double? NumberField3 { get; set; }

    public double? NumberField4 { get; set; }

    public double? NumberField5 { get; set; }

    public string? TextField1 { get; set; }

    public string? TextField2 { get; set; }

    public string? TextField3 { get; set; }

    public string? TextField4 { get; set; }

    public string? TextField5 { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
