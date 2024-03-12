using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmcompetenceProfile
{
    public Guid Id { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? JobGroup { get; set; }

    public string? JobActivity { get; set; }

    public string? JobTitle { get; set; }

    public string? Project { get; set; }

    public string? ItemCode { get; set; }

    public int? ResourceId { get; set; }

    public double? Weight { get; set; }

    public int? ReviewerId { get; set; }

    public string Status { get; set; } = null!;

    public short? Division { get; set; }

    public string? Rating { get; set; }

    public Guid? RequestId { get; set; }

    public DateTime? RequestStartDate { get; set; }

    public string? CompanyCode { get; set; }

    public double Score { get; set; }

    public string? Remark { get; set; }

    public string? RequestRemarks { get; set; }

    public Guid? DocumentId { get; set; }

    public DateTime? AgreementDate { get; set; }

    public bool Active { get; set; }

    public Guid? GroupId { get; set; }

    public bool AddObjectives { get; set; }

    public bool ShowObjectives { get; set; }

    public string RateObjectives { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
