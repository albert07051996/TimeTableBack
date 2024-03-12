using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HourEntryDraft
{
    public Guid Id { get; set; }

    public int EmpId { get; set; }

    public int Type { get; set; }

    public string? ProjectNumber { get; set; }

    public Guid? CustomerId { get; set; }

    public string? ItemCode { get; set; }

    public DateTime? StartDate { get; set; }

    public double? Hours { get; set; }

    public double? HoursActual { get; set; }

    public double? AmountFcactual { get; set; }

    public double? Quantity { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public double? ItemCount { get; set; }

    public double? ItemCountActual { get; set; }

    public string? Product { get; set; }

    public string? Currency { get; set; }

    public Guid? CapacityPlanningRequest { get; set; }

    public Guid? WorkBreakdownStructureLine { get; set; }

    public int? BudgetLine { get; set; }

    public Guid? DocumentId { get; set; }

    public byte? RegisterCost { get; set; }

    public Guid? Supplier { get; set; }

    public double? AmountFc { get; set; }

    public DateTime? Modified { get; set; }

    public int? Modifier { get; set; }

    public DateTime? Created { get; set; }

    public int? Creator { get; set; }
}
