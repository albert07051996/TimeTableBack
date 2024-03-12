﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Absence
{
    public Guid Id { get; set; }

    public int Hid { get; set; }

    public int Type { get; set; }

    public int EmpId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Hours { get; set; }

    public double? Days { get; set; }

    public DateTime? StartDateActual { get; set; }

    public DateTime? EndDateActual { get; set; }

    public double? HoursActual { get; set; }

    public double? DaysActual { get; set; }

    public double? Amount { get; set; }

    public string? Currency { get; set; }

    public double? AmountFc { get; set; }

    public double? AmountActual { get; set; }

    public string? CurrencyActual { get; set; }

    public double? AmountFcactual { get; set; }

    public int? PaymentType { get; set; }

    public Guid? CustomerId { get; set; }

    public Guid? CustomerContactId { get; set; }

    public Guid? CustomerResellerId { get; set; }

    public Guid? InvoiceAccount { get; set; }

    public int BillCustomer { get; set; }

    public string? ItemCode { get; set; }

    public Guid? ReleaseId { get; set; }

    public double? ItemCount { get; set; }

    public double? ItemCountActual { get; set; }

    public Guid? ItemNumberId { get; set; }

    public Guid? DocumentId { get; set; }

    public bool DocumentsReceived { get; set; }

    public string? ItemCode2 { get; set; }

    public Guid? ReleaseId2 { get; set; }

    public double? ItemCount2 { get; set; }

    public double? ItemCountActual2 { get; set; }

    public Guid? ItemNumberId2 { get; set; }

    public Guid? DocumentId2 { get; set; }

    public string? ItemCountry { get; set; }

    public string? ItemCountry2 { get; set; }

    public int Status { get; set; }

    public string? Description { get; set; }

    public bool Buildup { get; set; }

    public string? ProcessNumber { get; set; }

    public Guid? FinancialEntryKey { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? ProjectNumber { get; set; }

    public string? RequestComments { get; set; }

    public string? WorkflowComments { get; set; }

    public int? ToBeApprovedBy { get; set; }

    public int Approver { get; set; }

    public DateTime? Approved { get; set; }

    public int? Processor { get; set; }

    public DateTime? Processed { get; set; }

    public int? Realizer { get; set; }

    public DateTime? Realized { get; set; }

    public DateTime? StatusChanged { get; set; }

    public int Priority { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public bool Private { get; set; }

    public int? CreatorProduct { get; set; }

    public string? OrderNumber { get; set; }

    public string? PurchaseNumber { get; set; }

    public string? ExchangeLink { get; set; }

    public int SecurityLevel { get; set; }

    public Guid? EntryGuid { get; set; }

    public string? Division { get; set; }

    public short? DivisionX { get; set; }

    public Guid? ParentRequest { get; set; }

    public string? FreeTextField01 { get; set; }

    public string? FreeTextField02 { get; set; }

    public string? FreeTextField03 { get; set; }

    public string? FreeTextField04 { get; set; }

    public string? FreeTextField05 { get; set; }

    public string? FreeTextField06 { get; set; }

    public string? FreeTextField07 { get; set; }

    public string? FreeTextField08 { get; set; }

    public string? FreeTextField09 { get; set; }

    public string? FreeTextField10 { get; set; }

    public string? FreeTextField11 { get; set; }

    public string? FreeTextField12 { get; set; }

    public string? FreeTextField13 { get; set; }

    public string? FreeTextField14 { get; set; }

    public string? FreeTextField15 { get; set; }

    public DateTime? FreeDateField01 { get; set; }

    public DateTime? FreeDateField02 { get; set; }

    public DateTime? FreeDateField03 { get; set; }

    public DateTime? FreeDateField04 { get; set; }

    public DateTime? FreeDateField05 { get; set; }

    public byte? FreeBoolField01 { get; set; }

    public byte? FreeBoolField02 { get; set; }

    public byte? FreeBoolField03 { get; set; }

    public byte? FreeBoolField04 { get; set; }

    public byte? FreeBoolField05 { get; set; }

    public double? FreeNumberField01 { get; set; }

    public double? FreeNumberField02 { get; set; }

    public double? FreeNumberField03 { get; set; }

    public double? FreeNumberField04 { get; set; }

    public double? FreeNumberField05 { get; set; }

    public int? FreeIntField01 { get; set; }

    public int? FreeIntField02 { get; set; }

    public int? FreeIntField03 { get; set; }

    public int? FreeIntField04 { get; set; }

    public int? FreeIntField05 { get; set; }

    public Guid? FreeGuidField01 { get; set; }

    public Guid? FreeGuidField02 { get; set; }

    public Guid? FreeGuidField03 { get; set; }

    public Guid? FreeGuidField04 { get; set; }

    public Guid? FreeGuidField05 { get; set; }

    public Guid? FreeGuidField06 { get; set; }

    public Guid? FreeGuidField07 { get; set; }

    public Guid? FreeGuidField08 { get; set; }

    public Guid? FreeGuidField09 { get; set; }

    public Guid? FreeGuidField10 { get; set; }

    public Guid? RelatedRequestId { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? RejectedBy { get; set; }

    public DateTime? Rejected { get; set; }

    public Guid? TemplateId { get; set; }

    public short? Stage { get; set; }

    public string? AbsenceBasis { get; set; }

    public int? OpportunityId { get; set; }

    public bool? EarlyInvoicing { get; set; }

    public string? DeliverableCode { get; set; }

    public byte RegisterCost { get; set; }

    public byte Entitlement { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public Guid? RelatedRequestId2 { get; set; }

    public Guid? RelatedRequestId3 { get; set; }

    public Guid? RelatedRequestId4 { get; set; }

    public Guid? WorkBreakdownStructureLine { get; set; }

    public int? BudgetLine { get; set; }

    public DateTime? InvoicePostponeDate { get; set; }

    public bool? IsDirectInvoiceLine { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public string? OpportunityStage { get; set; }

    public Guid? LineId { get; set; }

    public byte? SystemGenerated { get; set; }
}
