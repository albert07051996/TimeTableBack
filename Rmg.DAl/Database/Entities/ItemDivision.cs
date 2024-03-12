using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemDivision
{
    public int Id { get; set; }

    public string DivisionCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string? GlaccountRevenue { get; set; }

    public string? GlaccountCost { get; set; }

    public string? GlaccountDistribution { get; set; }

    public string? GlaccountAsset { get; set; }

    public string? SalesVatCode { get; set; }

    public string? PurchaseVatCode { get; set; }

    public int TaxItemClassification { get; set; }

    public byte RequiresApprovedSupplier { get; set; }

    public bool? IsCommissionable { get; set; }

    public string CommissionMethod { get; set; } = null!;

    public double? CommissionValue { get; set; }

    public string? GlaccountDiscount { get; set; }

    public bool IntrastatEnabled { get; set; }

    public double? StatisticalUnits { get; set; }

    public int Shelflife { get; set; }

    public int Warranty { get; set; }

    public string? SerialBatchMask { get; set; }

    public int? IncrementFactor { get; set; }

    public string? LinkItemCode { get; set; }

    public string? WareHouse { get; set; }

    public string? Status { get; set; }

    public byte IsBatchItem { get; set; }

    public bool IsSalesItem { get; set; }

    public bool IsPurchaseItem { get; set; }

    public bool IsServiceItem { get; set; }

    public bool IsTextItem { get; set; }

    public bool IsSerialNumberItem { get; set; }

    public bool IsStockItem { get; set; }

    public bool IsSubAssemblyItem { get; set; }

    public byte IsAssembled { get; set; }

    public byte IsDiscount { get; set; }

    public byte IsExplode { get; set; }

    public string? OrderPolicyCode { get; set; }

    public string? ItemCodeReplacement { get; set; }

    public string? StatisticalNumber { get; set; }

    public double? NetWeight { get; set; }

    public int Assortment { get; set; }

    public bool IsFractionAllowedItem { get; set; }

    public double CostPriceStandard { get; set; }

    public bool AddExtraReceiptToOrder { get; set; }

    public bool IsBackOrderItem { get; set; }

    public string? Condition { get; set; }

    public string? TextDescription { get; set; }

    public double? FreeValue1 { get; set; }

    public double? FreeValue2 { get; set; }

    public double? SalesPackagePrice { get; set; }

    public string? GlaccountStkChange { get; set; }

    public string? GlaccountStkCoverage { get; set; }

    public DateTime? AvailableFrom { get; set; }

    public DateTime? AvailableUntil { get; set; }

    public short? Division { get; set; }
}
