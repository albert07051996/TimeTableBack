using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OpportunityReason
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
