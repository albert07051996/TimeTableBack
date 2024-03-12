using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Orhkrg
{
    public int Id { get; set; }

    public string? PakbonNr { get; set; }

    public DateTime? PakbonDat { get; set; }

    public string? Ordernr { get; set; }

    public string? Debnr { get; set; }

    public string? Fakdebnr { get; set; }

    public string? Verzdebnr { get; set; }

    public string? Einddebnr { get; set; }

    public string? Refer { get; set; }

    public string? Refer1 { get; set; }

    public string? Refer2 { get; set; }

    public string? Refer3 { get; set; }

    public DateTime? Orddat { get; set; }

    public DateTime? Afldat { get; set; }

    public string? AflWeek { get; set; }

    public string? Magcode { get; set; }

    public string? Selcode { get; set; }

    public string? Routecode { get; set; }

    public string? ExArtcode { get; set; }

    public byte InvInVv { get; set; }

    public string? Valcode { get; set; }

    public double Koers { get; set; }

    public string? Levwijze { get; set; }

    public double Vrachtkost { get; set; }

    public double Orderkost { get; set; }

    public double OrderKort { get; set; }

    public string? Colli { get; set; }

    public string? Kstplcode { get; set; }

    public string? OrdSoort { get; set; }

    public byte Archived { get; set; }

    public string? BtwCode { get; set; }

    public string? BtwCdOrd { get; set; }

    public double OrderBdr { get; set; }

    public short? Bkjrcode { get; set; }

    public string? Periode { get; set; }

    public string? ProdOrder { get; set; }

    public string? TypeProd { get; set; }

    public string? OfferteNr { get; set; }

    public string? UserId { get; set; }

    public string? Betcond { get; set; }

    public double BrutoGew { get; set; }

    public double NettoGew { get; set; }

    public string? IsoTaalcd { get; set; }

    public string? VrzAdrcd { get; set; }

    public string? VrzAdrnr { get; set; }

    public byte EtikAfgdr { get; set; }

    public int PakbonTim { get; set; }

    public int RepresentId { get; set; }

    public string? Crdnr { get; set; }

    public string? KlantnLev { get; set; }

    public string? CalcMethPc { get; set; }

    public string? CalcInclVat { get; set; }

    public string? Fakcrdnr { get; set; }

    public double BdrVatOrdVal { get; set; }

    public double BdrVatShipVal { get; set; }

    public double BdrKbVal { get; set; }

    public double BdrDiscVal { get; set; }

    public double BdrVal { get; set; }

    public string? Bstwijze { get; set; }

    public string? Docnumber { get; set; }

    public string? Projectnr { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public string? OrdDebtorName { get; set; }

    public string? OrdAddressLine1 { get; set; }

    public string? OrdAddressLine2 { get; set; }

    public string? OrdAddressLine3 { get; set; }

    public string? OrdPostCode { get; set; }

    public string? OrdCity { get; set; }

    public string? OrdStateCode { get; set; }

    public string? OrdLandcode { get; set; }

    public string? OrdPhone { get; set; }

    public string? OrdFax { get; set; }

    public string? OrdContactperson { get; set; }

    public string? OrdPredcode { get; set; }

    public string? OrdCntJobDesc { get; set; }

    public string? OrdInitials { get; set; }

    public string? DelDebtorName { get; set; }

    public string? DelAddressLine1 { get; set; }

    public string? DelAddressLine2 { get; set; }

    public string? DelAddressLine3 { get; set; }

    public string? DelPostCode { get; set; }

    public string? DelCity { get; set; }

    public string? DelStateCode { get; set; }

    public string? DelLandcode { get; set; }

    public string? DelPhone { get; set; }

    public string? DelFax { get; set; }

    public string? DelContactperson { get; set; }

    public string? DelPredcode { get; set; }

    public string? DelCntJobDesc { get; set; }

    public string? DelInitials { get; set; }

    public string? InvDebtorName { get; set; }

    public string? InvAddressLine1 { get; set; }

    public string? InvAddressLine2 { get; set; }

    public string? InvAddressLine3 { get; set; }

    public string? InvPostCode { get; set; }

    public string? InvCity { get; set; }

    public string? InvStateCode { get; set; }

    public string? InvLandcode { get; set; }

    public string? InvPhone { get; set; }

    public string? InvFax { get; set; }

    public string? InvContactperson { get; set; }

    public string? InvPredcode { get; set; }

    public string? InvCntJobDesc { get; set; }

    public string? InvInitials { get; set; }

    public Guid? DocumentId { get; set; }

    public string? ExternalNumber { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
