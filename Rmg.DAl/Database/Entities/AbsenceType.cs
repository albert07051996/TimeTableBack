using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AbsenceType
{
    public int Id { get; set; }

    public int MainType { get; set; }

    public string Description { get; set; } = null!;

    public bool UseEmployee { get; set; }

    public bool EmployeeMandatory { get; set; }

    public bool EmployeeMandatoryOnApproval { get; set; }

    public bool ShowEmployeeOnNew { get; set; }

    public bool UseStartDate { get; set; }

    public bool StartDateMandatory { get; set; }

    public bool UseEndDate { get; set; }

    public bool EndDateMandatory { get; set; }

    public bool EndDateMandatoryOnApproval { get; set; }

    public bool ProcessorEditDates { get; set; }

    public bool UseTime { get; set; }

    public bool UseActualDates { get; set; }

    public bool ProcessorEditActualDates { get; set; }

    public bool ShowDatesOnNew { get; set; }

    public bool ShowActualDatesOnNew { get; set; }

    public bool ShowActualDatesInOpen { get; set; }

    public bool UseDuration { get; set; }

    public bool DurationMandatory { get; set; }

    public bool DurationInDays { get; set; }

    public int BalanceUse { get; set; }

    public int Buildup { get; set; }

    public bool HourEntry { get; set; }

    public bool Calculate { get; set; }

    public bool UseWorkscheduleForDurationCalculation { get; set; }

    public bool UseAmount { get; set; }

    public bool UseAmountActual { get; set; }

    public bool EditAmount { get; set; }

    public bool AmountMandatory { get; set; }

    public bool CalculateAmount { get; set; }

    public bool UsePaymentType { get; set; }

    public bool UseForOutOfOffice { get; set; }

    public bool UseCustomer { get; set; }

    public bool CustomerMandatory { get; set; }

    public bool ShowCustomerTop { get; set; }

    public bool UseCustomerContact { get; set; }

    public bool CustomerContactMandatory { get; set; }

    public bool UseBillCustomer { get; set; }

    public int BillCustomerDefault { get; set; }

    public bool UseItem { get; set; }

    public bool UseItem2 { get; set; }

    public bool ItemMandatory { get; set; }

    public bool ItemMandatory2 { get; set; }

    public bool ShowItemOnNew { get; set; }

    public bool ShowItemOnNew2 { get; set; }

    public bool ShowItemNumberOnNew { get; set; }

    public bool ShowItemNumberOnNew2 { get; set; }

    public bool UseRelease { get; set; }

    public bool UseRelease2 { get; set; }

    public bool UseItemCount { get; set; }

    public bool UseItemCount2 { get; set; }

    public bool ItemCountMandatory { get; set; }

    public bool ItemCountMandatory2 { get; set; }

    public bool UseItemNumber { get; set; }

    public bool UseItemNumber2 { get; set; }

    public bool UseItemCountry { get; set; }

    public bool UseItemCountry2 { get; set; }

    public bool ItemNumberMandatory { get; set; }

    public bool ItemNumberMandatory2 { get; set; }

    public bool ProcessorSelectItem { get; set; }

    public bool ProcessorSelectItemNumber { get; set; }

    public bool ProcessorSelectItem2 { get; set; }

    public bool ProcessorSelectItemNumber2 { get; set; }

    public bool UseDocument { get; set; }

    public bool ShowDocumentOnNew { get; set; }

    public bool DocumentMandatory { get; set; }

    public bool UseDocumentsReceived { get; set; }

    public bool ShowCreateDocument { get; set; }

    public bool UsePurchaseLimitForApproval { get; set; }

    public bool UseProjectNumber { get; set; }

    public bool ProjectNumberMandatory { get; set; }

    public bool ShowProjectNumberOnNew { get; set; }

    public bool UseReferenceNumber { get; set; }

    public bool ShowReferenceNumberOnNew { get; set; }

    public bool UsePriority { get; set; }

    public bool InformHr { get; set; }

    public bool PlanAbsence { get; set; }

    public bool PlanHumanResource { get; set; }

    public bool PlanItem { get; set; }

    public bool PlanPersonalAssets { get; set; }

    public bool CreateTaskOnRejection { get; set; }

    public bool CreateTaskOnApproval { get; set; }

    public bool ShowWorkflowCommentsInNewRequest { get; set; }

    public bool UseInSalesBudget { get; set; }

    public bool? UseFinancialEntryKey { get; set; }

    public bool? FinancialEntryKeyMandatory { get; set; }

    public bool? ShowFinancialEntryKeyOnNew { get; set; }

    public bool? ProcessorSelectAccount { get; set; }

    public int CreateEmployee { get; set; }

    public int CreateManager { get; set; }

    public int? CreateRole1 { get; set; }

    public int? CreateRoleLevel1 { get; set; }

    public int? CreateRole2 { get; set; }

    public int? CreateRoleLevel2 { get; set; }

    public int? CreateRole3 { get; set; }

    public int? CreateRoleLevel3 { get; set; }

    public int CreateSecurityLevel { get; set; }

    public int SecurityLevel { get; set; }

    public bool EditEveryone { get; set; }

    public bool EditCreator { get; set; }

    public bool EditEmployee { get; set; }

    public bool EditApprover { get; set; }

    public bool EditCreators { get; set; }

    public bool DeleteCreator { get; set; }

    public bool DeleteItemOwner { get; set; }

    public bool ShowCustomerOnNew { get; set; }

    public bool ItemsInCustomerLicence { get; set; }

    public bool ItemsInCustomerLicence2 { get; set; }

    public bool AllowAttachments { get; set; }

    public bool DeleteAttachmentsOnCompletion { get; set; }

    public int? DeleteRole1 { get; set; }

    public int? DeleteRoleLevel1 { get; set; }

    public int Approver { get; set; }

    public int? ApproveRole { get; set; }

    public int? ApproveRoleLevel { get; set; }

    public int? ApproveRoleCompanyOrigin { get; set; }

    public int? ProcessRole { get; set; }

    public int? ProcessRoleLevel { get; set; }

    public int? RoleCompanyOrigin { get; set; }

    public int? ProcessEmployee { get; set; }

    public int? ReopenRole { get; set; }

    public int? ReopenRoleLevel { get; set; }

    public int? ReopenRoleCompanyOrigin { get; set; }

    public int EmployeeType { get; set; }

    public int EmployeeStatus { get; set; }

    public string? EmployeeSelection { get; set; }

    public string? EmployeeCaption { get; set; }

    public string? ItemCaption { get; set; }

    public string? ItemCaption2 { get; set; }

    public string? ItemSelection { get; set; }

    public string? ItemSelection2 { get; set; }

    public int? ItemCountry { get; set; }

    public int? ItemCountry2 { get; set; }

    public int? ItemCountryOrigin { get; set; }

    public int ItemAvailability { get; set; }

    public int ItemAvailability2 { get; set; }

    public int ItemAvailabilityAfterApproval { get; set; }

    public int ItemAvailabilityAfterApproval2 { get; set; }

    public int ItemNumberAvailability { get; set; }

    public int ItemNumberAvailability2 { get; set; }

    public string? DefaultItemCode { get; set; }

    public string? DefaultItemCode2 { get; set; }

    public double? DefaultQuantity { get; set; }

    public double? DefaultQuantity2 { get; set; }

    public int AmountItem { get; set; }

    public int AmountCountry { get; set; }

    public int WorkflowCommentsEdit { get; set; }

    public string? DefaultProjectNumber { get; set; }

    public string? Message0 { get; set; }

    public string? Message1 { get; set; }

    public string? Message2 { get; set; }

    public string? Message3 { get; set; }

    public string? Message4 { get; set; }

    public bool? IncludeRequestDescriptionInTask { get; set; }

    public string? ApproveText { get; set; }

    public int? GraphColor { get; set; }

    public bool Active { get; set; }

    public int? Realizer { get; set; }

    public int? Realizer2 { get; set; }

    public int? RealizeRole { get; set; }

    public int? RealizeRoleLevel { get; set; }

    public int? RealizeRoleCompanyOrigin { get; set; }

    public int TakeOwnershipForApproval { get; set; }

    public int TakeOwnershipForProcessing { get; set; }

    public int TakeOwnershipForRealization { get; set; }

    public int AssignOwnershipForApproval { get; set; }

    public int AssignOwnershipForProcessing { get; set; }

    public int AssignOwnershipForRealization { get; set; }

    public bool AllowReassignmentForApproval { get; set; }

    public bool AllowReassignmentForProcessing { get; set; }

    public bool AllowReassignmentForRealization { get; set; }

    public int AssignRemarkForApproval { get; set; }

    public int AssignRemarkForProcessing { get; set; }

    public int AssignRemarkForRealization { get; set; }

    public int SendRequestAsMail { get; set; }

    public int? MaxHoursCompletion { get; set; }

    public int? MaxHoursOpen { get; set; }

    public int? MaxHoursApproved { get; set; }

    public int? MaxHoursRealized { get; set; }

    public int Stock { get; set; }

    public string? AccountCompletionType { get; set; }

    public string? AccountCompletionStatus { get; set; }

    public string? ResourceCompletionType { get; set; }

    public string? ResourceCompletionStatus { get; set; }

    public int? AccountCompletionTypeMoment { get; set; }

    public int? AccountCompletionStatusMoment { get; set; }

    public int? ResourceCompletionTypeMoment { get; set; }

    public int? ResourceCompletionStatusMoment { get; set; }

    public bool UseItemCountActual { get; set; }

    public DateTime? DefaultStartTime { get; set; }

    public DateTime? DefaultEndTime { get; set; }

    public Guid? PolicyDocId { get; set; }

    public bool AllowPrivate { get; set; }

    public bool AutoApprove { get; set; }

    public int DueDate { get; set; }

    public int DueDays { get; set; }

    public string? CustomerSelection { get; set; }

    public string? CustomerCaption { get; set; }

    public int ReopenCompleted { get; set; }

    public string? RequestCommentsCaption { get; set; }

    public string? WorkflowCommentsCaption { get; set; }

    public int? Responsible { get; set; }

    public string? FreeTextLabel01 { get; set; }

    public string? FreeTextLabel02 { get; set; }

    public string? FreeTextLabel03 { get; set; }

    public string? FreeTextLabel04 { get; set; }

    public string? FreeTextLabel05 { get; set; }

    public string? FreeDateLabel01 { get; set; }

    public string? FreeDateLabel02 { get; set; }

    public string? FreeDateLabel03 { get; set; }

    public string? FreeBoolLabel01 { get; set; }

    public string? FreeBoolLabel02 { get; set; }

    public string? FreeBoolLabel03 { get; set; }

    public bool? FreeTextMandatory01 { get; set; }

    public bool? FreeTextIndexed01 { get; set; }

    public bool? FreeTextMandatory02 { get; set; }

    public bool? FreeTextIndexed02 { get; set; }

    public bool? FreeTextMandatory03 { get; set; }

    public bool? FreeTextIndexed03 { get; set; }

    public bool? FreeTextMandatory04 { get; set; }

    public bool? FreeTextIndexed04 { get; set; }

    public bool? FreeTextMandatory05 { get; set; }

    public bool? FreeTextIndexed05 { get; set; }

    public bool? FreeDateMandatory01 { get; set; }

    public bool? FreeDateIndexed01 { get; set; }

    public bool? FreeDateMandatory02 { get; set; }

    public bool? FreeDateIndexed02 { get; set; }

    public bool? FreeDateMandatory03 { get; set; }

    public bool? FreeDateIndexed03 { get; set; }

    public bool? FreeBoolIndexed01 { get; set; }

    public bool? FreeBoolIndexed02 { get; set; }

    public bool? FreeBoolIndexed03 { get; set; }

    public bool AccountEditAfterApproval { get; set; }

    public bool FreeTextEditAfterApproval01 { get; set; }

    public bool FreeTextEditAfterApproval02 { get; set; }

    public bool FreeTextEditAfterApproval03 { get; set; }

    public bool FreeTextEditAfterApproval04 { get; set; }

    public bool FreeTextEditAfterApproval05 { get; set; }

    public bool FreeDateEditAfterApproval01 { get; set; }

    public bool FreeDateEditAfterApproval02 { get; set; }

    public bool FreeDateEditAfterApproval03 { get; set; }

    public bool FreeBoolEditAfterApproval01 { get; set; }

    public bool FreeBoolEditAfterApproval02 { get; set; }

    public bool FreeBoolEditAfterApproval03 { get; set; }

    public int? EditRole { get; set; }

    public int? EditRoleLevel { get; set; }

    public int? EditRoleCompanyOrigin { get; set; }

    public bool UseInCalendar { get; set; }

    public bool FullText { get; set; }

    public bool EditSecurityLevel { get; set; }

    public bool EditSecurityLevelAfterApproval { get; set; }

    public bool Hidden { get; set; }

    public bool UseInBackOffice { get; set; }

    public int MultipleEntry { get; set; }

    public bool WeekEntry { get; set; }

    public bool UseProcessNumber { get; set; }

    public bool ShowProcessNumberBeforeApproval { get; set; }

    public string? ItemNumberCaption { get; set; }

    public string? ItemNumberCaption2 { get; set; }

    public string? FreeNumberLabel01 { get; set; }

    public string? FreeNumberLabel02 { get; set; }

    public string? FreeNumberLabel03 { get; set; }

    public bool? FreeNumberMandatory01 { get; set; }

    public bool? FreeNumberMandatory02 { get; set; }

    public bool? FreeNumberMandatory03 { get; set; }

    public bool FreeNumberEditAfterApproval01 { get; set; }

    public bool FreeNumberEditAfterApproval02 { get; set; }

    public bool FreeNumberEditAfterApproval03 { get; set; }

    public int RequestCommentsEdit { get; set; }

    public int? ProcessType { get; set; }

    public int? ProcessStatus { get; set; }

    public int? ProcessStatusTo { get; set; }

    public short Glorigin { get; set; }

    public short FinDivisionOrigin { get; set; }

    public short Vatorigin { get; set; }

    public string? Gloffset { get; set; }

    public short NumberType { get; set; }

    public string TransType { get; set; } = null!;

    public string TransSubType { get; set; } = null!;

    public byte IsUserDefined { get; set; }

    public string BusinessLogic { get; set; } = null!;

    public string? Basis { get; set; }

    public string? IncrementFactor { get; set; }

    public string? CreateAccStatus { get; set; }

    public string? CreateAccType { get; set; }

    public string? ApproveAccStatus { get; set; }

    public string? ApproveAccType { get; set; }

    public string? RealizeAccStatus { get; set; }

    public string? RealizeAccType { get; set; }

    public string? ProcessAccStatus { get; set; }

    public string? ProcessAccType { get; set; }

    public string? RejectAccStatus { get; set; }

    public string? RejectAccType { get; set; }

    public bool UseSalaryComponent { get; set; }

    public bool UseReturnToWork { get; set; }

    public int DescriptionTermId { get; set; }

    public bool? ServiceActivity { get; set; }

    public string? ServiceDivision { get; set; }

    public Guid? ServiceActivityType { get; set; }

    public bool? ShowSectionsAsTabs { get; set; }

    public string ServiceType { get; set; } = null!;

    public bool UseTimestamp { get; set; }

    public Guid? LineDefinitionId { get; set; }

    public bool? UseLine { get; set; }

    public short? Division { get; set; }

    public Guid Sysguid { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public string? IconType { get; set; }

    public Guid? IconFileId { get; set; }
}
