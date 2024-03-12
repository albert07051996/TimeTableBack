using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdpcompressedPlanningLinesView
{
    public int ResourceId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? HeaderStartDate { get; set; }

    public string JobHeaderId { get; set; } = null!;

    public string? RequestNumber { get; set; }

    public string RequestDescription { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string CustomerAddress1 { get; set; } = null!;

    public string CustomerAddress2 { get; set; } = null!;

    public string CustomerAddress3 { get; set; } = null!;

    public string CustomerPostCode { get; set; } = null!;

    public string CustomerCity { get; set; } = null!;

    public string CustomerCounty { get; set; } = null!;

    public string CustomerState { get; set; } = null!;

    public string CustomerCountry { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string CustomerFax { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public string CustomerReseller { get; set; } = null!;

    public string CustomerParent { get; set; } = null!;

    public string ContactFirstName { get; set; } = null!;

    public string ContactLastName { get; set; } = null!;

    public string ContactMiddleName { get; set; } = null!;

    public string ContactFullName { get; set; } = null!;

    public string ContactInitials { get; set; } = null!;

    public string ContactTitle { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string ActivityType { get; set; } = null!;

    public string ProblemCode { get; set; } = null!;

    public string ProblemDescription { get; set; } = null!;

    public string ProblemRemarks { get; set; } = null!;

    public string SolutionCode { get; set; } = null!;

    public string SolutionDescription { get; set; } = null!;

    public string SolutionRemarks { get; set; } = null!;

    public string ServiceItemCode { get; set; } = null!;

    public string ServiceItemDescription { get; set; } = null!;

    public string ServiceSerialNumber { get; set; } = null!;

    public string ServiceSndescription { get; set; } = null!;

    public string PartItemCode { get; set; } = null!;

    public string PartItemDescription { get; set; } = null!;

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

    public string ContractServiceAddressCountry { get; set; } = null!;

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

    public Guid AbsenceId { get; set; }
}
