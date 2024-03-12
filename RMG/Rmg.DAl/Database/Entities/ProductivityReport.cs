using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ProductivityReport
{
    public int Id { get; set; }

    public string? Division { get; set; }

    public string? Costcenter { get; set; }

    public int Resource { get; set; }

    public string? Project { get; set; }

    public string Activity { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public double BudgetCostsInQty { get; set; }

    public double ActualCostsInQty { get; set; }

    public double BudgetCostsInAmt { get; set; }

    public double ActualCostsInAmt { get; set; }

    public double CapacityOrAvailabilityInQty { get; set; }

    public double AbsenceInQty { get; set; }

    public double BudgetRevenueInQty { get; set; }

    public double ActualRevenueInQty { get; set; }

    public double BudgetRevenueInAmt { get; set; }

    public double ActualRevenueInAmt { get; set; }

    public short? DivisionX { get; set; }

    public string? RequestHid { get; set; }
}
