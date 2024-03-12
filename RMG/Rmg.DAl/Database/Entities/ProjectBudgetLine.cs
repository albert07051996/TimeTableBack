using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ProjectBudgetLine
{
    public int Id { get; set; }

    public string ProjectNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Type { get; set; } = null!;

    public double? Amount { get; set; }

    public string? Currency { get; set; }

    public double? AmountFc { get; set; }

    public double? CostAmount { get; set; }

    public string? CostCurrency { get; set; }

    public double? CostAmountFc { get; set; }

    public string? Itemcode { get; set; }

    public double? Quantity { get; set; }

    public string? Description { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public bool? IsPurchased { get; set; }
}
