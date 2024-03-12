using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmcompentenceReviewProfile
{
    public Guid? CompetenceRelationId { get; set; }

    public Guid? GroupId { get; set; }

    public string? JobActivity { get; set; }

    public int? JobLevel { get; set; }
}
