using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Facard
{
    public DateTime Activatedate { get; set; }

    public string Artcode { get; set; } = null!;

    public string? Assetcode { get; set; }

    public string? Assetgroup { get; set; }

    public Guid? AttachGuid { get; set; }

    public string? Bedrnr { get; set; }

    public string? Classification { get; set; }

    public string? Crdnr { get; set; }

    public int Currqtyunits { get; set; }

    public double Costlastmnt { get; set; }

    public double Costlastmntfc { get; set; }

    public Guid? Debnr { get; set; }

    public string? Descr500 { get; set; }

    public string? Descr501 { get; set; }

    public string? Descr502 { get; set; }

    public string? Descr503 { get; set; }

    public string? Descr504 { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Fiscalgroup { get; set; }

    public string? Freefield1 { get; set; }

    public double? Freefield10 { get; set; }

    public int? Freefield11 { get; set; }

    public int? Freefield12 { get; set; }

    public int? Freefield13 { get; set; }

    public int? Freefield14 { get; set; }

    public int? Freefield15 { get; set; }

    public DateTime? Freefield16 { get; set; }

    public DateTime? Freefield17 { get; set; }

    public DateTime? Freefield18 { get; set; }

    public string? Freefield19 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield20 { get; set; }

    public string? Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public double? Freefield6 { get; set; }

    public double? Freefield7 { get; set; }

    public double? Freefield8 { get; set; }

    public double? Freefield9 { get; set; }

    public int Id { get; set; }

    public string? Kstdrcode { get; set; }

    public string? Kstplcode { get; set; }

    public DateTime? Lastmntdate { get; set; }

    public double Miscamt { get; set; }

    public double Miscamtfc { get; set; }

    public Guid? NotesGuid { get; set; }

    public double Origbkvalue { get; set; }

    public double Origbkvaluefc { get; set; }

    public double Origpurchamt { get; set; }

    public double Origpurchamtfc { get; set; }

    public Guid? Parentid { get; set; }

    public byte Passengercar { get; set; }

    public byte[]? Picture { get; set; }

    public string? Picturefilename { get; set; }

    public string? Pricelist { get; set; }

    public string? Primarymeth { get; set; }

    public string? Projectnr { get; set; }

    public string? Propertytype { get; set; }

    public double? Qtyrecd { get; set; }

    public string? Receiptnum { get; set; }

    public int ResId { get; set; }

    public double Residualvalue { get; set; }

    public string? Secondarymeth { get; set; }

    public string? Status { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public Guid Sysguid { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte Tangible { get; set; }

    public Guid? TransactionGuid { get; set; }

    public string? Usagestartper { get; set; }

    public string? Usagestartyear { get; set; }

    public string? Valcode { get; set; }

    public double? Exchrate { get; set; }

    public Guid? AddressGuid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
