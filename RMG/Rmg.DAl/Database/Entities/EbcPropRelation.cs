using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcPropRelation
{
    public Guid PropRelationId { get; set; }

    public int? PropRelationStateId { get; set; }

    public int? PropRelationTypeId { get; set; }

    public Guid CompRelationId { get; set; }

    public Guid? PropId { get; set; }

    public string? PropValue { get; set; }

    public string PropName { get; set; } = null!;

    public string? PropRelationValue { get; set; }

    public bool Enabled { get; set; }

    public virtual EbcComponentRelation CompRelation { get; set; } = null!;

    public virtual EbcProp? Prop { get; set; }

    public virtual EbcPropRelationState? PropRelationState { get; set; }

    public virtual EbcPropRelationType? PropRelationType { get; set; }
}
