using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Item
{
    public int Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Description { get; set; }

    public int SecurityLevel { get; set; }

    public string? Type { get; set; }

    public int Assortment { get; set; }

    public string? Class01 { get; set; }

    public string? Class02 { get; set; }

    public string? Class03 { get; set; }

    public string? Class04 { get; set; }

    public string? Class05 { get; set; }

    public string? Class06 { get; set; }

    public string? Class07 { get; set; }

    public string? Class08 { get; set; }

    public string? Class09 { get; set; }

    public string? Class10 { get; set; }

    public bool IsSalesItem { get; set; }

    public bool IsPurchaseItem { get; set; }

    public bool IsServiceItem { get; set; }

    public bool IsTextItem { get; set; }

    public bool IsStockItem { get; set; }

    public bool IsSerialNumberItem { get; set; }

    public bool IsSubAssemblyItem { get; set; }

    public bool IsPriceRegulationItem { get; set; }

    public bool IsBackOrderItem { get; set; }

    public bool IsFractionAllowedItem { get; set; }

    public bool IsPrintItem { get; set; }

    public string? Eancode { get; set; }

    public string? Barcode { get; set; }

    public string? BarcodeType { get; set; }

    public string? StockCurrency { get; set; }

    public int? StockValuationType { get; set; }

    public DateTime? StockValuationDate { get; set; }

    public string? WareHouse { get; set; }

    public string? WareHouseLocation { get; set; }

    public string? CostPriceCurrency { get; set; }

    public double CostPriceCalculated { get; set; }

    public double CostPriceCalculatedManually { get; set; }

    public double CostPriceStandard { get; set; }

    public string? PurchaseCurrency { get; set; }

    public double PurchasePrice { get; set; }

    public double PurchaseVatperc { get; set; }

    public bool PurchaseVatincl { get; set; }

    public int SalesPriceType { get; set; }

    public string? DimensionsInText { get; set; }

    public string? WeightInText { get; set; }

    public byte[]? Picture { get; set; }

    public string? PictureFilename { get; set; }

    public string? UserField01 { get; set; }

    public string? UserField02 { get; set; }

    public string? UserField03 { get; set; }

    public string? UserField04 { get; set; }

    public string? UserField05 { get; set; }

    public string? UserField06 { get; set; }

    public string? UserField07 { get; set; }

    public string? UserField08 { get; set; }

    public string? UserField09 { get; set; }

    public string? UserField10 { get; set; }

    public DateTime? UserDate01 { get; set; }

    public DateTime? UserDate02 { get; set; }

    public DateTime? UserDate03 { get; set; }

    public DateTime? UserDate04 { get; set; }

    public DateTime? UserDate05 { get; set; }

    public double? UserNumber01 { get; set; }

    public double? UserNumber02 { get; set; }

    public double? UserNumber03 { get; set; }

    public double? UserNumber04 { get; set; }

    public double? UserNumber05 { get; set; }

    public bool UserYesNo01 { get; set; }

    public bool UserYesNo02 { get; set; }

    public bool UserYesNo03 { get; set; }

    public bool UserYesNo04 { get; set; }

    public bool UserYesNo05 { get; set; }

    public int RegulationType { get; set; }

    public double RegulationFixedAmount { get; set; }

    public double RegulationAmount { get; set; }

    public string? RegulationCurrency { get; set; }

    public double RegulationPercentage { get; set; }

    public string? RegulationItemsIncluded { get; set; }

    public string? RegulationItemsExcluded { get; set; }

    public int RegulationPriority { get; set; }

    public string? ItemCodeReplacement { get; set; }

    public string? ItemType { get; set; }

    public byte IsAssembled { get; set; }

    public string? SearchCode { get; set; }

    public string? EenhVerk { get; set; }

    public double? AantVerp { get; set; }

    public double? SalesPackagePrice { get; set; }

    public string? PurchaseOrderAdviceCode { get; set; }

    public string? SalesVatCode { get; set; }

    public string? PurchaseVatCode { get; set; }

    public string? StatisticalNumber { get; set; }

    public string? PackageDescription { get; set; }

    public string? SerialBatchItem { get; set; }

    public byte IsBatchItem { get; set; }

    public byte IsBackToBackOrder { get; set; }

    public double? UserNumber06 { get; set; }

    public double? UserNumber07 { get; set; }

    public double? UserNumber08 { get; set; }

    public string? PurchaseFactor { get; set; }

    public string? SalesFactor { get; set; }

    public double? StatisticalUnits { get; set; }

    public double? NetWeight { get; set; }

    public double? GrossWeight { get; set; }

    public string? ExtraDutyVatcode { get; set; }

    public double? SalesMarginPercent { get; set; }

    public string? Status { get; set; }

    public string? Condition { get; set; }

    public byte IsDiscount { get; set; }

    public byte IsExplode { get; set; }

    public byte IsCentralItem { get; set; }

    public string? LevCrdnr { get; set; }

    public double Percentage1 { get; set; }

    public double Percentage2 { get; set; }

    public string? Description0 { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? Description3 { get; set; }

    public string? Description4 { get; set; }

    public string? LongDescription { get; set; }

    public string? TextDescription { get; set; }

    public string? GlaccountRevenue { get; set; }

    public string? GlaccountCost { get; set; }

    public string? GlaccountDistribution { get; set; }

    public string? GlaccountAsset { get; set; }

    public int LevelCode { get; set; }

    public short CountingCycle { get; set; }

    public byte RequiresApprovedSupplier { get; set; }

    public string? OrderPolicyCode { get; set; }

    public int PeriodOrderDays { get; set; }

    public double? StatisticalFactorSales { get; set; }

    public double? StatisticalFactorPurchase { get; set; }

    public int TaxItemClassification { get; set; }

    public double? UserNumber09 { get; set; }

    public double? UserNumber10 { get; set; }

    public double? UserNumber11 { get; set; }

    public double? UserNumber12 { get; set; }

    public double? UserNumber13 { get; set; }

    public string? ConfigurationClass { get; set; }

    public string? ConfigurationModel { get; set; }

    public string? ValuationMethod { get; set; }

    public int Shelflife { get; set; }

    public int Warranty { get; set; }

    public bool? IsOutsideProcess { get; set; }

    public string? GlaccountStkCoverage { get; set; }

    public string? GlaccountStkChange { get; set; }

    public string? ItemToBeReceivedLedger { get; set; }

    public short? Division { get; set; }

    public bool? IsBillableItem { get; set; }

    public bool? IsProductiveItem { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
