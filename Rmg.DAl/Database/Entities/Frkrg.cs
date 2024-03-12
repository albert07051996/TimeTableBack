using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Frkrg
{
    public int Id { get; set; }

    public string? FaktCode { get; set; }

    public string? Volgnr5 { get; set; }

    public string? Debnr { get; set; }

    public string? Fakdebnr { get; set; }

    public string? Einddebnr { get; set; }

    public string? Refer { get; set; }

    public string? Refer1 { get; set; }

    public string? Refer2 { get; set; }

    public string? Refer3 { get; set; }

    public string? Ordernr { get; set; }

    public DateTime? Orddat { get; set; }

    public DateTime? Afldat { get; set; }

    public string? Magcode { get; set; }

    public string? ExArtcode { get; set; }

    public string? Kstplcode { get; set; }

    public string? Selcode { get; set; }

    public byte InvInVv { get; set; }

    public double BdrEvVal { get; set; }

    public byte Nettoprijs { get; set; }

    public string? BtwCode { get; set; }

    public string? BtwCdOrd { get; set; }

    public double BdrEvEdVal { get; set; }

    public string? Valcode { get; set; }

    public double Koers { get; set; }

    public string? Betcond { get; set; }

    public double BdrDEvVal { get; set; }

    public string? Levwijze { get; set; }

    public string? StatCode { get; set; }

    public double Vrachtkost { get; set; }

    public double BdrDiscVal { get; set; }

    public double Orderkost { get; set; }

    public double FaktKort { get; set; }

    public double TotBdr { get; set; }

    public double BdrVatVal { get; set; }

    public string? Colli { get; set; }

    public double BrutoGew { get; set; }

    public double NettoGew { get; set; }

    public string? UserId { get; set; }

    public double BdrKbVal { get; set; }

    public string? FakSoort { get; set; }

    public string? Faknr { get; set; }

    public double BdrKb2Val { get; set; }

    public byte Fiattering { get; set; }

    public string? PakbonNr { get; set; }

    public DateTime? PakbonDat { get; set; }

    public string? Status { get; set; }

    public string? ProdOrder { get; set; }

    public string? TypeProd { get; set; }

    public string? OfferteNr { get; set; }

    public double BdrVal { get; set; }

    public string? IsoTaalcd { get; set; }

    public string? CrdFaktnr { get; set; }

    public string? CrdDgbknr { get; set; }

    public string? VrzAdrcd { get; set; }

    public string? VrzAdrnr { get; set; }

    public string? Verzdebnr { get; set; }

    public string? AflWeek { get; set; }

    public string? Routecode { get; set; }

    public string? Fkbguids { get; set; }

    public string? Fkbseqnr { get; set; }

    public int RepresentId { get; set; }

    public string? EcaType { get; set; }

    public string? CntrId { get; set; }

    public DateTime? Prolrundate { get; set; }

    public DateTime? Proldate { get; set; }

    public string? ServOrder { get; set; }

    public double BdrVatOrdVal { get; set; }

    public string? Contractnr { get; set; }

    public double BdrVatShipVal { get; set; }

    public double BdrLinedEvVal { get; set; }

    public double BdrLinediscVal { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public string? EsyAdres1 { get; set; }

    public string? Layout { get; set; }

    public string? EsyPostcode { get; set; }

    public Guid Sysguid { get; set; }

    public string? EsyWoonpl { get; set; }

    public string? EsyLandcode { get; set; }

    public short Actionstatus { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? EsyPredcode { get; set; }

    public string? Actionmessage { get; set; }

    public string? EsyVrlttrs { get; set; }

    public string? EsyCntpers { get; set; }

    public string? EsyPhone { get; set; }

    public string? Crdnr { get; set; }

    public string? KlantnLev { get; set; }

    public string? CalcMethPc { get; set; }

    public string? CalcInclVat { get; set; }

    public string? Fakcrdnr { get; set; }

    public DateTime? Vervdatkrd { get; set; }

    public DateTime? Vervdatkrd2 { get; set; }

    public double Percentag { get; set; }

    public double Percentag2 { get; set; }

    public DateTime? Vervdatfak { get; set; }

    public DateTime? Datum { get; set; }

    public byte DirInk { get; set; }

    public string? Docnumber { get; set; }

    public string? Paymentmethod { get; set; }

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

    public int Approver { get; set; }

    public DateTime? Approved { get; set; }

    public Guid? DocumentId { get; set; }

    public string? CashRegisterAccount { get; set; }

    public string? InvContactemail { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public double? Freefield4 { get; set; }

    public double? Freefield5 { get; set; }

    public short? Division { get; set; }
}
