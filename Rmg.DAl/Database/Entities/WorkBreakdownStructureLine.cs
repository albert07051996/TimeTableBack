using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WorkBreakdownStructureLine
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }

    public string? ProjectNumber { get; set; }

    public string? DeliverableCode { get; set; }

    public string? ItemCode { get; set; }

    public Guid? CustomerId { get; set; }

    public double? Hours { get; set; }

    public double? EstimatedCurrent { get; set; }

    public double? ItemCount { get; set; }

    public string? SalesCurrency { get; set; }

    public double? SalesAmount { get; set; }

    public double? SalesAmountFc { get; set; }

    public string? Currency { get; set; }

    public double? Amount { get; set; }

    public double? AmountFc { get; set; }

    public int BillCustomer { get; set; }

    public byte RegisterCost { get; set; }

    public bool? IsPurchased { get; set; }

    public bool? UseTotalAmount { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
