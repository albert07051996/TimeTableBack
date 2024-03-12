using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Orhsrg
{
    public int Id { get; set; }

    public string? PakbonNr { get; set; }

    public DateTime? PakbonDat { get; set; }

    public string? Regel { get; set; }

    public string? Artcode { get; set; }

    public string? Ordernr { get; set; }

    public string? ArSoort { get; set; }

    public string? Oms45 { get; set; }

    public string? Magcode { get; set; }

    public DateTime? Afldat { get; set; }

    public string? AflWeek { get; set; }

    public double AantGelev { get; set; }

    public string? BtwCode { get; set; }

    public string? Prijslijst { get; set; }

    public double Korting { get; set; }

    public double Prijs83 { get; set; }

    public double PrijsN { get; set; }

    public string? Kstdrcode { get; set; }

    public double Vvp { get; set; }

    public double Lengte { get; set; }

    public double Breedte { get; set; }

    public double Hoogte { get; set; }

    public string? Dimensie { get; set; }

    public string? Project { get; set; }

    public string? Kstsrt { get; set; }

    public string? PrKstpl { get; set; }

    public double PrAant { get; set; }

    public double PrBedr { get; set; }

    public string? Kstplcode { get; set; }

    public string? KortFlags { get; set; }

    public string? Cat1 { get; set; }

    public string? Cat2 { get; set; }

    public string? Cat3 { get; set; }

    public string? ProdOrder { get; set; }

    public double ExtraPr { get; set; }

    public string? Explsrtart { get; set; }

    public string? RegelHfda { get; set; }

    public string? SerieNum { get; set; }

    public double AantalSer { get; set; }

    public string? Unit { get; set; }

    public double AvOntIn { get; set; }

    public double Koers { get; set; }

    public double BdrEvEdVal { get; set; }

    public double BdrDEvVal { get; set; }

    public double BdrVatVal { get; set; }

    public double BdrInvDVal { get; set; }

    public string? Instruction { get; set; }

    public string? Projectnr { get; set; }

    public int ResId { get; set; }

    public string? Unitcode { get; set; }

    public double Unitfactor { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
