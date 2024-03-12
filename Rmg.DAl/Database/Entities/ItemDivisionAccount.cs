using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemDivisionAccount
{
    public int Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public Guid AccountGuid { get; set; }

    public string? DivisionCode { get; set; }

    public bool MainAccount { get; set; }

    public string? ItemCodeAccount { get; set; }

    public string? Eancode { get; set; }

    public string PurchaseCurrency { get; set; } = null!;

    public double PurchasePrice { get; set; }

    public string? PurchaseVatcode { get; set; }

    public string? PurchasePackage { get; set; }

    public double PurchaseOrderSize { get; set; }

    public double SlsPkgsPerPurPkg { get; set; }

    public int DeliveryTimeInDays { get; set; }

    public Guid? DocumentId { get; set; }

    public byte? SupplierPreference { get; set; }

    public int Warranty { get; set; }

    public bool DropShip { get; set; }

    public string? CountryOfOrigin { get; set; }

    public string? CountryOfAssembly { get; set; }

    public string? Manufacturer { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
