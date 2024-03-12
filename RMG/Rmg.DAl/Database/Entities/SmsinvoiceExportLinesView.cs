using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsinvoiceExportLinesView
{
    public int? InvoiceGroupNumber { get; set; }

    public Guid SmsinvoiceDataId { get; set; }

    public string? Origin { get; set; }

    public string? OriginDescription { get; set; }

    public string? LineType { get; set; }

    public string? LineTypeDescription { get; set; }

    public int? ContractLineNumber { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public double? ItemQuantity { get; set; }

    public string? SerialNumber { get; set; }

    public string? ServiceItem { get; set; }

    public string? ServiceSerialNumber { get; set; }

    public string? DocNumber { get; set; }

    public double? AmountFc { get; set; }

    public string? VatCode { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? DefaultRate { get; set; }

    public string? InvoiceFrequency { get; set; }

    public string? InvoiceFrequencyDescription { get; set; }

    public DateTime? InvoicedUntilDate { get; set; }

    public DateTime? LineStartdate { get; set; }

    public DateTime? LineEnddate { get; set; }

    public string? CostCenterCode { get; set; }

    public string? CostUnitCode { get; set; }

    public string? ProjectNumber { get; set; }

    public int Resource { get; set; }

    public string? ServiceDebtorName { get; set; }

    public string? ServiceAddressLine1 { get; set; }

    public string? ServiceAddressLine2 { get; set; }

    public string? ServiceAddressLine3 { get; set; }

    public string? ServicePostCode { get; set; }

    public string? ServiceCity { get; set; }

    public string? ServiceState { get; set; }

    public string? ServiceCounty { get; set; }

    public string? ServiceCountry { get; set; }

    public string? ServiceContactName { get; set; }

    public string? ServiceContactInitials { get; set; }

    public string? ServiceContactPredCode { get; set; }

    public string? ServiceContactJob { get; set; }

    public string? ServicePhone { get; set; }

    public string? ServiceFax { get; set; }

    public string? AgreementType { get; set; }

    public string? AgreementTypeDescription { get; set; }

    public string? AgreementDetail { get; set; }

    public string? Warehouse { get; set; }
}
