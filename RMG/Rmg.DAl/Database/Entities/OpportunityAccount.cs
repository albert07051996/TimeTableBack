using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OpportunityAccount
{
    public int Id { get; set; }

    public int OpportunityId { get; set; }

    public Guid AccountId { get; set; }

    public string Type { get; set; } = null!;

    public int? StrengthId { get; set; }

    public int? WeaknessId { get; set; }

    public int? RoleId { get; set; }

    public string Status { get; set; } = null!;

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
