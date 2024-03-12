using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Feed
{
    public Guid Id { get; set; }

    public string? AttachedObject { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatorId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? FeedText { get; set; }

    public int Type { get; set; }

    public string? Metadata { get; set; }

    public DateTime? EffectiveStart { get; set; }

    public DateTime? EffectiveEnd { get; set; }

    public int Status { get; set; }

    public string? Title { get; set; }

    public string? Summary { get; set; }
}
