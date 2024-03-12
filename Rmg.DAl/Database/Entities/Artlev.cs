using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Artlev
{
    public int Id { get; set; }

    public string? Artcode { get; set; }

    public string? LevCrdnr { get; set; }

    public string? Artcodlev { get; set; }

    public string? EenhInk { get; set; }

    public double Aantverpi { get; set; }

    public double InkpVerp { get; set; }

    public double? Gip { get; set; }

    public double? TotNontv { get; set; }

    public double? OmrFact { get; set; }

    public string? BtwInk { get; set; }

    public int? Prafspr { get; set; }

    public short? Levt { get; set; }

    public byte? Levb { get; set; }

    public double Bestgr { get; set; }

    public string? VerpOms { get; set; }

    public string? BestnL { get; set; }

    public DateTime? Bestdatl { get; set; }

    public DateTime? Ontvdatl { get; set; }

    public double? Qtypack { get; set; }

    public double? Qtyunit { get; set; }

    public double SlsPkgsPerPurPkg { get; set; }

    public string? Barcode { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
