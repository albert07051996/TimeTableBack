using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsinvoiceDatum
{
    public Guid Id { get; set; }

    public int? InvoiceGroupNumber { get; set; }

    public bool? Released { get; set; }

    public Guid? Division { get; set; }

    public string? Currency { get; set; }

    public Guid? Account { get; set; }

    public Guid? InvoiceAccount { get; set; }

    public Guid? ServiceAddress { get; set; }

    public string? Origin { get; set; }

    public Guid? Contract { get; set; }

    public Guid? ServiceActivity { get; set; }

    public string? LineType { get; set; }

    public Guid? ServiceItem { get; set; }

    public Guid? ServiceSerialNumber { get; set; }

    public Guid? PartItem { get; set; }

    public Guid? PartSerialNumber { get; set; }

    public double? Quantity { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? LineAmountNet { get; set; }

    public double? LineAmountTax { get; set; }

    public double? LineAmountTotal { get; set; }

    public bool? Blocked { get; set; }

    public string? ContractInvoicingStatus { get; set; }

    public Guid? ContractRate { get; set; }

    public Guid? Agreement { get; set; }

    public string? InvoiceFrequency { get; set; }

    public Guid? ContractItem { get; set; }

    public Guid? AgreementLink { get; set; }

    public int? Vatcode { get; set; }

    public Guid? JobDetail { get; set; }

    public Guid? JobHeader { get; set; }

    public bool? Preventive { get; set; }

    public bool? EarlyInvoicing { get; set; }

    public short? MessageCode { get; set; }

    public bool? InvoiceExported { get; set; }

    public int? InvoiceNumberBackOffice { get; set; }

    public Guid? InvoiceHeaderId { get; set; }

    public Guid? InvoiceLineId { get; set; }

    public string? DivisionCode { get; set; }

    public string? CostcenterCode { get; set; }

    public string? CostUnitCode { get; set; }

    public string? SelectionCode { get; set; }

    public string? PaymentCondition { get; set; }

    public int? InvoiceGroup { get; set; }

    public double? LineDiscount { get; set; }

    public string? LongDescription { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
