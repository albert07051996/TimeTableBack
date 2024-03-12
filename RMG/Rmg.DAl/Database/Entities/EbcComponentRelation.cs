using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcComponentRelation
{
    public Guid CompRelationId { get; set; }

    public int? CompRelationTypeId { get; set; }

    public string CompRelationName { get; set; } = null!;

    public Guid CompId1 { get; set; }

    public Guid CompId2 { get; set; }

    public string? CompRelationValue { get; set; }

    public bool Enabled { get; set; }

    public string? EnabledQuery { get; set; }

    public string? Options { get; set; }

    public virtual EbcComponent CompId1Navigation { get; set; } = null!;

    public virtual EbcComponent CompId2Navigation { get; set; } = null!;

    public virtual EbcComponentRelationType? CompRelationType { get; set; }

    public virtual ICollection<EbcPropRelation> EbcPropRelations { get; set; } = new List<EbcPropRelation>();
}
