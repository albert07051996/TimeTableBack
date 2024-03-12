using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WbslineVersion
{
    public Guid Id { get; set; }

    public Guid DeliverableVersionId { get; set; }

    public Guid WbslineId { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ProjectNumber { get; set; }

    public string? ItemCode { get; set; }

    public string? Description { get; set; }

    public bool? IsPurchased { get; set; }

    public double? EstimatedCurrent { get; set; }

    public double? Planned { get; set; }

    public double? Submitted { get; set; }

    public double? Actual { get; set; }

    public double? Invoiced { get; set; }

    public double? EstimateToComplete { get; set; }

    public string? CostCurrency { get; set; }

    public double? CostRate { get; set; }

    public double? TotalCost { get; set; }

    public string? TotalCostCurrency { get; set; }

    public string? SalesCurrency { get; set; }

    public double? SalesRate { get; set; }

    public double? TotalSales { get; set; }

    public string? TotalSalesCurrency { get; set; }

    public bool UseTotalAmount { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
