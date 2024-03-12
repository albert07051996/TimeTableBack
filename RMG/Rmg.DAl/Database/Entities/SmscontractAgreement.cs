using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscontractAgreement
{
    public Guid Id { get; set; }

    public int? LineNumber { get; set; }

    public Guid? ContractHeader { get; set; }

    public string? Type { get; set; }

    public Guid? AgreementSet { get; set; }

    public Guid? Parent { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? InvoicedUntilDate { get; set; }

    public DateTime? OldInvoicedUntilDate { get; set; }

    public int? Vatcode { get; set; }

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

    public int? PartsHoursPriority { get; set; }

    public Guid? PartsHoursPriceList { get; set; }

    public Guid? AddPartHour { get; set; }

    public string? AddPartHourType { get; set; }

    public double? AddPartHourQuantity { get; set; }

    public Guid? ResponseTimeId { get; set; }

    public int? ResponseTime { get; set; }

    public string? ResponseTimeUnit { get; set; }

    public string? PrepaidType { get; set; }

    public double? PrepaidAmount { get; set; }

    public double? PrepaidQuantity { get; set; }

    public double? PrepaidAmountRemaining { get; set; }

    public double? PrepaidQuantityRemaining { get; set; }

    public Guid? PrepaidSet { get; set; }

    public Guid? Pmtype { get; set; }

    public bool? Pmtime { get; set; }

    public double? PmtimeInterval { get; set; }

    public string? PmtimeUnits { get; set; }

    public bool? Pmusage { get; set; }

    public double? PmusageInterval { get; set; }

    public string? PmstartNextRequest { get; set; }

    public string? Pmcontract { get; set; }

    public DateTime? PmstartTime { get; set; }

    public double? Pmduration { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? GeneratedUntilDate { get; set; }

    public DateTime? OldGeneratedUntilDate { get; set; }

    public string? EgpriceList { get; set; }

    public Guid? Item { get; set; }

    public Guid? CostCenter { get; set; }

    public string? CostUnitCode { get; set; }

    public string? CostCenterCode { get; set; }

    public double? ItemQuantity { get; set; }

    public byte MaintenanceType { get; set; }

    public Guid? DiscountOnAgreement { get; set; }

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

    public DateTime? LastIndexedDate { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
