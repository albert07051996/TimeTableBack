using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class FeedAttachment
{
    public Guid Id { get; set; }

    public int OrderId { get; set; }

    public string? EntityKey { get; set; }

    public int EntityType { get; set; }

    public string EntityName { get; set; } = null!;

    public Guid FeedId { get; set; }

    public byte Type { get; set; }
}
