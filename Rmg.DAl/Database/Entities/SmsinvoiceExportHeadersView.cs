using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsinvoiceExportHeadersView
{
    public int? InvoiceGroupNumber { get; set; }

    public string? Division { get; set; }

    public string? InvoiceCode { get; set; }

    public string? Currency { get; set; }

    public string Refer { get; set; } = null!;

    public string? OrderDebtorCode { get; set; }

    public string? OrderDebtorNumber { get; set; }

    public string? OrderAccountCode { get; set; }

    public string? InvoiceDebtorCode { get; set; }

    public string? InvoiceDebtorNumber { get; set; }

    public string? InvoiceAccountCode { get; set; }

    public string? CostCenterCode { get; set; }

    public int Resource { get; set; }

    public string? OrderContactName { get; set; }

    public string? OrderContactInitials { get; set; }

    public string? OrderContactTitle { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? ServiceDebtorName { get; set; }

    public string? ServiceAddressLine1 { get; set; }

    public string? ServiceAddressLine2 { get; set; }

    public string? ServiceAddressLine3 { get; set; }

    public string? ServicePostCode { get; set; }

    public string? ServiceCity { get; set; }

    public string? ServiceStateCode { get; set; }

    public string? ServiceCounty { get; set; }

    public string? ServiceCountryCode { get; set; }

    public string? ServiceContactName { get; set; }

    public string? ServiceContactInitials { get; set; }

    public string? ServiceContactTitle { get; set; }

    public string? ServiceContactJob { get; set; }

    public string? ServicePhone { get; set; }

    public string? ServiceFax { get; set; }

    public string? InvoiceDebtorName { get; set; }

    public string? InvoiceAddressLine1 { get; set; }

    public string? InvoiceAddressLine2 { get; set; }

    public string? InvoiceAddressLine3 { get; set; }

    public string? InvoicePostCode { get; set; }

    public string? InvoiceCity { get; set; }

    public string? InvoiceStateCode { get; set; }

    public string? InvoiceCounty { get; set; }

    public string? InvoiceCountryCode { get; set; }

    public string? InvoiceContactName { get; set; }

    public string? InvoiceContactInitials { get; set; }

    public string? InvoiceContactTitle { get; set; }

    public string? InvoiceContactJob { get; set; }

    public string? InvoicePhone { get; set; }

    public string? InvoiceFax { get; set; }
}
