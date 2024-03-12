using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemNumber
{
    public Guid Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string? Number { get; set; }

    public Guid? ParentId { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public DateTime? DateFinal { get; set; }

    public bool Active { get; set; }

    public string? Description { get; set; }

    public string? OwnerCompany { get; set; }

    public double? Quantity { get; set; }

    public Guid? VariantId { get; set; }

    public string? PurchaseCurrency { get; set; }

    public double PurchasePriceLocal { get; set; }

    public double PurchasePrice { get; set; }

    public double PurchaseBasePriceLocal { get; set; }

    public double PurchaseBasePrice { get; set; }

    public int Type { get; set; }

    public Guid? Associate { get; set; }

    public string? ProductRelease { get; set; }

    public string? PreviousNumber { get; set; }

    public Guid? Supplier { get; set; }

    public Guid? DocumentId { get; set; }

    public int StatusValid { get; set; }

    public int StatusPrice { get; set; }

    public int StatusBudget { get; set; }

    public DateTime? ShadowDateEnd { get; set; }

    public string? ShadowCurrency { get; set; }

    public double? ShadowPriceLocal { get; set; }

    public double? ShadowPrice { get; set; }

    public int ShadowValid { get; set; }

    public string? NumberInBatch { get; set; }

    public string? VariantDescription { get; set; }

    public int? VariantQuantity { get; set; }

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

    public bool? UserYesNo01 { get; set; }

    public bool? UserYesNo02 { get; set; }

    public bool? UserYesNo03 { get; set; }

    public bool? UserYesNo04 { get; set; }

    public bool? UserYesNo05 { get; set; }

    public string? AssetGroup { get; set; }

    public string? Classification { get; set; }

    public string? SupplierNumber { get; set; }

    public int CurrQtyUnits { get; set; }

    public string? Description2 { get; set; }

    public string? Description3 { get; set; }

    public string? Description4 { get; set; }

    public string? Description5 { get; set; }

    public string? FiscalGroup { get; set; }

    public int? UserInteger01 { get; set; }

    public int? UserInteger02 { get; set; }

    public int? UserInteger03 { get; set; }

    public int? UserInteger04 { get; set; }

    public int? UserInteger05 { get; set; }

    public int Hid { get; set; }

    public string? CostUnit { get; set; }

    public string? CostCenter { get; set; }

    public DateTime? LastMaintenanceDate { get; set; }

    public double MiscellaneousAmount { get; set; }

    public double MiscellaneousAmountFc { get; set; }

    public Guid? NotesGuid { get; set; }

    public byte PassengerCar { get; set; }

    public byte[]? Picture { get; set; }

    public string? PictureFilename { get; set; }

    public string? PriceList { get; set; }

    public string? PrimaryMethod { get; set; }

    public string? Projectnr { get; set; }

    public string? PropertyType { get; set; }

    public string? ReceiptNumber { get; set; }

    public int Resource { get; set; }

    public double ResidualValue { get; set; }

    public string? SecondaryMethod { get; set; }

    public string? Status { get; set; }

    public byte TangibleAsset { get; set; }

    public Guid? TransactionGuid { get; set; }

    public string? UsageStartPeriod { get; set; }

    public string? UsageStartYear { get; set; }

    public double CostLastMaintenance { get; set; }

    public double CostLastMaintenanceFc { get; set; }

    public Guid? AddressGuid { get; set; }

    public string? LotNumber { get; set; }

    public string? DepreciationBaseType { get; set; }

    public short? DepreciationBaseDay { get; set; }

    public string? SpecialCalcBasis { get; set; }

    public DateTime? SpecialStartDate { get; set; }

    public string? SpecialNumYears { get; set; }

    public string? SpecialNumPeriods { get; set; }

    public string? Status2 { get; set; }

    public bool? UseSpecial { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public bool UseIndex { get; set; }

    public string? InvoiceDivision { get; set; }

    public Guid? InvoiceDebtor { get; set; }

    public string? InvoiceFrequency { get; set; }

    public string? InvoiceCurrency { get; set; }

    public string? SelectionCode { get; set; }

    public string? PaymentCondition { get; set; }

    public Guid? ParentContract { get; set; }

    public string? Indexation { get; set; }

    public double? IndexationPercentage { get; set; }

    public short ContractType { get; set; }

    public string? InvoiceDebtorCode { get; set; }

    public DateTime? LicenseDateEnd { get; set; }

    public string? SalesInvoiceDivision { get; set; }

    public string? SalesInvoiceDebtorCode { get; set; }

    public string? SalesInvoiceCurrency { get; set; }

    public string? SalesSelectionCode { get; set; }

    public string? SalesPaymentCondition { get; set; }

    public DateTime? LastIndexationDate { get; set; }

    public DateTime? StartIndexationDate { get; set; }

    public byte? IndexationMonth { get; set; }

    public bool IsCopied { get; set; }

    public string? CustomerReference { get; set; }

    public string? OwnReference { get; set; }

    public int? PriceMethod { get; set; }

    public string? PriceCountry { get; set; }

    public string? PriceCurrency { get; set; }

    public bool? Billable { get; set; }

    public bool? IsReadOnly { get; set; }

    public double? CancelledQuantity { get; set; }

    public double? DiscountPercent { get; set; }

    public double? GrossPrice { get; set; }

    public int? RequestHid { get; set; }

    public int? DocumentHid { get; set; }

    public Guid? ChildId { get; set; }
}
