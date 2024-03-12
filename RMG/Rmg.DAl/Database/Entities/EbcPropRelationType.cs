using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcPropRelationType
{
    public int PropRelationTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<EbcPropRelation> EbcPropRelations { get; set; } = new List<EbcPropRelation>();
}
