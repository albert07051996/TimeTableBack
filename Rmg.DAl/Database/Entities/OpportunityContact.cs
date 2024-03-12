using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OpportunityContact
{
    public int Id { get; set; }

    public int OpportunityId { get; set; }

    public Guid AccountId { get; set; }

    public Guid ContactId { get; set; }

    public int RoleId { get; set; }

    public bool MainContact { get; set; }

    public string Type { get; set; } = null!;

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
