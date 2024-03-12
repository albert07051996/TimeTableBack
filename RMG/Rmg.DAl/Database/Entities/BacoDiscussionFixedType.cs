using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionFixedType
{
    public int TypeId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public byte SystemType { get; set; }

    public string Description { get; set; } = null!;

    public byte? Active { get; set; }

    public Guid? Policy { get; set; }

    public int? Manager { get; set; }

    public short? DefSecurity { get; set; }

    public byte? EditSecurity { get; set; }

    public int? DefGroupId { get; set; }

    public Guid? DefCategory { get; set; }

    public Guid? DefSubCategory { get; set; }

    public byte? Attachment { get; set; }

    public byte? UsePublish { get; set; }

    public byte? UseRating { get; set; }

    public byte? UseStatistics { get; set; }

    public byte? UseOwner { get; set; }

    public short? CrSecurity { get; set; }

    public byte? CrSystemGen { get; set; }

    public int? CrRole1 { get; set; }

    public int? CrLevel1 { get; set; }

    public int? CrRole2 { get; set; }

    public int? CrLevel2 { get; set; }

    public int? CrRole3 { get; set; }

    public int? CrLevel3 { get; set; }

    public byte? ApUse { get; set; }

    public byte? ItUse { get; set; }

    public string? ItDefault { get; set; }

    public string? ItSelection { get; set; }

    public string? ItStatus { get; set; }

    public string? ItLabel { get; set; }

    public byte? AsUse { get; set; }

    public int? AsDefault { get; set; }

    public byte? ReUse { get; set; }

    public string? ReType { get; set; }

    public string? ReStatus { get; set; }

    public string? ReSelection { get; set; }

    public string? ReLabel { get; set; }

    public byte? AcUse { get; set; }

    public string? AcType { get; set; }

    public string? AcSelection { get; set; }

    public string? AcLabel { get; set; }

    public byte? PrUse { get; set; }

    public string? PrDefault { get; set; }

    public string? PrSelection { get; set; }

    public byte? FiUse { get; set; }

    public string? FiSelection { get; set; }

    public byte? FiOurRef { get; set; }

    public byte? FiYourRef { get; set; }

    public byte ItUseNumber { get; set; }

    public int? DaysToExpiry { get; set; }

    public byte OrderNumberUse { get; set; }

    public byte ShipmentMethodUse { get; set; }

    public byte PaymentReferenceUse { get; set; }

    public byte WarehouseUse { get; set; }

    public Guid? TemplateId { get; set; }

    public string VersionType { get; set; } = null!;

    public string EditRights { get; set; } = null!;

    public string DeleteRights { get; set; } = null!;

    public byte? SecApUse { get; set; }

    public short? Division { get; set; }

    public Guid? GroupId { get; set; }

    public int? CreatedBy { get; set; }

    public byte OpportunityUse { get; set; }

    public int? OpportunityDefault { get; set; }

    public string? OpportunitySelection { get; set; }

    public byte UseReports { get; set; }

    public bool AllowReplies { get; set; }

    public bool UseInBackOffice { get; set; }

    public bool UseExtCustomerSecurity { get; set; }

    public byte UseLanguageId { get; set; }

    public byte UseCompany { get; set; }

    public byte UseVote { get; set; }

    public bool FullText { get; set; }

    public string ArchiveMethods { get; set; } = null!;

    public int ArchiveDays { get; set; }

    public int AllowCheckoutDays { get; set; }

    public string BlockHiddenManEntry { get; set; } = null!;

    public int NumMajorVersionAllow { get; set; }

    public string ActionOldMajorVersion { get; set; } = null!;

    public bool AllowScripting { get; set; }

    public int ViewRightsOwner { get; set; }

    public short ViewRightsType { get; set; }

    public string? ViewRightsTypeValue { get; set; }

    public int? ViewRightTypeRoleLevel { get; set; }

    public string? ViewRightTypeRoleRefPoint { get; set; }

    public int EditRightsOwner { get; set; }

    public short EditRightsType { get; set; }

    public string? EditRightsTypeValue { get; set; }

    public int? EditRightTypeRoleLevel { get; set; }

    public string? EditRightTypeRoleRefPoint { get; set; }

    public int? ApprovalRole { get; set; }

    public int? ApprovalRoleLevel { get; set; }

    public string? ApprovalRoleRefPoint { get; set; }

    public short? DefSecurityTo { get; set; }

    public bool ShowEditRightsInfo { get; set; }

    public bool EnableTagging { get; set; }

    public bool EditViewRights { get; set; }

    public byte? SmsContractUse { get; set; }

    public Guid? SmsContractDefault { get; set; }

    public string? SmsContractSelection { get; set; }

    public byte? SmsConfigUse { get; set; }

    public Guid? SmsConfigDefault { get; set; }

    public string? SmsConfigSelection { get; set; }
}
