using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussion
{
    public Guid Id { get; set; }

    public int Hid { get; set; }

    public Guid? ParentId { get; set; }

    public int GroupId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime ViewDate { get; set; }

    public int CreatedBy { get; set; }

    public string CreatedByFullName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? Class021 { get; set; }

    public string? Class022 { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public int Type { get; set; }

    public string? Filename { get; set; }

    public string? Body { get; set; }

    public byte[]? Document { get; set; }

    public string? Company { get; set; }

    public int JobLevel { get; set; }

    public int Status { get; set; }

    public string? ItemCode { get; set; }

    public int? HumResId { get; set; }

    public Guid? CmpWwn { get; set; }

    public int? ModifiedBy { get; set; }

    public byte NewsType { get; set; }

    public string? LanguageId { get; set; }

    public bool IsTemplate { get; set; }

    public bool IsMailMerge { get; set; }

    public string? StatusText { get; set; }

    public string? ProjectNr { get; set; }

    public Guid? EntryKey { get; set; }

    public int? Owner { get; set; }

    public short? OwnerType { get; set; }

    public string? OwnerTypeValue { get; set; }

    public int? VoteCount { get; set; }

    public int? VoteSum { get; set; }

    public Guid? ItemNumberId { get; set; }

    public string? FpintroText { get; set; }

    public int? Assortment { get; set; }

    public Guid? CntId { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? OrderNumber { get; set; }

    public string? ShipmentMethod { get; set; }

    public string? OurRef { get; set; }

    public string? YourRef { get; set; }

    public string? PaymentReference { get; set; }

    public string? Warehouse { get; set; }

    public string? Source { get; set; }

    public string? Note { get; set; }

    public string? Version { get; set; }

    public DateTime? CheckedOut { get; set; }

    public int? CheckedOutBy { get; set; }

    public Guid? ReportId { get; set; }

    public int? OpportunityId { get; set; }

    public string? AttachmentType { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public byte[]? CompressBody { get; set; }

    public int OwnerTypeRoleLevel { get; set; }

    public string? OwnerTypeRoleRefPoint { get; set; }

    public int? ViewRightsOwner { get; set; }

    public short? ViewRightsType { get; set; }

    public string? ViewRightsTypeValue { get; set; }

    public int? ViewRightTypeRoleLevel { get; set; }

    public string? ViewRightTypeRoleRefPoint { get; set; }

    public int? LayoutReference { get; set; }

    public Guid? SmscontractId { get; set; }

    public Guid? SmsconfigurationId { get; set; }

    public bool ExtCustomerSecurity { get; set; }
}
