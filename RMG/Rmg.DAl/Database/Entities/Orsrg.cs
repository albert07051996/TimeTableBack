using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Orsrg
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

    public byte Uitgifte { get; set; }

    public byte Inkordernj { get; set; }

    public double AantBack { get; set; }

    public double EsrAantal { get; set; }

    public double AantGelev { get; set; }

    public double AantFakt { get; set; }

    public byte ReedsFakt { get; set; }

    public byte PakbonAfg { get; set; }

    public string? BtwCode { get; set; }

    public string? Prijslijst { get; set; }

    public double Korting { get; set; }

    public double Prijs83 { get; set; }

    public double PrijsN { get; set; }

    public double Gip { get; set; }

    public double Vvp { get; set; }

    public double Lengte { get; set; }

    public double Breedte { get; set; }

    public double Hoogte { get; set; }

    public string? Dimensie { get; set; }

    public string? Kstdrcode { get; set; }

    public string? Project { get; set; }

    public string? PrKstpl { get; set; }

    public string? Kstsrt { get; set; }

    public byte ProjvrwC { get; set; }

    public string? Maglok { get; set; }

    public string? Dummy5 { get; set; }

    public double PrBedr { get; set; }

    public string? PrafReg { get; set; }

    public string? Prshisnr { get; set; }

    public string? Industrie { get; set; }

    public string? Kstplcode { get; set; }

    public string? KortFlags { get; set; }

    public string? Explsrtart { get; set; }

    public string? Dummy10 { get; set; }

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

    public string? RegelHfda { get; set; }

    public string? QsrgLine { get; set; }

    public string? SerieNum { get; set; }

    public double AantalSer { get; set; }

    public string? Unit { get; set; }

    public double AvOntIn { get; set; }

    public double Koers { get; set; }

    public double BdrEvEdVal { get; set; }

    public double BdrDEvVal { get; set; }

    public double BdrVatVal { get; set; }

    public double BdrInvDVal { get; set; }

    public double BdrVal { get; set; }

    public string? Instruction { get; set; }

    public string? Projectnr { get; set; }

    public int ResId { get; set; }

    public string? Purchaseordernr { get; set; }

    public string? Unitcode { get; set; }

    public double Unitfactor { get; set; }

    public DateTime? ContractStartDate { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public string? TaxCode2 { get; set; }

    public string? TaxCode3 { get; set; }

    public string? TaxCode4 { get; set; }

    public string? TaxCode5 { get; set; }

    public double TaxBasis2 { get; set; }

    public double TaxBasis3 { get; set; }

    public double TaxBasis4 { get; set; }

    public double TaxBasis5 { get; set; }

    public double TaxAmount1 { get; set; }

    public double TaxAmount2 { get; set; }

    public double TaxAmount3 { get; set; }

    public double TaxAmount4 { get; set; }

    public double TaxAmount5 { get; set; }

    public double? StatisticalFactor { get; set; }

    public DateTime? PlannedDate { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Originalplanneddate { get; set; }

    public Guid? BlanketPoline { get; set; }

    public string? Reasoncode { get; set; }

    public Guid? OriginalPoline { get; set; }

    public short? Division { get; set; }

    public string? PakbonNr { get; set; }

    public Guid? Parent { get; set; }

    public Guid? ImportationId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
