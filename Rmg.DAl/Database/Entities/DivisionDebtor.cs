using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DivisionDebtor
{
    public Guid DivisionDebtorId { get; set; }

    public string Division { get; set; } = null!;

    public string? Debtor { get; set; }

    public string? DebCode { get; set; }

    public Guid? Account { get; set; }

    public string? CmpStatus { get; set; }

    public DateTime? StatusSince { get; set; }

    public int? CmpAccMan { get; set; }

    public string? Currency { get; set; }

    public string? CentralizationAccount { get; set; }

    public bool? AutoAllocate { get; set; }

    public string? OffSetAccount { get; set; }

    public string? ItemCode { get; set; }

    public double CreditLine { get; set; }

    public string? PaymentCondition { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? PriceList { get; set; }

    public double Discount { get; set; }

    public DateTime? CheckDate { get; set; }

    public string? PurchaseReceipt { get; set; }

    public byte AllowPartialShipment { get; set; }

    public string? DeliveryMethod { get; set; }

    public string? InvoiceDebtor { get; set; }

    public short InvoiceCopies { get; set; }

    public string? InvoiceMethod { get; set; }

    public bool? AttachUbl { get; set; }

    public byte ExtraDuty { get; set; }

    public string? Collect { get; set; }

    public string? PayeeName { get; set; }

    public string? VatLiability { get; set; }

    public string? VatNumber { get; set; }

    public string? VatCode { get; set; }

    public string? VatServices { get; set; }

    public string? CreditabilityScenario { get; set; }

    public int AccountEmployeeId { get; set; }

    public string? IntermediaryAssociateId { get; set; }

    public byte StatementPrint { get; set; }

    public short StatementNumber { get; set; }

    public DateTime? DateLastReminder { get; set; }

    public byte Reminder { get; set; }

    public string? IntrastatSystem { get; set; }

    public string? TransActionA { get; set; }

    public string? Transport { get; set; }

    public bool AddExtraReceiptToOrder { get; set; }

    public bool? IsTaxExempted { get; set; }

    public string? Mailbox { get; set; }

    public bool UseAvalaraTaxation { get; set; }

    public bool? IsCommissionable { get; set; }

    public string? TerritoryCode { get; set; }

    public byte ApplyShippingCharges { get; set; }

    public byte ChangeVatServices { get; set; }

    public string? AvalaraEntityUseCode { get; set; }

    public string? DefaultSelCode { get; set; }

    public byte Attention { get; set; }

    public Guid? CntId { get; set; }

    public short PaymentDay1 { get; set; }

    public short PaymentDay2 { get; set; }

    public short PaymentDay3 { get; set; }

    public short PaymentDay4 { get; set; }

    public short PaymentDay5 { get; set; }

    public string? ExemptNumber { get; set; }

    public string? FiscalCode { get; set; }

    public string? CityOfLoadUnload { get; set; }

    public string? ShipVia { get; set; }

    public string? Region { get; set; }

    public string? StatFactor { get; set; }

    public string? TransActionB { get; set; }

    public string? TransShipment { get; set; }

    public string? DeliveryTerms { get; set; }

    public string? IntRegion { get; set; }

    public string? Status { get; set; }

    public short? DivisionX { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[]? Timestamp { get; set; }
}
