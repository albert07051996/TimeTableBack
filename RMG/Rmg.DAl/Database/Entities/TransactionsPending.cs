using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TransactionsPending
{
    public string CompanyCode { get; set; } = null!;

    public int TransactionType { get; set; }

    public DateTime TransactionDate { get; set; }

    public int? FinYear { get; set; }

    public int? FinPeriod { get; set; }

    public string? Description { get; set; }

    public string? CompanyAccountCode { get; set; }

    public string? CompanyContraAccountCode { get; set; }

    public string? EntryNumber { get; set; }

    public string? Invoice { get; set; }

    public string? JournalNumber { get; set; }

    public int? JournalType { get; set; }

    public string? DebtorCode { get; set; }

    public string? CreditorCode { get; set; }

    public string? CompanyCostcenterCode { get; set; }

    public string? CompanyCostunitCode { get; set; }

    public string? CurrencyCode { get; set; }

    public double Rate { get; set; }

    public double AmountDebit { get; set; }

    public double AmountCredit { get; set; }

    public double VatbaseAmount { get; set; }

    public double Vatamount { get; set; }

    public string? CurrencyAliasAc { get; set; }

    public double AmountDebitAc { get; set; }

    public double AmountCreditAc { get; set; }

    public double VatbaseAmountAc { get; set; }

    public double VatamountAc { get; set; }

    public string? CurrencyAliasFc { get; set; }

    public double RateFc { get; set; }

    public double AmountDebitFc { get; set; }

    public double AmountCreditFc { get; set; }

    public double VatbaseAmountFc { get; set; }

    public string? CompanyCodeFrom { get; set; }

    public string? CompanyCodeTo { get; set; }

    public string? Vatcode { get; set; }

    public double Vatpercentage { get; set; }

    public string? PaymentTermCode { get; set; }

    public bool IsStorno { get; set; }

    public double Quantity { get; set; }

    public int ProcessNumber { get; set; }

    public int ProcessOrder { get; set; }

    public int ProcessLine { get; set; }

    public string? ProcessLineCode { get; set; }

    public bool TransactionClosed { get; set; }

    public bool TransactionValid { get; set; }

    public DateTime TransactionImported { get; set; }

    public int? ResId { get; set; }

    public Guid? DocumentId { get; set; }

    public int Id { get; set; }

    public double BdrHfl { get; set; }

    public string? Exvalcode { get; set; }

    public double Wisselkrs { get; set; }

    public double Koers3 { get; set; }

    public double BdrVal { get; set; }

    public int DbkVerwnr { get; set; }

    public string? Oorsprong { get; set; }

    public string? VlgnGbk2 { get; set; }

    public DateTime? Afldat { get; set; }

    public string? Docnumber { get; set; }

    public DateTime? Docdate { get; set; }

    public int Entryid { get; set; }

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

    public string? Bankacc { get; set; }

    public string? PaymentMethod { get; set; }

    public Guid? Account { get; set; }

    public string? Facode { get; set; }

    public string? Transtype { get; set; }

    public string? Transsubtype { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public double? Freefield4 { get; set; }

    public double? Freefield5 { get; set; }

    public string? Serialnumber { get; set; }

    public string? Project { get; set; }

    public int Status { get; set; }

    public string? Message { get; set; }

    public DateTime ImportDate { get; set; }

    public Guid? Orderdebtor { get; set; }

    public string? Warehouse { get; set; }

    public string? PayrollSubtype { get; set; }

    public int? ReconcileNumber { get; set; }

    public string? WarehouseLocation { get; set; }

    public Guid? EntryGuid { get; set; }

    public Guid? TransactionGuid { get; set; }

    public Guid? TransactionGuid2 { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public Guid? BankTransactionGuid { get; set; }

    public byte Checked { get; set; }

    public byte Reviewed { get; set; }

    public string? CashRegisterAccount { get; set; }

    public string? StockTrackingNumber { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? ReportingDate { get; set; }

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

    public string? IntLandAssembly { get; set; }

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

    public short? Division { get; set; }
}
