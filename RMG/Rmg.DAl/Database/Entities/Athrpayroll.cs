using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Athrpayroll
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public short Contract { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Description { get; set; }

    public string? JobTitle { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public short? PayrollYear { get; set; }

    public int ResId { get; set; }

    public short Period { get; set; }

    public string? Religion { get; set; }

    public DateTime? DatEintritt1 { get; set; }

    public DateTime? DatAustritt1 { get; set; }

    public DateTime? DatEintritt2 { get; set; }

    public DateTime? DatAustritt2 { get; set; }

    public DateTime? DatEintritt3 { get; set; }

    public DateTime? DatAustritt3 { get; set; }

    public DateTime? DatEintritt4 { get; set; }

    public DateTime? DatAustritt4 { get; set; }

    public DateTime? DatEintritt5 { get; set; }

    public DateTime? DatAustritt5 { get; set; }

    public DateTime? DatErstEintritt { get; set; }

    public string? ArbeiterAngestellter { get; set; }

    public string? Anstellart { get; set; }

    public string? IsGeringBesch { get; set; }

    public string? IsKommPfl { get; set; }

    public string? IsDbPfl { get; set; }

    public string? IsDzPfl { get; set; }

    public string? IsUbahnPfl { get; set; }

    public string? PendlerPauschale { get; set; }

    public byte Gewerkschaftsbeitrag { get; set; }

    public byte Betriebsrat { get; set; }

    public string? SvNz { get; set; }

    public string? SvSz { get; set; }

    public string? Gkk { get; set; }

    public string? Gemeinde { get; set; }

    public string? ZusSteuerkriterien { get; set; }

    public byte Alleinverdiener { get; set; }

    public string? Kollektivvertrag { get; set; }

    public byte UseL16 { get; set; }

    public byte UseFehlerindikation { get; set; }

    public byte IsUnterbrechung1 { get; set; }

    public byte IsUnterbrechung2 { get; set; }

    public byte IsUnterbrechung3 { get; set; }

    public byte IsUnterbrechung4 { get; set; }

    public byte IsUnterbrechung5 { get; set; }

    public string? SvRechtlBesch { get; set; }

    public double GewBetrag { get; set; }

    public string? GewNr { get; set; }

    public double BetrRatBetrag { get; set; }

    public double Freibetrag63 { get; set; }

    public double Freibetrag25 { get; set; }

    public double Freibetrag35 { get; set; }

    public double Freibetrag105 { get; set; }

    public double KirchenSteuer { get; set; }

    public double VorBrutto { get; set; }

    public double VorBezug67 { get; set; }

    public double VorSzSv { get; set; }

    public double VorSz671 { get; set; }

    public double VorSz677 { get; set; }

    public short? VorAnzahlMon { get; set; }

    public double BauKvNr { get; set; }

    public string? BauAuto { get; set; }

    public double TeilerNorm { get; set; }

    public double TeilerUeber { get; set; }

    public double TeilerMehr { get; set; }

    public double AlterstBttoVorBeg { get; set; }

    public double AlterstSzVorBeg { get; set; }

    public string? Hinweis1 { get; set; }

    public string? Hinweis2 { get; set; }

    public string? Hinweis3 { get; set; }

    public short? BauUrlaub { get; set; }

    public DateTime? DatAblaufArbeitsbew { get; set; }

    public DateTime? DatBegPr { get; set; }

    public DateTime? DatEndPr { get; set; }

    public DateTime? DatBegKarenz { get; set; }

    public DateTime? DatEndKarenz { get; set; }

    public DateTime? DatBegAufenthaltsgen { get; set; }

    public DateTime? DatEndAufenthaltsgen { get; set; }

    public DateTime? DatVorruck { get; set; }

    public DateTime? DatBegLehre { get; set; }

    public DateTime? DatEndLehre { get; set; }

    public string? EhePartnerName { get; set; }

    public string? EhePartnerVersNr { get; set; }

    public string? JuengstesKindName { get; set; }

    public string? JuengstesKindVersNr { get; set; }

    public short? TitleForName { get; set; }

    public byte IsTeilzeit { get; set; }

    public DateTime? AbfnDate { get; set; }

    public double AbfnPerc { get; set; }

    public string? AbfnMvk { get; set; }

    public byte IsSeghigh { get; set; }

    public byte IsNoSzanspruch { get; set; }

    public short? AnzahlKinder { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Country { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int Syscreator { get; set; }

    public DateTime Syscreated { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Sysmodified { get; set; }

    public Guid Sysguid { get; set; }
}
