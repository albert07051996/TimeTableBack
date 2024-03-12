using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsinvoiceLine
{
    public Guid Id { get; set; }

    public Guid InvoiceHeaderId { get; set; }

    public int LineNumber { get; set; }

    public string? LineType { get; set; }

    public Guid ItemId { get; set; }

    public string? ItemCode { get; set; }

    public string? Description { get; set; }

    public string? LongDescription { get; set; }

    public double? ItemQuantity { get; set; }

    public double? LineAmountNet { get; set; }

    public double? LineAmountTax { get; set; }

    public double? LineAmountTotal { get; set; }

    public int? Vatcode { get; set; }

    public string? InvoiceComments { get; set; }

    public DateTime? InvoiceStartDate { get; set; }

    public DateTime? InvoiceEndDate { get; set; }

    public string? CostcenterCode { get; set; }

    public string? CostUnitCode { get; set; }

    public string? ProjectNumber { get; set; }

    public Guid? ServiceSerialNumber { get; set; }

    public int? Resource { get; set; }

    public double? ItemPrice { get; set; }

    public double? LineDiscount { get; set; }

    public string? Warehouse { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
