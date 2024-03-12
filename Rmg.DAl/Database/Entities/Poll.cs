using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Poll
{
    public Guid Id { get; set; }

    public byte[]? Picture { get; set; }

    public byte[]? Thumbnail { get; set; }

    public string Question { get; set; } = null!;

    public int Type { get; set; }

    public int ResultDisplayType { get; set; }

    public DateTime? Expiry { get; set; }

    public string? MinRangeLabel { get; set; }

    public string? MaxRangeLabel { get; set; }

    public Guid? FeedId { get; set; }

    public int Syscreator { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Syscreated { get; set; }

    public DateTime Sysmodified { get; set; }
}
