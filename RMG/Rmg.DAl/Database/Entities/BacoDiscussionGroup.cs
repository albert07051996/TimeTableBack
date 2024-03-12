using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionGroup
{
    public int Id { get; set; }

    public int GroupOrder { get; set; }

    public string Description { get; set; } = null!;

    public bool AllowReplies { get; set; }

    public bool RestrictedRights { get; set; }

    public bool Publish { get; set; }

    public byte[]? GroupIcon { get; set; }

    public string? GroupIconFileName { get; set; }

    public byte UseProductLine { get; set; }

    public byte UseItems { get; set; }

    public byte UseHumResId { get; set; }

    public byte UseCmpWwn { get; set; }

    public byte UseLanguageId { get; set; }

    public byte UseCompGroup { get; set; }

    public byte UseCompany { get; set; }

    public byte UseProjectNr { get; set; }

    public byte UseEntryKey { get; set; }

    public byte UseVote { get; set; }

    public Guid? TemplateId { get; set; }

    public byte? UseReports { get; set; }

    public byte UseItemNumber { get; set; }

    public byte UseOpportunity { get; set; }

    public short? Division { get; set; }
}
