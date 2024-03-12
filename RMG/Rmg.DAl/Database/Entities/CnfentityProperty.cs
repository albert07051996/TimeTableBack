using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfentityProperty
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public int? DescriptionTermId { get; set; }

    public int Type { get; set; }

    public int? Length { get; set; }

    public int? Rows { get; set; }

    public int? Columns { get; set; }

    public int? Scale { get; set; }

    public bool? Unsigned { get; set; }

    public bool? Uppercase { get; set; }

    public bool? NumericString { get; set; }

    public bool? AutoIncrement { get; set; }

    public bool? RightAlign { get; set; }

    public bool? ZeroFill { get; set; }

    public bool? ZeroEqualsNull { get; set; }

    public bool? ZeroIsNull { get; set; }

    public string? DefaultValue { get; set; }

    public bool? DefaultCurrency { get; set; }

    public string? PrecisionQuery { get; set; }

    public bool? IsMandatory { get; set; }

    public bool? IsWebServiceExposed { get; set; }

    public bool? IsFiltered { get; set; }

    public string? FilterExpression { get; set; }

    public byte IsGenerated { get; set; }

    public bool? AddSearchCriteria { get; set; }

    public bool? AddSearchColumn { get; set; }

    public string? AllowedChars { get; set; }

    public string? AllowedCharsQuery { get; set; }

    public Guid? BrowserId { get; set; }

    public string? BrowserName { get; set; }

    public string? Caption { get; set; }

    public string? CaptionSuffix { get; set; }

    public int? CaptionSuffixTermId { get; set; }

    public int? CaptionTermId { get; set; }

    public int DefaultState { get; set; }

    public int DefaultType { get; set; }

    public int Log { get; set; }

    public string? LowerRange { get; set; }

    public int Mandatory { get; set; }

    public int Precision { get; set; }

    public bool? PropExposedWs { get; set; }

    public string? PropNameWs { get; set; }

    public bool? SecurityContextIncluded { get; set; }

    public string? SelectionValues { get; set; }

    public string? UpperRange { get; set; }

    public string? ValidationQuery { get; set; }

    public bool? UserDataFormat { get; set; }

    public bool? AddToProjectMonitor { get; set; }

    public bool? AddToItemMonitor { get; set; }

    public bool? AddToAccountMonitor { get; set; }

    public bool? AddToResourceMonitor { get; set; }

    public bool? DisplayMode { get; set; }

    public bool? DisplayThousandSeparators { get; set; }

    public string? AspcontrolCode { get; set; }

    public int BasicType { get; set; }

    public string? InheritedFromEntity { get; set; }

    public string? ExtendedFromEntity { get; set; }

    public bool? IsMandatoryInInheritedEntity { get; set; }

    public bool? IsDeployed { get; set; }

    public bool? NeedGenerate { get; set; }

    public string? Options { get; set; }

    public bool? UseStandardPostalCode { get; set; }

    public int? DisplayInto { get; set; }

    public int? RequestFieldId { get; set; }

    public bool? AddToMonitor { get; set; }

    public bool? AllowSorting { get; set; }

    public string? Suffix { get; set; }

    public int? SuffixTermId { get; set; }

    public bool? AttributesReadOnly { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public bool? AddReferenceDescription { get; set; }

    public bool? HideLinks { get; set; }
}
