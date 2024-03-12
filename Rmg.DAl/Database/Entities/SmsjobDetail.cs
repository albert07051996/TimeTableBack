using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsjobDetail
{
    public Guid Id { get; set; }

    public Guid? JobHeader { get; set; }

    public string? Type { get; set; }

    public DateTime? PmstartDateOriginal { get; set; }

    public double? HoursRequired { get; set; }

    public string? EntryType { get; set; }

    public string? PartType { get; set; }

    public int? Resource { get; set; }

    public Guid? Item { get; set; }

    public Guid? SerialNumber { get; set; }

    public double? Quantity { get; set; }

    public Guid? Warehouse { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? CostPrice { get; set; }

    public double? UnitPrice { get; set; }

    public double? DiscountPercentage { get; set; }

    public Guid? Phagreement { get; set; }

    public Guid? AddPhagreement { get; set; }

    public double? NetPrice { get; set; }

    public bool? NoCharge { get; set; }

    public double? Amount { get; set; }

    public short? InvoiceTo { get; set; }

    public Guid? InvoiceAccount { get; set; }

    public string? Notes { get; set; }

    public bool? Realized { get; set; }

    public bool? CostsExported { get; set; }

    public bool? InvoiceExported { get; set; }

    public string? CostEntryReference { get; set; }

    public Guid? PlanningId { get; set; }

    public bool? Authorized { get; set; }

    public bool? ActualRealization { get; set; }

    public int? ServiceOrderLine { get; set; }

    public int? EgcommunicationStatus { get; set; }

    public string? EgerrorMessage { get; set; }

    public string? ItemCode { get; set; }

    public string? WarehouseCode { get; set; }

    public bool? Signed { get; set; }

    public Guid? LineReference { get; set; }

    public string? CostcenterCode { get; set; }

    public string? CostUnitCode { get; set; }

    public bool? IsTextItem { get; set; }

    public string? LongDescription { get; set; }

    public int? WorkEvaluationScore { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public int SmslineId { get; set; }
}
