﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Grtbk
{
    public int Id { get; set; }

    public string? Reknr { get; set; }

    public string? Oms250 { get; set; }

    public string? Oms251 { get; set; }

    public string? Oms252 { get; set; }

    public string? Oms253 { get; set; }

    public string? Oms254 { get; set; }

    public string? BalVw { get; set; }

    public string? Debcrd { get; set; }

    public string? Subtotrek { get; set; }

    public int? Gbktext { get; set; }

    public string? BtwCode { get; set; }

    public byte Projectrek { get; set; }

    public byte Kstplrek { get; set; }

    public byte Kstdrrek { get; set; }

    public byte Aantallen { get; set; }

    public string? Omzrek { get; set; }

    public string? TypeRek { get; set; }

    public string? Mineraal { get; set; }

    public byte Blokkeer { get; set; }

    public byte Herwaard { get; set; }

    public byte Verdicht { get; set; }

    public short Blznr { get; set; }

    public double PercNaf { get; set; }

    public string? ReknrNaf { get; set; }

    public double PercPrive { get; set; }

    public string? ReknrPriv { get; set; }

    public short? Bkjrcode { get; set; }

    public short? BkjrMut { get; set; }

    public byte Afletteren { get; set; }

    public byte AfletMut { get; set; }

    public byte ActRek { get; set; }

    public string? TypeCom { get; set; }

    public string? StdKstpl { get; set; }

    public string? StdKstdr { get; set; }

    public byte Aandacht { get; set; }

    public byte Wisselrek { get; set; }

    public string? TypeRek2 { get; set; }

    public byte WijzReg { get; set; }

    public string? ReknrL { get; set; }

    public byte Prnbifunc { get; set; }

    public string? Afsreknr { get; set; }

    public string? SchemeType { get; set; }

    public byte AnalytAcc { get; set; }

    public string? Reknr2 { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public string? Freefield6 { get; set; }

    public string? Freefield7 { get; set; }

    public string? Freefield8 { get; set; }

    public string? Freefield9 { get; set; }

    public string? Freefield10 { get; set; }

    public double Freefield11 { get; set; }

    public double Freefield12 { get; set; }

    public double Freefield13 { get; set; }

    public double Freefield14 { get; set; }

    public double Freefield15 { get; set; }

    public byte Freefield16 { get; set; }

    public byte Freefield17 { get; set; }

    public byte Freefield18 { get; set; }

    public byte Freefield19 { get; set; }

    public byte Freefield20 { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? CentrAccount { get; set; }

    public string? IntBalanceDebit { get; set; }

    public string? SubclassPass { get; set; }

    public string? OffBalSubClassCredit { get; set; }

    public byte IsPersonalAccount { get; set; }

    public string? TypeAdjustmentInflation { get; set; }

    public Guid? DocumentId { get; set; }

    public string? Alternativeledger { get; set; }

    public byte UseResource { get; set; }

    public byte UseProject { get; set; }

    public byte UseItem { get; set; }

    public byte UseDebtor { get; set; }

    public byte UseCreditor { get; set; }

    public byte UseIntercompany { get; set; }

    public string? CompanyCode { get; set; }

    public string? AccountCode { get; set; }

    public int? AccountReportCategory { get; set; }

    public int? AccountConversionType { get; set; }

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

    public string? Class11 { get; set; }

    public string? Class12 { get; set; }

    public byte UseIbactive { get; set; }

    public byte UseCostcenterAllocation { get; set; }

    public string? AssociateGl { get; set; }

    public byte? ShowNotes { get; set; }

    public byte ExcludeVatlisting { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
