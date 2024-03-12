﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankTransaction
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? OwnBankAccount { get; set; }

    public int? BatchNumber { get; set; }

    public string? TransactionType { get; set; }

    public string? TransactionNumber { get; set; }

    public string? Status { get; set; }

    public string? PaymentMethod { get; set; }

    public string? CreditorNumber { get; set; }

    public string? DebtorNumber { get; set; }

    public double? ExchangeRate { get; set; }

    public string? Tccode { get; set; }

    public double? AmountDc { get; set; }

    public double? AmountTc { get; set; }

    public string? OffsetBankCountry { get; set; }

    public string? OffsetName { get; set; }

    public string? OffsetAddressLine1 { get; set; }

    public string? OffsetAddressLine2 { get; set; }

    public string? OffsetAddressLine3 { get; set; }

    public string? OffsetBankAccount { get; set; }

    public string? OffsetPostalCode { get; set; }

    public string? OffsetCity { get; set; }

    public string? OffsetReference { get; set; }

    public string? OffsetCountryCode { get; set; }

    public string? OffsetBankName { get; set; }

    public string? OffsetBankSwiftcode { get; set; }

    public string? OwnReference { get; set; }

    public string? Description { get; set; }

    public byte? Blocked { get; set; }

    public DateTime? ProcessingDate { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? StatementType { get; set; }

    public DateTime? StatementDate { get; set; }

    public string? StatementNumber { get; set; }

    public string? StatementLineNumber { get; set; }

    public DateTime? ValueDate { get; set; }

    public string? FileName { get; set; }

    public string? LedgerAccount { get; set; }

    public string? OffsetLedgerAccountNumber { get; set; }

    public string? EntryNumber { get; set; }

    public string? SupplierInvoiceNumber { get; set; }

    public DateTime? DueDate { get; set; }

    public int? HumanResourceId { get; set; }

    public int? MatchId { get; set; }

    public string? OffsetIdentificationNumberBank { get; set; }

    public string? PaymentType { get; set; }

    public string? Bedrnr { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public byte? Prepayment { get; set; }

    public string? PaymentCondition { get; set; }

    public string? OrderNumber { get; set; }

    public string? InvoiceCode { get; set; }

    public string? SequenceNumber { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public int Approver { get; set; }

    public DateTime? Approved { get; set; }

    public string? Vatcode { get; set; }

    public int? Processor { get; set; }

    public DateTime? Processed { get; set; }

    public int? Approver2 { get; set; }

    public DateTime? Approved2 { get; set; }

    public int? Journalizer { get; set; }

    public DateTime? Journalized { get; set; }

    public double TermPercentage { get; set; }

    public DateTime? DepositDate { get; set; }

    public int? DepositNumber { get; set; }

    public int? PaymentDays { get; set; }

    public Guid? DocumentId { get; set; }

    public string? Warehouse { get; set; }

    public string? ExtraCurrencyCode { get; set; }

    public double ExtraCurrencyAmount { get; set; }

    public string? InstrumentStatus { get; set; }

    public int? InstrumentReference { get; set; }

    public string? InstrumentBank { get; set; }

    public int MaturityDays { get; set; }

    public string? OwnBankAccountRef { get; set; }

    public string? AdvanceInvoiceNumber { get; set; }

    public Guid? CntId { get; set; }

    public DateTime? TaxInvoiceDate { get; set; }

    public string? TaxInvoiceNumber { get; set; }

    public string? CreditCardTransId { get; set; }

    public string? CreditCardResult { get; set; }

    public string? CreditCardAuthCode { get; set; }

    public int? LinkId { get; set; }

    public bool ImportAutoMatch { get; set; }

    public DateTime? ReportingDate { get; set; }

    public string? Officenumber { get; set; }

    public string? Contractnumber { get; set; }

    public string? ExternalNumber { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
