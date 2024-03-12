using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsagreementSetLine
{
    public Guid Id { get; set; }

    public Guid? AgreementSet { get; set; }

    public int? LineOrder { get; set; }

    public string? AgreementType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? Invoice { get; set; }

    public int? Vatcode { get; set; }

    public double? RateDiscount { get; set; }

    public string? InvoiceFrequency { get; set; }

    public string? ProlongationType { get; set; }

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public string? LongDescription { get; set; }

    public Guid? AgreementDocument { get; set; }

    public string? PartsHoursSelection { get; set; }

    public Guid? PartsHoursGroup { get; set; }

    public Guid? PartsHoursAssortment { get; set; }

    public bool? PartsHoursIncluding { get; set; }

    public double? PartsHoursPercentage { get; set; }

    public Guid? Pricelist { get; set; }

    public Guid? AddPartHour { get; set; }

    public string? AddPartHourType { get; set; }

    public double? AddPartHourQuantity { get; set; }

    public Guid? ResponseTimeId { get; set; }

    public int? ResponseTime { get; set; }

    public string? ResponseTimeUnit { get; set; }

    public string? PrepaidType { get; set; }

    public double? PrepaidAmount { get; set; }

    public double? PrepaidQuantity { get; set; }

    public Guid? PrepaidSet { get; set; }

    public Guid? Pmtype { get; set; }

    public bool? Pmtime { get; set; }

    public double? PmtimeInterval { get; set; }

    public string? PmtimeUnits { get; set; }

    public bool? Pmusage { get; set; }

    public double? PmusageInterval { get; set; }

    public string? PmstartNextRequest { get; set; }

    public DateTime? PmstartTime { get; set; }

    public double? Pmduration { get; set; }

    public string? Pmcontract { get; set; }

    public double? DiscountAmount { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public Guid? Item { get; set; }

    public double? ItemQuantity { get; set; }

    public string? EgpriceList { get; set; }

    public Guid? CostCenter { get; set; }

    public string? CostCenterCode { get; set; }

    public string? CostUnitCode { get; set; }

    public byte IsPercentage { get; set; }

    public double? LineDiscount { get; set; }

    public byte MaintenanceType { get; set; }

    public Guid? DiscountOnAgreement { get; set; }

    public string IndexationStatus { get; set; } = null!;

    public byte IndexationType { get; set; }

    public byte IndexationMonth { get; set; }

    public double IndexationAmountPercentage { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
