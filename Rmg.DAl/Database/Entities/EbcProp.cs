using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcProp
{
    public Guid PropId { get; set; }

    public Guid CompId { get; set; }

    public string PropName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Caption { get; set; }

    public int CaptionTermId { get; set; }

    public string? CaptionSuffix { get; set; }

    public int? CaptionSuffixTermId { get; set; }

    public Guid PropTypeId { get; set; }

    public Guid? BrowseId { get; set; }

    public int EnabledStateId { get; set; }

    public int NoEmpty { get; set; }

    public string? ValidationQuery { get; set; }

    public int DefaultTypeId { get; set; }

    public int DefaultStateId { get; set; }

    public string? DefaultValue { get; set; }

    public string? LowerRange { get; set; }

    public string? UpperRange { get; set; }

    public int ExactMatch { get; set; }

    public string? SelectionValues { get; set; }

    public string? Options { get; set; }

    public int Log { get; set; }

    public string? PropNameWs { get; set; }

    public bool SecurityContextIncluded { get; set; }

    public bool PropExposedWs { get; set; }

    public virtual EbcBrowser? Browse { get; set; }

    public virtual EbcComponent Comp { get; set; } = null!;

    public virtual EbcDefaultState DefaultState { get; set; } = null!;

    public virtual EbcDefaultType DefaultType { get; set; } = null!;

    public virtual ICollection<EbcPropRelation> EbcPropRelations { get; set; } = new List<EbcPropRelation>();

    public virtual EbcEnabledState EnabledState { get; set; } = null!;

    public virtual EbcPropType PropType { get; set; } = null!;
}
