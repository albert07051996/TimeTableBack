using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ProjectItemRate
{
    public Guid Id { get; set; }

    public int? BudgetLine { get; set; }

    public Guid? Wbsline { get; set; }

    public double SalesPrice { get; set; }

    public double SalesPriceFc { get; set; }

    public string SalesPriceCurrency { get; set; } = null!;

    public byte SalesPriceRateType { get; set; }

    public Guid? SalesPriceRateId { get; set; }

    public DateTime SalesPriceStartDate { get; set; }

    public DateTime? SalesPriceEndDate { get; set; }

    public double MarkupPercentage { get; set; }

    public byte? MarkupCostRateType { get; set; }

    public bool UseMarkUp { get; set; }

    public double Cost { get; set; }

    public double CostFc { get; set; }

    public string CostCurrency { get; set; } = null!;

    public byte CostRateType { get; set; }

    public Guid? CostRateId { get; set; }

    public DateTime CostStartDate { get; set; }

    public DateTime? CostEndDate { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
