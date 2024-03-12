using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemAssortment
{
    public int Id { get; set; }

    public int Assortment { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SecurityLevel { get; set; }

    public int? PriceSecurityLevel { get; set; }

    public int? OwnerPerson { get; set; }

    public bool UseReleases { get; set; }

    public bool UseTranslations { get; set; }

    public bool UseCountries { get; set; }

    public bool UseCatalog { get; set; }

    public string? CatalogItemSelection { get; set; }

    public int CatalogOrder { get; set; }

    public int? CatalogClass1 { get; set; }

    public int? CatalogClass2 { get; set; }

    public int? CatalogClass3 { get; set; }

    public bool UseContract { get; set; }

    public string? ContractItemSelection { get; set; }

    public int? ContractDocGroup { get; set; }

    public int? ContractDocType { get; set; }

    public string? ContractDocCategory { get; set; }

    public string? ContractDocSubCategory { get; set; }

    public int ContractDocSecurity { get; set; }

    public string? ContractComponentProgId { get; set; }

    public string? ContractComponentParameter { get; set; }

    public bool ContractReleaseMandatory { get; set; }

    public string? Note { get; set; }

    public byte[]? Picture { get; set; }

    public string? PictureFilename { get; set; }

    public bool AllowInCatalog { get; set; }

    public bool AllowNewItem { get; set; }

    public bool AllowNewContract { get; set; }

    public bool AllowNewDocument { get; set; }

    public string? LabelUserField01 { get; set; }

    public string? LabelUserField02 { get; set; }

    public string? LabelUserField03 { get; set; }

    public string? LabelUserField04 { get; set; }

    public string? LabelUserField05 { get; set; }

    public string? LabelUserField06 { get; set; }

    public string? LabelUserField07 { get; set; }

    public string? LabelUserField08 { get; set; }

    public string? LabelUserField09 { get; set; }

    public string? LabelUserField10 { get; set; }

    public string? LabelUserDate01 { get; set; }

    public string? LabelUserDate02 { get; set; }

    public string? LabelUserDate03 { get; set; }

    public string? LabelUserDate04 { get; set; }

    public string? LabelUserDate05 { get; set; }

    public string? LabelUserNumber01 { get; set; }

    public string? LabelUserNumber02 { get; set; }

    public string? LabelUserNumber03 { get; set; }

    public string? LabelUserNumber04 { get; set; }

    public string? LabelUserNumber05 { get; set; }

    public string? LabelUserNumber06 { get; set; }

    public string? LabelUserNumber09 { get; set; }

    public string? LabelUserNumber10 { get; set; }

    public string? LabelUserNumber11 { get; set; }

    public string? LabelUserNumber12 { get; set; }

    public string? LabelUserNumber13 { get; set; }

    public string? LabelUserYesNo01 { get; set; }

    public string? LabelUserYesNo02 { get; set; }

    public string? LabelUserYesNo03 { get; set; }

    public string? LabelUserYesNo04 { get; set; }

    public string? LabelUserYesNo05 { get; set; }

    public string? LabelNuserField01 { get; set; }

    public string? LabelNuserField02 { get; set; }

    public string? LabelNuserField03 { get; set; }

    public string? LabelNuserField04 { get; set; }

    public string? LabelNuserField05 { get; set; }

    public string? LabelNuserField06 { get; set; }

    public string? LabelNuserField07 { get; set; }

    public string? LabelNuserField08 { get; set; }

    public string? LabelNuserField09 { get; set; }

    public string? LabelNuserField10 { get; set; }

    public string? LabelNuserDate01 { get; set; }

    public string? LabelNuserDate02 { get; set; }

    public string? LabelNuserDate03 { get; set; }

    public string? LabelNuserDate04 { get; set; }

    public string? LabelNuserDate05 { get; set; }

    public string? LabelNuserNumber01 { get; set; }

    public string? LabelNuserNumber02 { get; set; }

    public string? LabelNuserNumber03 { get; set; }

    public string? LabelNuserNumber04 { get; set; }

    public string? LabelNuserNumber05 { get; set; }

    public string? LabelNuserYesNo01 { get; set; }

    public string? LabelNuserYesNo02 { get; set; }

    public string? LabelNuserYesNo03 { get; set; }

    public string? LabelNuserYesNo04 { get; set; }

    public string? LabelNuserYesNo05 { get; set; }

    public string? StatNumber { get; set; }

    public string? Costunit { get; set; }

    public string? Glrevenue { get; set; }

    public string? GldeferredRevenue { get; set; }

    public string? GldeferredCost { get; set; }

    public string? GlrecognizeCosts { get; set; }

    public string? Gldiscount { get; set; }

    public string? GlcostOfGoodsSold { get; set; }

    public string? Glstock { get; set; }

    public string? GlpriceDifference { get; set; }

    public string? Description0 { get; set; }

    public string? Description1 { get; set; }

    public string? Description2 { get; set; }

    public string? Description3 { get; set; }

    public string? Description4 { get; set; }

    public string RoundOffMethod { get; set; } = null!;

    public string? GlstkCoverage { get; set; }

    public string? GlstkChange { get; set; }

    public string? ItemToBeReceivedLedger { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
