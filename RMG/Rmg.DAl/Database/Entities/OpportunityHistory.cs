using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OpportunityHistory
{
    public int Id { get; set; }

    public int OpportunityId { get; set; }

    public int StageId { get; set; }

    public string DealStatus { get; set; } = null!;

    public double PlannedAmount { get; set; }

    public double PlannedAmountFc { get; set; }

    public double ExpectedAmount { get; set; }

    public double ExpectedAmountFc { get; set; }

    public int Probability { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
