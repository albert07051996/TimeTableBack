using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SocialLike
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public Guid CreatorId { get; set; }

    public int Type { get; set; }

    public short OwnerType { get; set; }
}
