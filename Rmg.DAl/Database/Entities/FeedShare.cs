using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class FeedShare
{
    public Guid Id { get; set; }

    public Guid FeedId { get; set; }

    public Guid SocialIdentityId { get; set; }

    public byte Status { get; set; }
}
