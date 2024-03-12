using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Bdgvr
{
    public int Id { get; set; }

    public string? BudVers { get; set; }

    public short Revisienr { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public string? VersStat { get; set; }

    public short? BkjrcodeV { get; set; }

    public string? PeriodeV { get; set; }

    public short? BkjrcodeT { get; set; }

    public string? PeriodeT { get; set; }

    public short Prec { get; set; }

    public int Factor { get; set; }

    public string? BudNiveau { get; set; }

    public byte BudBev { get; set; }

    public string Planperiod { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
