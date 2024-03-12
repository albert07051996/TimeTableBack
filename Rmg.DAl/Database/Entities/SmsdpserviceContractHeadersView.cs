using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdpserviceContractHeadersView
{
    public Guid Id { get; set; }

    public string ContractNumber { get; set; } = null!;

    public string? Status { get; set; }

    public string? Currency { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public string ContractType { get; set; } = null!;

    public string ContractTypeDescription { get; set; } = null!;

    public string Project { get; set; } = null!;

    public string ProjectDescription { get; set; } = null!;

    public string CostCenter { get; set; } = null!;

    public string CostCenterDescription { get; set; } = null!;

    public string CostUnit { get; set; } = null!;

    public string CostUnitDescription { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string PostCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Reseller { get; set; } = null!;

    public string Parent { get; set; } = null!;

    public string PhoneQueue { get; set; } = null!;

    public string ChamberOfCommerce { get; set; } = null!;

    public string DunsNumber { get; set; } = null!;

    public string InvAccountCode { get; set; } = null!;

    public string InvAccountName { get; set; } = null!;

    public string InvAddress1 { get; set; } = null!;

    public string InvAddress2 { get; set; } = null!;

    public string InvAddress3 { get; set; } = null!;

    public string InvPostCode { get; set; } = null!;

    public string InvCity { get; set; } = null!;

    public string InvCounty { get; set; } = null!;

    public string InvState { get; set; } = null!;

    public string InvEmail { get; set; } = null!;

    public string InvFax { get; set; } = null!;

    public string InvPhone { get; set; } = null!;

    public string InvReseller { get; set; } = null!;

    public string InvParent { get; set; } = null!;

    public string InvPhoneQueue { get; set; } = null!;

    public string InvChamberOfCommerce { get; set; } = null!;

    public string InvDunsNumber { get; set; } = null!;

    public string ServInvAccountCode1 { get; set; } = null!;

    public string ServInvAccountName1 { get; set; } = null!;

    public string ServInvAccountCode2 { get; set; } = null!;

    public string ServInvAccountName2 { get; set; } = null!;

    public string ServInvAccountCode3 { get; set; } = null!;

    public string ServInvAccountName3 { get; set; } = null!;

    public string ServInvAccountCode4 { get; set; } = null!;

    public string ServInvAccountName4 { get; set; } = null!;

    public string ServInvAccountCode5 { get; set; } = null!;

    public string ServInvAccountName5 { get; set; } = null!;

    public string ServiceAddress1 { get; set; } = null!;

    public string ServiceAddress2 { get; set; } = null!;

    public string ServiceAddress3 { get; set; } = null!;

    public string ServiceAddressPostCode { get; set; } = null!;

    public string ServiceAddressCity { get; set; } = null!;

    public string ServiceAddressState { get; set; } = null!;

    public string ServiceAddressCounty { get; set; } = null!;

    public string ServiceAddressPhone { get; set; } = null!;

    public string ServiceAddressFax { get; set; } = null!;

    public string ServiceAddressRemarks { get; set; } = null!;

    public string ContactFirstName { get; set; } = null!;

    public string ContactLastName { get; set; } = null!;

    public string ContactMiddleName { get; set; } = null!;

    public string ContactFullName { get; set; } = null!;

    public string ContactInitials { get; set; } = null!;

    public string ContactTitle { get; set; } = null!;

    public string ContactKeyFirstName { get; set; } = null!;

    public string ContactKeyLastName { get; set; } = null!;

    public string ContactKeyMiddleName { get; set; } = null!;

    public string ContactKeyFullName { get; set; } = null!;

    public string ContactKeyInitials { get; set; } = null!;

    public string ContactKeyTitle { get; set; } = null!;

    public decimal TotalTaxAmount { get; set; }

    public decimal TotalAmountIncl { get; set; }
}
