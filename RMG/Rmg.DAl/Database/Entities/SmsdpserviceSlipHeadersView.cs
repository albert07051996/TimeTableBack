using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdpserviceSlipHeadersView
{
    public Guid AbsenceId { get; set; }

    public int RequestType { get; set; }

    public int RefTypeGuid1 { get; set; }

    public int RefTypeGuid2 { get; set; }

    public int RefTypeGuid3 { get; set; }

    public int RefTypeGuid4 { get; set; }

    public int RefTypeGuid5 { get; set; }

    public string? Requestnumber { get; set; }

    public string RequestDescription { get; set; } = null!;

    public string RemarksRequest { get; set; } = null!;

    public string RemarksWorkflow { get; set; } = null!;

    public string FreeText1 { get; set; } = null!;

    public string FreeText2 { get; set; } = null!;

    public string FreeText3 { get; set; } = null!;

    public string FreeText4 { get; set; } = null!;

    public string FreeText5 { get; set; } = null!;

    public DateTime? FreeDate1 { get; set; }

    public DateTime? FreeDate2 { get; set; }

    public DateTime? FreeDate3 { get; set; }

    public DateTime? FreeDate4 { get; set; }

    public DateTime? FreeDate5 { get; set; }

    public string FreeYesNo1 { get; set; } = null!;

    public string FreeYesNo2 { get; set; } = null!;

    public string FreeYesNo3 { get; set; } = null!;

    public string FreeYesNo4 { get; set; } = null!;

    public string FreeYesNo5 { get; set; } = null!;

    public string FreeNumber1 { get; set; } = null!;

    public string FreeNumber2 { get; set; } = null!;

    public string FreeNumber3 { get; set; } = null!;

    public string FreeNumber4 { get; set; } = null!;

    public string FreeNumber5 { get; set; } = null!;

    public string FreeAmount1 { get; set; } = null!;

    public string FreeAmount2 { get; set; } = null!;

    public string FreeAmount3 { get; set; } = null!;

    public string FreeAmount4 { get; set; } = null!;

    public string FreeAmount5 { get; set; } = null!;

    public string? FreeGuid1 { get; set; }

    public string? FreeGuid2 { get; set; }

    public string? FreeGuid3 { get; set; }

    public string? FreeGuid4 { get; set; }

    public string? FreeGuid5 { get; set; }

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

    public decimal? TotalAmountPlannedIncl { get; set; }

    public decimal? TotalAmountRealizedIncl { get; set; }
}
