using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Artbst
{
    public int Id { get; set; }

    public string Artcode { get; set; } = null!;

    public string? ArSoort { get; set; }

    public byte Samengest { get; set; }

    public string? KortOms { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public string? LevCrdnr { get; set; }

    public string? Tekst { get; set; }

    public string? Artgrp { get; set; }

    public string? Magcode { get; set; }

    public byte? Voorrart { get; set; }

    public string? EenhVerk { get; set; }

    public double? AantVerp { get; set; }

    public double? VerkpVerp { get; set; }

    public string? Bestadvc { get; set; }

    public string? BtwVerk { get; set; }

    public string? BtwInk { get; set; }

    public string? Statistnr { get; set; }

    public byte? Backordart { get; set; }

    public string? VerpOms { get; set; }

    public string? SerieArt { get; set; }

    public byte? Orderink { get; set; }

    public double? Vwrd1 { get; set; }

    public double? Vwrd2 { get; set; }

    public double Vvp { get; set; }

    public string? IntfacInk { get; set; }

    public string? IntfacVrk { get; set; }

    public double? Stateenh { get; set; }

    public double? Nettogew { get; set; }

    public double? Brutogew { get; set; }

    public string? BtwVlevy { get; set; }

    public double? Vmargin { get; set; }

    public string? Status { get; set; }

    public string? Picturefile { get; set; }

    public string? Condition { get; set; }

    public string? Property { get; set; }

    public byte? Divisible { get; set; }

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

    public byte Discount { get; set; }

    public byte Explode { get; set; }

    public byte FromSynergy { get; set; }

    public string? Class01 { get; set; }

    public string? Class02 { get; set; }

    public string? Class03 { get; set; }

    public string? Class04 { get; set; }

    public string? Class05 { get; set; }

    public string? Class06 { get; set; }

    public string? Class07 { get; set; }

    public string? Class08 { get; set; }

    public string? Class09 { get; set; }

    public string? Class10 { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
