using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class QiinvoiceHeader
{
    public string Orig { get; set; } = null!;

    public int Id { get; set; }

    public string? Faknr { get; set; }

    public DateTime? Fakdat { get; set; }

    public string? Dagbknr { get; set; }

    public string? FaktCode { get; set; }

    public string? Volgnr5 { get; set; }

    public string? Debnr { get; set; }

    public string? Fakdebnr { get; set; }

    public string? Einddebnr { get; set; }

    public string? Refer { get; set; }

    public string? Refer1 { get; set; }

    public string? Refer2 { get; set; }

    public string? PakbonNr { get; set; }

    public double TotBdr { get; set; }

    public string? Ordernr { get; set; }

    public DateTime? Orddat { get; set; }

    public DateTime? Afldat { get; set; }

    public string? Magcode { get; set; }

    public string? ExArtcode { get; set; }

    public byte InvInVv { get; set; }

    public double BdrEvVal { get; set; }

    public string? Valcode { get; set; }

    public double Koers { get; set; }

    public string? Orddeb { get; set; }

    public string? Selcode { get; set; }

    public byte Nettoprijs { get; set; }

    public string? Betcond { get; set; }

    public string? Levwijze { get; set; }

    public string? StatCode { get; set; }

    public double Vrachtkost { get; set; }

    public double Orderkost { get; set; }

    public string? Kstplcode { get; set; }

    public double FaktKort { get; set; }

    public string? UserId { get; set; }

    public string? Colli { get; set; }

    public double BrutoGew { get; set; }

    public double NettoGew { get; set; }

    public DateTime? PakbonDat { get; set; }

    public string? VrzAdrnr { get; set; }

    public int RepresentId { get; set; }

    public string? BtwCode { get; set; }

    public string? BtwCdOrd { get; set; }

    public double BdrEvEdVal { get; set; }

    public double? BdrDEvVal { get; set; }

    public double BdrDiscVal { get; set; }

    public double BdrVatVal { get; set; }

    public double BdrKbVal { get; set; }

    public string? FakSoort { get; set; }

    public double? BdrKb2Val { get; set; }

    public byte? Fiattering { get; set; }

    public string? Status { get; set; }

    public string? ProdOrder { get; set; }

    public string? TypeProd { get; set; }

    public string? OfferteNr { get; set; }

    public double BdrVal { get; set; }

    public string? CrdFaktnr { get; set; }

    public string? CrdDgbknr { get; set; }

    public string? VrzAdrcd { get; set; }

    public string? Verzdebnr { get; set; }

    public string? AflWeek { get; set; }

    public string? Routecode { get; set; }

    public string? Docnumber { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
