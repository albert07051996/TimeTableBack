using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Valutum
{
    public int Id { get; set; }

    public string? Valcode { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public string? AfkVal { get; set; }

    public double Omrekfact { get; set; }

    public string? Rekkrsvink { get; set; }

    public string? Rekkrswink { get; set; }

    public string? Rekkrsvvrk { get; set; }

    public string? Rekkrswvrk { get; set; }

    public string? Rekherw { get; set; }

    public string? Rekherww { get; set; }

    public string? Btwlaagvrk { get; set; }

    public string? Btwhoogvrk { get; set; }

    public string? Btwlaagink { get; set; }

    public string? Btwhoogink { get; set; }

    public byte Dagkoers { get; set; }

    public byte Doorbkvali { get; set; }

    public byte Doorbkvalv { get; set; }

    public string? Omzetcode { get; set; }

    public byte Invvalink { get; set; }

    public byte Invvalvrk { get; set; }

    public short PricePrec { get; set; }

    public short AmountPrec { get; set; }

    public string? CurLetter { get; set; }

    public byte XtraRates { get; set; }

    public short RatePrec { get; set; }

    public byte EmuCurrency { get; set; }

    public DateTime? EmuDate { get; set; }

    public string? Swiftvalcd { get; set; }

    public string? BlwiValcd { get; set; }

    public byte Active { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public string? Freefield6 { get; set; }

    public string? Freefield7 { get; set; }

    public double Freefield8 { get; set; }

    public double Freefield9 { get; set; }

    public double Freefield10 { get; set; }

    public double Freefield11 { get; set; }

    public double Freefield12 { get; set; }

    public double Freefield13 { get; set; }

    public DateTime? Freefield14 { get; set; }

    public DateTime? Freefield15 { get; set; }

    public DateTime? Freefield16 { get; set; }

    public byte Freefield17 { get; set; }

    public byte Freefield18 { get; set; }

    public byte Freefield19 { get; set; }

    public byte Freefield20 { get; set; }

    public byte Enabled { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
