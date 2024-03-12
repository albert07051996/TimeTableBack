using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OpportunityProject
{
    public int Id { get; set; }

    public int OpportunityId { get; set; }

    public string ProjectCode { get; set; } = null!;

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
