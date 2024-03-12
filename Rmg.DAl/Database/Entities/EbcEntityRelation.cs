using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcEntityRelation
{
    public Guid EntityRelationId { get; set; }

    public Guid EntityId { get; set; }

    public Guid PropId { get; set; }

    public Guid LinkedPropId { get; set; }
}
