using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class QiinvoiceLine
{
    public string Orig { get; set; } = null!;

    public int Id { get; set; }

    public string? Faknr { get; set; }

    public DateTime? Fakdat { get; set; }

    public string? Dagbknr { get; set; }

    public string? FaktCode { get; set; }

    public string? Volgnr5 { get; set; }

    public string? Regel { get; set; }

    public string? Artcode { get; set; }

    public double? BdrVal { get; set; }

    public string? ArSoort { get; set; }

    public string? Oms45 { get; set; }

    public string? Reknr { get; set; }

    public string? Magcode { get; set; }

    public string? Oms160 { get; set; }

    public string? AflWeek { get; set; }

    public DateTime? Afldat { get; set; }

    public double EsrAantal { get; set; }

    public byte Ordreg { get; set; }

    public string? BtwCode { get; set; }

    public string? Prijslijst { get; set; }

    public double Korting { get; set; }

    public double Prijs83 { get; set; }

    public double PrijsN { get; set; }

    public double? Gip { get; set; }

    public double Vvp { get; set; }

    public string? Kstdrcode { get; set; }

    public double? Lengte { get; set; }

    public double? Breedte { get; set; }

    public double? Hoogte { get; set; }

    public string? Dimensie { get; set; }

    public string? Project { get; set; }

    public string? PrKstpl { get; set; }

    public string? Kstsrt { get; set; }

    public byte? ProjvrwC { get; set; }

    public string? Maglok { get; set; }

    public double PrBedr { get; set; }

    public string? KortFlags { get; set; }

    public string? Prshisnr { get; set; }

    public string? Kstplcode { get; set; }

    public string? Explsrtart { get; set; }

    public string? ProdOrder { get; set; }

    public double? ExtraPr { get; set; }

    public string? Statistnr { get; set; }

    public string? Taric { get; set; }

    public string? Landoorspr { get; set; }

    public string? Landherk { get; set; }

    public string? Landbest { get; set; }

    public string? Landabc { get; set; }

    public string? LandIso { get; set; }

    public string? TransactA { get; set; }

    public string? TransactB { get; set; }

    public string? Vervoer { get; set; }

    public string? PltsLl { get; set; }

    public byte? Request { get; set; }

    public string? Stelsel { get; set; }

    public string? IntRegio { get; set; }

    public string? IntraLvcd { get; set; }

    public string? TrsshpmCd { get; set; }

    public byte? Container { get; set; }

    public double? StateenhI { get; set; }

    public double? GewichtBi { get; set; }

    public string? Boecode { get; set; }

    public string? Affiliates { get; set; }

    public string? Csacode { get; set; }

    public string? Ordernr { get; set; }

    public string? PakbonNr { get; set; }

    public DateTime? PakbonDat { get; set; }

    public string? Status { get; set; }

    public string? RegelHfda { get; set; }

    public byte? Correction { get; set; }

    public double? BdrVatVal { get; set; }

    public double? BdrEvEdVal { get; set; }

    public double? BdrDEvVal { get; set; }

    public double? BdrInvDVal { get; set; }

    public string? SerieNum { get; set; }

    public DateTime? EindDatC { get; set; }

    public string? ServOrder { get; set; }

    public double? PercCon { get; set; }

    public double? PercGar { get; set; }

    public string? VolgnrMut { get; set; }

    public string? Contractnr { get; set; }
}
