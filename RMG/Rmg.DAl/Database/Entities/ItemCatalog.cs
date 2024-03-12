using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemCatalog
{
    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SecurityLevel { get; set; }

    public int AssumeSecurityLevel { get; set; }

    public int PageSize { get; set; }

    public bool CatalogDefault { get; set; }

    public int CatalogOrder { get; set; }

    public int CatalogColor { get; set; }

    public int CatalogColorSelected { get; set; }

    public int CatalogTextColor { get; set; }

    public int CatalogTextColorSelected { get; set; }

    public int SideBarLocation { get; set; }

    public int SideBarWidth { get; set; }

    public string SideBarFontSize { get; set; } = null!;

    public string SideBarFontWeight { get; set; } = null!;

    public int SideBarLinkColor { get; set; }

    public int SideBarLinkTextColor { get; set; }

    public string SideBarLinkFontSize { get; set; } = null!;

    public string SideBarLinkFontWeight { get; set; } = null!;

    public bool SideBarShowCountry { get; set; }

    public bool SideBarShowSearch { get; set; }

    public bool SideBarShowSearchLink { get; set; }

    public bool SideBarShowLinks { get; set; }

    public bool SideBarShowLinksPricelist { get; set; }

    public int SideBarShowLinksPricelistLevel { get; set; }

    public bool SideBarShowLinksProducts { get; set; }

    public int SideBarShowLinksProductsLevel { get; set; }

    public int SideBarShowLinksNews { get; set; }

    public int SideBarShowLinksReferences { get; set; }

    public int SideBarShowLinksContracts { get; set; }

    public bool SideBarShowAccountFilter { get; set; }

    public bool SideBarShowLinksOrderForm { get; set; }

    public int SideBarShowLinksOrderFormLevel { get; set; }

    public string TabBarFontSize { get; set; } = null!;

    public string TabBarFontWeight { get; set; } = null!;

    public bool TabBarShowNews { get; set; }

    public string NavBarFontSize { get; set; } = null!;

    public string NavBarFontWeight { get; set; } = null!;

    public bool NavBarShowInNavBar { get; set; }

    public int NavBarStyle { get; set; }

    public int AssortmentDisplay { get; set; }

    public string? AssortmentName { get; set; }

    public string? AssortmentSelection { get; set; }

    public int CategoryDisplay { get; set; }

    public int CategoryLayout { get; set; }

    public int CategoryColumns { get; set; }

    public string? CategorySelection { get; set; }

    public string CategoryHeadingFontSize { get; set; } = null!;

    public string CategoryHeadingFontWeight { get; set; } = null!;

    public string CategoryTextFontSize { get; set; } = null!;

    public string CategoryTextFontWeight { get; set; } = null!;

    public int ProductDisplay { get; set; }

    public bool ProductDisplayHeader { get; set; }

    public string? ProductSelection { get; set; }

    public bool ProductShowInActive { get; set; }

    public bool ProductShowActive { get; set; }

    public bool ProductShowFuture { get; set; }

    public string ProductHeadingFontSize { get; set; } = null!;

    public string ProductHeadingFontWeight { get; set; } = null!;

    public string ProductTextFontSize { get; set; } = null!;

    public string ProductTextFontWeight { get; set; } = null!;

    public int? ProductColumn01 { get; set; }

    public int? ProductColumn02 { get; set; }

    public int? ProductColumn03 { get; set; }

    public int? ProductColumn04 { get; set; }

    public int? ProductColumn05 { get; set; }

    public int? ProductColumn06 { get; set; }

    public string NewsHeadingFontSize { get; set; } = null!;

    public string NewsHeadingFontWeight { get; set; } = null!;

    public string NewsTextFontSize { get; set; } = null!;

    public string NewsTextFontWeight { get; set; } = null!;

    public string FilterHeadingFontSize { get; set; } = null!;

    public string FilterHeadingFontWeight { get; set; } = null!;

    public string FilterTextFontSize { get; set; } = null!;

    public string FilterTextFontWeight { get; set; } = null!;

    public int FilterColumns { get; set; }

    public bool ShowFilter { get; set; }

    public int DefaultCountryFrom { get; set; }

    public string? DefaultCountry { get; set; }

    public bool Shopping { get; set; }

    public int? ShoppingRequest { get; set; }

    public bool ShoppingBackToShop { get; set; }

    public int ShoppingMode { get; set; }

    public int ShoppingOrderMode { get; set; }

    public bool ShoppingShowResource { get; set; }

    public bool ShoppingEditResource { get; set; }

    public bool ShoppingShowDate { get; set; }

    public bool ShoppingEditDate { get; set; }

    public bool ShoppingShowProject { get; set; }

    public bool ShoppingEditProject { get; set; }

    public bool ShoppingShowBillingType { get; set; }

    public int ShoppingDefaultBillingType { get; set; }

    public bool ProductLevelNotify { get; set; }

    public bool ProductLevelContinue { get; set; }

    public int? DocumentType { get; set; }

    public short? Division { get; set; }
}
