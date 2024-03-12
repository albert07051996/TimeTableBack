using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscontractTemplate
{
    public Guid Id { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public string? ProjectOrigin { get; set; }

    public Guid? Project { get; set; }

    public string? DivisionOrigin { get; set; }

    public Guid? Division { get; set; }

    public Guid? ContractType { get; set; }

    public string? CostCenterOrigin { get; set; }

    public Guid? CostCenter { get; set; }

    public Guid? CostUnit { get; set; }

    public Guid? Account { get; set; }

    public string? ContactOrigin { get; set; }

    public Guid? Contact { get; set; }

    public Guid? Address { get; set; }

    public string? ContactKeyOrigin { get; set; }

    public Guid? ContactKey { get; set; }

    public string? InvoiceAccountOrigin { get; set; }

    public Guid? InvoiceAccount { get; set; }

    public string? InvoicingStatus { get; set; }

    public string? CurrencyOrigin { get; set; }

    public string? Currency { get; set; }

    public string? ServiceInvoiceAccount1Origin { get; set; }

    public Guid? ServiceInvoiceAccount1 { get; set; }

    public string? ServiceInvoiceAccount2Origin { get; set; }

    public Guid? ServiceInvoiceAccount2 { get; set; }

    public string? ServiceInvoiceAccount3Origin { get; set; }

    public Guid? ServiceInvoiceAccount3 { get; set; }

    public string? ServiceInvoiceAccount4Origin { get; set; }

    public Guid? ServiceInvoiceAccount4 { get; set; }

    public string? ServiceInvoiceAccount5Origin { get; set; }

    public Guid? ServiceInvoiceAccount5 { get; set; }

    public string? InvoiceFrequency { get; set; }

    public int? Vatcode { get; set; }

    public string? StartDateOrigin { get; set; }

    public DateTime? StartDate { get; set; }

    public string? EndDateOrigin { get; set; }

    public DateTime? EndDate { get; set; }

    public int? NumberOfDays { get; set; }

    public string? InvoiceLineGrouping { get; set; }

    public string InvoiceLineSorting { get; set; } = null!;

    public short? InvoicingType { get; set; }

    public short? InvoiceDayMonth { get; set; }

    public short? InvoiceDayYear { get; set; }

    public short? InvoiceMonthYear { get; set; }

    public string? DivisionCode { get; set; }

    public string? ProjectNr { get; set; }

    public string? Bedrnr { get; set; }

    public string? SelectionCode { get; set; }

    public string IndexationStatus { get; set; } = null!;

    public byte IndexationType { get; set; }

    public byte IndexationMonth { get; set; }

    public double IndexationAmountPercentage { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
