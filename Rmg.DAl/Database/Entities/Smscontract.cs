using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Smscontract
{
    public Guid Id { get; set; }

    public string Number { get; set; } = null!;

    public Guid? Type { get; set; }

    public string? Status { get; set; }

    public Guid? Template { get; set; }

    public Guid? Project { get; set; }

    public Guid? Division { get; set; }

    public Guid? CostCenter { get; set; }

    public Guid? CostUnit { get; set; }

    public Guid? Account { get; set; }

    public Guid? Contact { get; set; }

    public Guid? ContactKey { get; set; }

    public Guid? Address { get; set; }

    public string? InvoicingStatus { get; set; }

    public string? InvoiceFrequencyDefault { get; set; }

    public string? Currency { get; set; }

    public Guid? InvoiceAccount { get; set; }

    public Guid? SopminvoiceAccount1 { get; set; }

    public Guid? SopminvoiceAccount2 { get; set; }

    public Guid? SopminvoiceAccount3 { get; set; }

    public Guid? SopminvoiceAccount4 { get; set; }

    public Guid? SopminvoiceAccount5 { get; set; }

    public DateTime? StartDateDefault { get; set; }

    public DateTime? EndDateDefault { get; set; }

    public int? VatcodeDefault { get; set; }

    public string? InvoiceComments { get; set; }

    public string? InvoiceLineGrouping { get; set; }

    public string InvoiceLineSorting { get; set; } = null!;

    public short? InvoicingType { get; set; }

    public short? InvoiceDayMonth { get; set; }

    public short? InvoiceDayYear { get; set; }

    public short? InvoiceMonthYear { get; set; }

    public string? ProjectNr { get; set; }

    public string? DivisionCode { get; set; }

    public int? TransactionId { get; set; }

    public string LockType { get; set; } = null!;

    public DateTime? LockDate { get; set; }

    public DateTime? LastProlongedDate { get; set; }

    public DateTime? LastIndexedDate { get; set; }

    public string? TransactionStatus { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? SelectionCode { get; set; }

    public string? PaymentCondition { get; set; }

    public string? TextField1 { get; set; }

    public string? TextField2 { get; set; }

    public string? TextField3 { get; set; }

    public string? TextField4 { get; set; }

    public string? TextField5 { get; set; }

    public string? TextField6 { get; set; }

    public string? TextField7 { get; set; }

    public string? TextField8 { get; set; }

    public string? TextField9 { get; set; }

    public string? TextField10 { get; set; }

    public int? NumberIntField1 { get; set; }

    public int? NumberIntField2 { get; set; }

    public int? NumberIntField3 { get; set; }

    public int? NumberIntField4 { get; set; }

    public int? NumberIntField5 { get; set; }

    public int? NumberIntField6 { get; set; }

    public int? NumberIntField7 { get; set; }

    public int? NumberIntField8 { get; set; }

    public int? NumberIntField9 { get; set; }

    public int? NumberIntField10 { get; set; }

    public bool? BoolField1 { get; set; }

    public bool? BoolField2 { get; set; }

    public bool? BoolField3 { get; set; }

    public bool? BoolField4 { get; set; }

    public bool? BoolField5 { get; set; }

    public bool? BoolField6 { get; set; }

    public bool? BoolField7 { get; set; }

    public bool? BoolField8 { get; set; }

    public bool? BoolField9 { get; set; }

    public bool? BoolField10 { get; set; }

    public double? NumberField1 { get; set; }

    public double? NumberField2 { get; set; }

    public double? NumberField3 { get; set; }

    public double? NumberField4 { get; set; }

    public double? NumberField5 { get; set; }

    public double? NumberField6 { get; set; }

    public double? NumberField7 { get; set; }

    public double? NumberField8 { get; set; }

    public double? NumberField9 { get; set; }

    public double? NumberField10 { get; set; }

    public DateTime? DateField1 { get; set; }

    public DateTime? DateField2 { get; set; }

    public DateTime? DateField3 { get; set; }

    public DateTime? DateField4 { get; set; }

    public DateTime? DateField5 { get; set; }

    public DateTime? DateField6 { get; set; }

    public DateTime? DateField7 { get; set; }

    public DateTime? DateField8 { get; set; }

    public DateTime? DateField9 { get; set; }

    public DateTime? DateField10 { get; set; }

    public string IndexationStatus { get; set; } = null!;

    public byte IndexationType { get; set; }

    public byte IndexationMonth { get; set; }

    public double IndexationAmountPercentage { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
