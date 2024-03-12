using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Orvsrg
{
    public int Id { get; set; }

    public string? Ordernr { get; set; }

    public string? Regel { get; set; }

    public DateTime? Afldat { get; set; }

    public string? Artcode { get; set; }

    public string? ArSoort { get; set; }

    public string? Oms45 { get; set; }

    public string? Oms45F { get; set; }

    public string? Magcode { get; set; }

    public string? AflWeek { get; set; }

    public double EsrAantal { get; set; }

    public string? BtwCode { get; set; }

    public string? Prijslijst { get; set; }

    public double Korting { get; set; }

    public double PrijsN { get; set; }

    public double Prijs83 { get; set; }

    public double Lengte { get; set; }

    public double Breedte { get; set; }

    public double Hoogte { get; set; }

    public string? Dimensie { get; set; }

    public string? Project { get; set; }

    public string? Kstsrt { get; set; }

    public string? PrKstpl { get; set; }

    public double PrAant { get; set; }

    public double PrBedr { get; set; }

    public string? Kstdrcode { get; set; }

    public string? Kstplcode { get; set; }

    public string? Industrie { get; set; }

    public string? PrafReg { get; set; }

    public string? Prshisnr { get; set; }

    public string? Explsrtart { get; set; }

    public double GipTekst { get; set; }

    public string? ProdOrder { get; set; }

    public double ExtraPr { get; set; }

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

    public string? Stelsel { get; set; }

    public string? IntRegio { get; set; }

    public string? IntraLvcd { get; set; }

    public string? TrsshpmCd { get; set; }

    public byte Container { get; set; }

    public double StateenhI { get; set; }

    public double GewichtBi { get; set; }

    public string? Boecode { get; set; }

    public string? Affiliates { get; set; }

    public string? Csacode { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
