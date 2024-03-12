using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdpserviceSlipLinesView
{
    public Guid JobHeaderId { get; set; }

    public double PlannedHours { get; set; }

    public double PlannedExpendableParts { get; set; }

    public double PlannedReplacementParts { get; set; }

    public double RealizedHours { get; set; }

    public double RealizedExpendableParts { get; set; }

    public double RealizedReplacementParts { get; set; }

    public Guid? Absence { get; set; }

    public string HeaderNotes { get; set; } = null!;

    public string ActivityType { get; set; } = null!;

    public string ProblemCode { get; set; } = null!;

    public string ProblemDescription { get; set; } = null!;

    public string ProblemRemarks { get; set; } = null!;

    public string SolutionCode { get; set; } = null!;

    public string SolutionDescription { get; set; } = null!;

    public string SolutionRemarks { get; set; } = null!;

    public string ServiceItemCode { get; set; } = null!;

    public string ServiceItemDescription { get; set; } = null!;

    public int ServiceItemAssortment { get; set; }

    public string ServiceSerialNumber { get; set; } = null!;

    public string ServiceSndescription { get; set; } = null!;

    public string PartItemCode { get; set; } = null!;

    public string PartItemDescription { get; set; } = null!;

    public int PartItemAssortment { get; set; }

    public string PartSerialNumber { get; set; } = null!;

    public string PartSndescription { get; set; } = null!;

    public string ContractNumber { get; set; } = null!;

    public string ContractProject { get; set; } = null!;

    public string ContractContact { get; set; } = null!;

    public string ContractContactKey { get; set; } = null!;

    public string ContractCostCenter { get; set; } = null!;

    public string ContractCostUnit { get; set; } = null!;

    public int ContractVatcode { get; set; }

    public string ContractServiceAddress1 { get; set; } = null!;

    public string ContractServiceAddress2 { get; set; } = null!;

    public string ContractServiceAddress3 { get; set; } = null!;

    public string ContractServiceAddressPostCode { get; set; } = null!;

    public string ContractServiceAddressCity { get; set; } = null!;

    public string ContractServiceAddressState { get; set; } = null!;

    public string ContractServiceAddressCounty { get; set; } = null!;

    public string ContractServiceAddressPhone { get; set; } = null!;

    public string ContractServiceAddressFax { get; set; } = null!;

    public string ContractServiceAddressRemarks { get; set; } = null!;

    public string ContractContactFirstName { get; set; } = null!;

    public string ContractContactLastName { get; set; } = null!;

    public string ContractContactMiddleName { get; set; } = null!;

    public string ContractContactFullName { get; set; } = null!;

    public string ContractContactInitials { get; set; } = null!;

    public string ContractContactTitle { get; set; } = null!;

    public string ContractContactKeyFirstName { get; set; } = null!;

    public string ContractContactKeyLastName { get; set; } = null!;

    public string ContractContactKeyMiddleName { get; set; } = null!;

    public string ContractContactKeyFullName { get; set; } = null!;

    public string ContractContactKeyInitials { get; set; } = null!;

    public string ContractContactKeyTitle { get; set; } = null!;

    public double HoursRequired { get; set; }

    public string DetailNotes { get; set; } = null!;

    public double? Quantity { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? EndTime { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? NetPrice { get; set; }

    public decimal? Amount { get; set; }

    public Guid? JobDetailId { get; set; }

    public string Type { get; set; } = null!;

    public string Resource { get; set; } = null!;

    public string WarehouseCode { get; set; } = null!;

    public string WarehouseName { get; set; } = null!;

    public string InvAccountCode { get; set; } = null!;

    public string InvAccountName { get; set; } = null!;

    public string InvAccountAddress1 { get; set; } = null!;

    public string InvAccountAddress2 { get; set; } = null!;

    public string InvAccountAddress3 { get; set; } = null!;

    public string InvAccountPostCode { get; set; } = null!;

    public string InvAccountCity { get; set; } = null!;

    public string InvAccountCounty { get; set; } = null!;

    public string InvAccountState { get; set; } = null!;

    public string InvAccountCountry { get; set; } = null!;

    public string InvAccountEmail { get; set; } = null!;

    public string InvAccountFax { get; set; } = null!;

    public string InvAccountPhone { get; set; } = null!;

    public string InvAccountReseller { get; set; } = null!;

    public string InvAccountContactFirstName { get; set; } = null!;

    public string InvAccountContactLastName { get; set; } = null!;

    public string InvAccountContactMiddleName { get; set; } = null!;

    public string InvAccountContactFullName { get; set; } = null!;

    public string InvAccountContactInitials { get; set; } = null!;

    public string InvAccountContactTitle { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public int ItemAssortment { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string SerialNumberDescription { get; set; } = null!;
}
