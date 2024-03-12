using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmcompetenceRelation
{
    public Guid Id { get; set; }

    public Guid CompetenceId { get; set; }

    public Guid GroupId { get; set; }

    public Guid? ParentId { get; set; }

    public int Level { get; set; }

    public short SequenceNumber { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
