using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Artgrp
{
    public int Id { get; set; }

    public string? Artgrp1 { get; set; }

    public string? Groepnaam0 { get; set; }

    public string? Groepnaam1 { get; set; }

    public string? Groepnaam2 { get; set; }

    public string? Groepnaam3 { get; set; }

    public string? Groepnaam4 { get; set; }

    public string? RekVoorr { get; set; }

    public string? RekOmz { get; set; }

    public string? RekKstpv { get; set; }

    public string? RekPrv { get; set; }

    public string? RekKort { get; set; }

    public string? Statistnr { get; set; }

    public string? Kstdrcode { get; set; }

    public string? RekOhw { get; set; }

    public string? RekScws { get; set; }

    public double? Freefield1 { get; set; }

    public double? Freefield2 { get; set; }

    public double? Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public string? Freefield6 { get; set; }

    public string? Freefield7 { get; set; }

    public string? Freefield8 { get; set; }

    public string? Freefield9 { get; set; }

    public string? Freefield10 { get; set; }

    public DateTime? Freefield11 { get; set; }

    public DateTime? Freefield12 { get; set; }

    public double? Freefield13 { get; set; }

    public double? Freefield14 { get; set; }

    public double? Freefield15 { get; set; }

    public byte? Freefield16 { get; set; }

    public byte? Freefield17 { get; set; }

    public byte? Freefield18 { get; set; }

    public byte? Freefield19 { get; set; }

    public byte? Freefield20 { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
