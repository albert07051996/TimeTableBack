using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmcompetenceHierarchy
{
    public Guid? CompetenceRelationId { get; set; }

    public string? FullSequenceNr { get; set; }

    public string? FullPath { get; set; }

    public Guid? CompetenceId { get; set; }

    public Guid? GroupId { get; set; }

    public Guid? FieldTypeId { get; set; }

    public bool? PersonalObjectiveHeader { get; set; }
}
