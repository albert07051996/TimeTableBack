using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcComponent
{
    public Guid CompId { get; set; }

    public int GroupId { get; set; }

    public int ComponentTypeId { get; set; }

    public string ComponentName { get; set; } = null!;

    public string? Description { get; set; }

    public int? TermId { get; set; }

    public string? ProgId { get; set; }

    public string? Assembly { get; set; }

    public string? Class { get; set; }

    public int? DataComponentTypeId { get; set; }

    public string? BaseTable { get; set; }

    public string? Query { get; set; }

    public string? Params { get; set; }

    public string? QueryKey { get; set; }

    public int? CacheSize { get; set; }

    public bool Placeholders { get; set; }

    public bool Log { get; set; }

    public string? ComponentNameWs { get; set; }

    public virtual EbcComponentType ComponentType { get; set; } = null!;

    public virtual EbcDataComponentType? DataComponentType { get; set; }

    public virtual ICollection<EbcComponentRelation> EbcComponentRelationCompId1Navigations { get; set; } = new List<EbcComponentRelation>();

    public virtual ICollection<EbcComponentRelation> EbcComponentRelationCompId2Navigations { get; set; } = new List<EbcComponentRelation>();

    public virtual ICollection<EbcProp> EbcProps { get; set; } = new List<EbcProp>();

    public virtual EbcGroup Group { get; set; } = null!;
}
