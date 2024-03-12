using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsinvoiceScheduleView
{
    public string Origin { get; set; } = null!;

    public Guid? ContractRate { get; set; }

    public Guid? Agreement { get; set; }

    public Guid? ContractItem { get; set; }

    public Guid? AgreementLink { get; set; }

    public bool? Invoice { get; set; }

    public string? InvoiceFrequency { get; set; }

    public double? RateDiscount { get; set; }

    public double? InvoiceRate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Vatcode { get; set; }

    public DateTime? InvoicedUntil { get; set; }

    public int? LineNumber { get; set; }

    public Guid? Contract { get; set; }

    public string? ContractNumber { get; set; }

    public string? ContractStatus { get; set; }

    public string? CostCenter { get; set; }

    public Guid? ContractType { get; set; }

    public string? ContractInvoicingStatus { get; set; }

    public Guid? Account { get; set; }

    public Guid? InvoiceAccount { get; set; }

    public Guid? ServiceAddress { get; set; }

    public Guid? Division { get; set; }

    public string? Currency { get; set; }

    public string? LineType { get; set; }

    public string? AgreementType { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public Guid? Configuration { get; set; }

    public Guid? ServiceItem { get; set; }

    public Guid? ServiceSerialNumber { get; set; }

    public Guid? PartItem { get; set; }

    public Guid? PartSerialNumber { get; set; }

    public double? Quantity { get; set; }

    public Guid? JobDetail { get; set; }

    public Guid? JobHeader { get; set; }

    public Guid? Absence { get; set; }

    public int? RequestNumber { get; set; }

    public int? ActivityStatus { get; set; }

    public bool? Preventive { get; set; }

    public bool? EarlyInvoicing { get; set; }

    public short? InvoicingType { get; set; }

    public short? InvoiceDayMonth { get; set; }

    public short? InvoiceDayYear { get; set; }

    public short? InvoiceMonthYear { get; set; }

    public string? CostUnit { get; set; }

    public double? LineDiscount { get; set; }

    public string? LongDescription { get; set; }

    public DateTime? ItemStartDate { get; set; }

    public DateTime? ItemEndDate { get; set; }

    public DateTime? ConfigStartDate { get; set; }

    public DateTime? ConfigEndDate { get; set; }

    public DateTime? InvoicedUntilProposal { get; set; }

    public string? ContractTypeCode { get; set; }
}
