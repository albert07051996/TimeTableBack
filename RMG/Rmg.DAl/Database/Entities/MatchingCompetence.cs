using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class MatchingCompetence
{
    public Guid Id { get; set; }

    public Guid CompetenceId { get; set; }

    public Guid MatchProfileId { get; set; }

    public bool? Mandatory { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
