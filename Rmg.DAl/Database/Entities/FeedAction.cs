using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class FeedAction
{
    public Guid Id { get; set; }

    public Guid FeedId { get; set; }

    public Guid SocialIdentityId { get; set; }

    public bool Flagged { get; set; }

    public bool Dismissed { get; set; }

    public DateTime? PostponeDate { get; set; }
}
