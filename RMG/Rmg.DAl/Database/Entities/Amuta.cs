﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Amuta
{
    public int Id { get; set; }

    public short? Bkjrcode { get; set; }

    public string? Periode { get; set; }

    public string? Dagbknr { get; set; }

    public string? Volgnr5 { get; set; }

    public string? Regel { get; set; }

    public DateTime? Datum { get; set; }

    public string? Bkstnr { get; set; }

    public string? BkstnrVrz { get; set; }

    public string? Reknr { get; set; }

    public string? Oms25 { get; set; }

    public string? Debnr { get; set; }

    public string? Crdnr { get; set; }

    public string? Faktuurnr { get; set; }

    public DateTime? Vervdatfak { get; set; }

    public DateTime? Vervdatkrd { get; set; }

    public DateTime? Vervdtkrd2 { get; set; }

    public string? BtwCode { get; set; }

    public double Bedrag { get; set; }

    public double BtwBdr { get; set; }

    public double BtwGrond { get; set; }

    public string? Valcode { get; set; }

    public double Koers { get; set; }

    public double ValBdr { get; set; }

    public double ValbtwBdr { get; set; }

    public string? Verschil { get; set; }

    public string? Kstplcode { get; set; }

    public string? Kstdrcode { get; set; }

    public double Aantal { get; set; }

    public string? Weeknummer { get; set; }

    public string? Betaalref { get; set; }

    public string? Betwijze { get; set; }

    public string? Kredbep { get; set; }

    public double Bdrkredbep { get; set; }

    public double Bdrkredbp2 { get; set; }

    public short? Transbkjr { get; set; }

    public byte Storno { get; set; }

    public string? Exvalcode { get; set; }

    public double Wisselkrs { get; set; }

    public double Koers3 { get; set; }

    public double Exvalbdr { get; set; }

    public double BedrVvaf1 { get; set; }

    public double BedrVvaf2 { get; set; }

    public double BedrVvaf3 { get; set; }

    public double BedrVvaf4 { get; set; }

    public double BedrVvaf5 { get; set; }

    public string? Btwvrtnr { get; set; }

    public string? Levverw { get; set; }

    public string? Betcond { get; set; }

    public byte Vooruitbet { get; set; }

    public string? Resperiod { get; set; }

    public DateTime? Afldat { get; set; }

    public string? BtwNummer { get; set; }

    public string? AdresCd { get; set; }

    public string? AdresNr { get; set; }

    public string? Projmutnr { get; set; }

    public string? VolgnrPfb { get; set; }

    public byte Voucher { get; set; }

    public string? Guids { get; set; }

    public string? NatmovCode { get; set; }

    public string? Docnumber { get; set; }

    public DateTime? Docdate { get; set; }

    public string? Entryorigin { get; set; }

    public int ResId { get; set; }

    public string? Artcode { get; set; }

    public byte Crdnote { get; set; }

    public DateTime Syscreated { get; set; }

    public string? Bankacc { get; set; }

    public string? MatchNr { get; set; }

    public int Syscreator { get; set; }

    public int? Amstext { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Facode { get; set; }

    public string? Transtype { get; set; }

    public string? Transsubtype { get; set; }

    public string? Serialnumber { get; set; }

    public string? Project { get; set; }

    public Guid? DocumentId { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public Guid? CmpWwn { get; set; }

    public byte BlockOutstandingItem { get; set; }

    public Guid? Orderdebtor { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public double? Freefield4 { get; set; }

    public double? Freefield5 { get; set; }

    public string? Warehouse { get; set; }

    public string? PayrollSubtype { get; set; }

    public string? WarehouseLocation { get; set; }

    public Guid? BankTransactionGuid { get; set; }

    public string? CashRegisterAccount { get; set; }

    public string? CompCode { get; set; }

    public string? Unitcode { get; set; }

    public string? Pricelist { get; set; }

    public double? Discount { get; set; }

    public string? Shipment { get; set; }

    public string? IntTransportMethod { get; set; }

    public string? IntPort { get; set; }

    public string? IntSystem { get; set; }

    public string? IntTransA { get; set; }

    public string? IntStatNr { get; set; }

    public string? IntStandardCode { get; set; }

    public string? IntTransShipment { get; set; }

    public string? IntTransB { get; set; }

    public string? IntArea { get; set; }

    public string? IntLandIso { get; set; }

    public string? IntLandDestOrig { get; set; }

    public string? IntDeliveryMethod { get; set; }

    public double? IntStatUnit { get; set; }

    public double? IntWeight { get; set; }

    public byte? PayrollCosts { get; set; }

    public string? TaxCode2 { get; set; }

    public string? TaxCode3 { get; set; }

    public string? TaxCode4 { get; set; }

    public string? TaxCode5 { get; set; }

    public double TaxBasis2 { get; set; }

    public double TaxBasis3 { get; set; }

    public double TaxBasis4 { get; set; }

    public double TaxBasis5 { get; set; }

    public double TaxAmount2 { get; set; }

    public double TaxAmount3 { get; set; }

    public double TaxAmount4 { get; set; }

    public double TaxAmount5 { get; set; }

    public double? StatisticalFactor { get; set; }

    public string? IntLandAssembly { get; set; }

    public string? IbtdeliveryNr { get; set; }

    public short? Division { get; set; }

    public string? TransactionNumber { get; set; }
}
