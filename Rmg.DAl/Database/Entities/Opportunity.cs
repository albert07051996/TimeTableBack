using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Opportunity
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Owner { get; set; }

    public Guid AccountId { get; set; }

    public string Division { get; set; } = null!;

    public string CostCenter { get; set; } = null!;

    public DateTime? PlannedStartDate { get; set; }

    public DateTime? PlannedEndDate { get; set; }

    public int? Probability { get; set; }

    public string Currency { get; set; } = null!;

    public double? PlannedAmount { get; set; }

    public double? PlannedAmountFc { get; set; }

    public double? ExpectedAmount { get; set; }

    public double? ExpectedAmountFc { get; set; }

    public double? RealizedAmount { get; set; }

    public double? RealizedAmountFc { get; set; }

    public int SalesCycleId { get; set; }

    public int? Assortment { get; set; }

    public int? SourceId { get; set; }

    public int? StageId { get; set; }

    public string DealStatus { get; set; } = null!;

    public DateTime? DealWonDate { get; set; }

    public DateTime? DealLostDate { get; set; }

    public Guid? LostTo { get; set; }

    public int? ReasonLost { get; set; }

    public string? Remarks { get; set; }

    public int SecurityLevel { get; set; }

    public double NumberField1 { get; set; }

    public double NumberField2 { get; set; }

    public double NumberField3 { get; set; }

    public double NumberField4 { get; set; }

    public double NumberField5 { get; set; }

    public DateTime? DateField1 { get; set; }

    public DateTime? DateField2 { get; set; }

    public DateTime? DateField3 { get; set; }

    public DateTime? DateField4 { get; set; }

    public DateTime? DateField5 { get; set; }

    public int NumIntField1 { get; set; }

    public int NumIntField2 { get; set; }

    public int NumIntField3 { get; set; }

    public int NumIntField4 { get; set; }

    public int NumIntField5 { get; set; }

    public string? TextField1 { get; set; }

    public string? TextField2 { get; set; }

    public string? TextField3 { get; set; }

    public string? TextField4 { get; set; }

    public string? TextField5 { get; set; }

    public string? TextField6 { get; set; }

    public string? TextField7 { get; set; }

    public string? TextField8 { get; set; }

    public string? TextField9 { get; set; }

    public string? TextField10 { get; set; }

    public bool? YesNoField1 { get; set; }

    public bool? YesNoField2 { get; set; }

    public bool? YesNoField3 { get; set; }

    public bool? YesNoField4 { get; set; }

    public bool? YesNoField5 { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public string? ProjectNumber { get; set; }

    public Guid? ContactId { get; set; }

    public string? AdditionalRemarks { get; set; }
}
