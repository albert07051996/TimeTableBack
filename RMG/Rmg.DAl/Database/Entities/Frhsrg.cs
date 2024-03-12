using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Frhsrg
{
    public int Id { get; set; }

    public string? Faknr { get; set; }

    public DateTime? Fakdat { get; set; }

    public string? Dagbknr { get; set; }

    public string? Regel { get; set; }

    public string? Artcode { get; set; }

    public string? ArSoort { get; set; }

    public string? Oms45 { get; set; }

    public string? Magcode { get; set; }

    public string? AflWeek { get; set; }

    public DateTime? Afldat { get; set; }

    public double EsrAantal { get; set; }

    public byte Ordreg { get; set; }

    public string? BtwCode { get; set; }

    public string? Prijslijst { get; set; }

    public double Korting { get; set; }

    public double PrijsN { get; set; }

    public double Prijs83 { get; set; }

    public string? Kstdrcode { get; set; }

    public double Vvp { get; set; }

    public double PrBedr { get; set; }

    public string? Kstplcode { get; set; }

    public string? Ordernr { get; set; }

    public string? IntraNr { get; set; }

    public string? PakbonNr { get; set; }

    public string? Maglok { get; set; }

    public string? Prshisnr { get; set; }

    public DateTime? PakbonDat { get; set; }

    public string? Explsrtart { get; set; }

    public string? Verzdebnr { get; set; }

    public string? VrzAdrcd { get; set; }

    public string? VrzAdrnr { get; set; }

    public double Koers { get; set; }

    public double BdrEvEdVal { get; set; }

    public double BdrDEvVal { get; set; }

    public double BdrVatVal { get; set; }

    public double BdrInvDVal { get; set; }

    public string? Docnumber { get; set; }

    public string? Projectnr { get; set; }

    public int ResId { get; set; }

    public string? SerialNumber { get; set; }

    public string? Unitcode { get; set; }

    public double Unitfactor { get; set; }

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

    public Guid? SalesOrderLine { get; set; }

    public string? ReasonDiscount { get; set; }

    public string? ReasonReturn { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
