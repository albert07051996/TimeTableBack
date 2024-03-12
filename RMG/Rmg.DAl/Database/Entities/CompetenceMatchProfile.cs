using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CompetenceMatchProfile
{
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public Guid ProfileId { get; set; }

    public string? CriteriaField { get; set; }

    public Guid? Account { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
