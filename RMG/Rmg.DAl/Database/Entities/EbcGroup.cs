using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcGroup
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public int? TermId { get; set; }

    public string? Suffix { get; set; }

    public int? SuffixId { get; set; }

    public virtual ICollection<EbcBrowser> EbcBrowsers { get; set; } = new List<EbcBrowser>();

    public virtual ICollection<EbcComponent> EbcComponents { get; set; } = new List<EbcComponent>();

    public virtual ICollection<EbcPropType> EbcPropTypes { get; set; } = new List<EbcPropType>();
}
