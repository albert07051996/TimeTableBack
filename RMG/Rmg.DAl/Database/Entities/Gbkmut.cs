﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Gbkmut
{
    public int Id { get; set; }

    public short? Bkjrcode { get; set; }

    public string? Reknr { get; set; }

    public DateTime? Datum { get; set; }

    public string? Periode { get; set; }

    public string? Bkstnr { get; set; }

    public string? Dagbknr { get; set; }

    public string? Oms25 { get; set; }

    public double BdrHfl { get; set; }

    public string? BtwCode { get; set; }

    public double BtwBdr3 { get; set; }

    public double BtwGrond { get; set; }

    public string? Tegreknr { get; set; }

    public string? Debnr { get; set; }

    public string? Crdnr { get; set; }

    public string? Kstplcode { get; set; }

    public string? Kstdrcode { get; set; }

    public double Aantal { get; set; }

    public string? Valcode { get; set; }

    public string? Exvalcode { get; set; }

    public double Koers { get; set; }

    public double Wisselkrs { get; set; }

    public double Koers3 { get; set; }

    public double BdrVal { get; set; }

    public int DbkVerwnr { get; set; }

    public int Verwerknrl { get; set; }

    public string? Volgnr5 { get; set; }

    public string? Regel { get; set; }

    public string? Regelcode { get; set; }

    public byte Storno { get; set; }

    public string? BkstnrSub { get; set; }

    public string? Betcond { get; set; }

    public double Btwper { get; set; }

    public string? Oorsprong { get; set; }

    public string? VlgnGbk2 { get; set; }

    public double BtwGrval { get; set; }

    public DateTime? Afldat { get; set; }

    public string? Docnumber { get; set; }

    public DateTime? Docdate { get; set; }

    public double Exvalbdr { get; set; }

    public string? Entryorigin { get; set; }

    public DateTime? Vervdatkrd { get; set; }

    public DateTime? Vervdtkrd2 { get; set; }

    public DateTime? Vervdatfak { get; set; }

    public string? Kredbep { get; set; }

    public double Bdrkredbep { get; set; }

    public double Bdrkredbp2 { get; set; }

    public string? Betaalref { get; set; }

    public short StatNr { get; set; }

    public string? BtwNummer { get; set; }

    public string? Rapnr { get; set; }

    public string? Raplist { get; set; }

    public string? Artcode { get; set; }

    public string? Faktuurnr { get; set; }

    public string? BudVers { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public int ReminderCount { get; set; }

    public DateTime Sysmodified { get; set; }

    public int ReminderLayout { get; set; }

    public DateTime? LastReminderDate { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte BlockItem { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? CompanyCode { get; set; }

    public int ResId { get; set; }

    public int TransactionType { get; set; }

    public string? CurrencyCode { get; set; }

    public double Rate { get; set; }

    public string? Bankacc { get; set; }

    public double AmountCentral { get; set; }

    public double VatBaseAmountCentral { get; set; }

    public string? PaymentMethod { get; set; }

    public double VatAmountCentral { get; set; }

    public string? CurrencyAliasAc { get; set; }

    public Guid? DocumentId { get; set; }

    public string? Facode { get; set; }

    public string? Transtype { get; set; }

    public string? Transsubtype { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public double? Freefield4 { get; set; }

    public double? Freefield5 { get; set; }

    public string? Project { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public Guid? CmpWwn { get; set; }

    public string? Warehouse { get; set; }

    public Guid? Orderdebtor { get; set; }

    public string? PayrollSubtype { get; set; }

    public int? ReconcileNumber { get; set; }

    public string? WarehouseLocation { get; set; }

    public Guid? EntryGuid { get; set; }

    public Guid? TransactionGuid { get; set; }

    public Guid? TransactionGuid2 { get; set; }

    public byte Checked { get; set; }

    public byte Reviewed { get; set; }

    public Guid? BankTransactionGuid { get; set; }

    public string? StockTrackingNumber { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? ReportingDate { get; set; }

    public string? CashRegisterAccount { get; set; }

    public double? OriginalQuantity { get; set; }

    public string? CompCode { get; set; }

    public string? Selcode { get; set; }

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

    public byte? IntComplete { get; set; }

    public Guid? LinkedLine { get; set; }

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

    public byte? Backflush { get; set; }

    public string? LastReminderLayout { get; set; }

    public string? Correction { get; set; }

    public string? IbtdeliveryNr { get; set; }

    public string? Routing { get; set; }

    public int? Step { get; set; }

    public string? Reasoncode { get; set; }

    public string? TransactionNumber { get; set; }

    public short? Type { get; set; }

    public byte? Status { get; set; }

    public int? UniqueSeqNo { get; set; }

    public byte? CompleteOperation { get; set; }

    public string? ImSerialNr { get; set; }

    public string? ImportationNr { get; set; }

    public string? RevaluationCurrency { get; set; }

    public short? LineType { get; set; }

    public string? Operation { get; set; }

    public string? ExternalNumber { get; set; }

    public long? ExternalNumberRecordId { get; set; }

    public short? Division { get; set; }
}
