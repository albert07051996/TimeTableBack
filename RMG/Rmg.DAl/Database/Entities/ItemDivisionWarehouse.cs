using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemDivisionWarehouse
{
    public int Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string WarehouseCode { get; set; } = null!;

    public string DivisionCode { get; set; } = null!;

    public string? LocationCode { get; set; }

    public double PurchaseOrderLevel { get; set; }

    public double StockMin { get; set; }

    public double StockMax { get; set; }

    public int DeliveryTimeInDays { get; set; }

    public int ResId { get; set; }

    public double? CostPrice { get; set; }

    public short CountingCycle { get; set; }

    public string? OrderPolicyCode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
