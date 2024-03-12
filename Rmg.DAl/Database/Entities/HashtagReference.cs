using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HashtagReference
{
    public Guid Id { get; set; }

    public Guid HashtagId { get; set; }

    public Guid EntityId { get; set; }

    public short EntityType { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
