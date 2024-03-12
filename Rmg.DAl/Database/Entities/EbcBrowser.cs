using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcBrowser
{
    public Guid BrowseId { get; set; }

    public string? Name { get; set; }

    public int GroupId { get; set; }

    public string BrowseQuery { get; set; } = null!;

    public string? BrowseResultCol { get; set; }

    public string? BrowseColInfo { get; set; }

    public string? BrowseCaption { get; set; }

    public int BrowseCaptionTermId { get; set; }

    public string? BrowseCaptionSuffix { get; set; }

    public int? BrowseCaptionSuffixTermId { get; set; }

    public string? BrowseParams { get; set; }

    public string? BrowseTables { get; set; }

    public string? RefTable { get; set; }

    public string? RefKey { get; set; }

    public string? RefColumn { get; set; }

    public bool RefLanguageDependent { get; set; }

    public bool Placeholders { get; set; }

    public int SecurityLevel { get; set; }

    public string? MaintenanceApplication { get; set; }

    public Guid? SecurityProvider { get; set; }

    public string? SecurityProviderParameters { get; set; }

    public int? EntityType { get; set; }

    public virtual ICollection<EbcProp> EbcProps { get; set; } = new List<EbcProp>();

    public virtual EbcGroup Group { get; set; } = null!;
}
