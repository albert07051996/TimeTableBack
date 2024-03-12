using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemAccount
{
    public int Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public Guid AccountCode { get; set; }

    public string? Crdnr { get; set; }

    public bool MainAccount { get; set; }

    public string? ItemCodeAccount { get; set; }

    public string? Eancode { get; set; }

    public string PurchaseCurrency { get; set; } = null!;

    public double PurchasePrice { get; set; }

    public string? PurchaseVatcode { get; set; }

    public double PurchaseVatperc { get; set; }

    public bool PurchaseVatincl { get; set; }

    public string? PurchaseUnit { get; set; }

    public string? PurchasePackage { get; set; }

    public double PurchaseUnitToInternalUnitFactor { get; set; }

    public double PurchaseUnitToPurchasePackageFactor { get; set; }

    public double PurchaseOrderSize { get; set; }

    public double DiscountMargin { get; set; }

    public double SalesPriceRecommended { get; set; }

    public double SlsPkgsPerPurPkg { get; set; }

    public int DeliveryTimeInDays { get; set; }

    public bool DeliverableFromStock { get; set; }

    public Guid? DocumentId { get; set; }

    public byte? SupplierPreference { get; set; }

    public double? StatisticalFactor { get; set; }

    public int Warranty { get; set; }

    public string? CountryOfOrigin { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
