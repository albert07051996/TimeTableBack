using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcComponentRelationType
{
    public int CompRelationTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<EbcComponentRelation> EbcComponentRelations { get; set; } = new List<EbcComponentRelation>();
}
