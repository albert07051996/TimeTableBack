using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscostExportView
{
    public string? Division { get; set; }

    public Guid JobDetail { get; set; }

    public int RequestNumber { get; set; }

    public string? Description { get; set; }

    public string? Reference { get; set; }

    public string? Currency { get; set; }

    public string? Costcenter { get; set; }

    public string? Costunit { get; set; }

    public string? Project { get; set; }

    public Guid? Customer { get; set; }

    public string? DebtorCode { get; set; }

    public string? DebtorNumber { get; set; }

    public string? AccountCode { get; set; }

    public int? Resource { get; set; }

    public string? ServiceItem { get; set; }

    public string? ServiceSerialNumber { get; set; }

    public string? CostAccountServiceItem { get; set; }

    public string? StockAccountServiceItem { get; set; }

    public string? Item { get; set; }

    public string? SerialNumber { get; set; }

    public string? Itemtype { get; set; }

    public string? CostAccountItem { get; set; }

    public string? StockAccountItem { get; set; }

    public double? CostPrice { get; set; }

    public double? Quantity { get; set; }

    public string? Warehouse { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Guid? JobHeader { get; set; }

    public Guid? Request { get; set; }
}
