using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class FeedFilterTab
{
    public Guid Id { get; set; }

    public int ResourceId { get; set; }

    public int TabType { get; set; }

    public string? TabName { get; set; }

    public bool? DefaultCustomTab { get; set; }

    public string? FilterOptionXml { get; set; }

    public DateTime? Syscreated { get; set; }

    public int? Syscreator { get; set; }

    public DateTime? Sysmodified { get; set; }

    public int? Sysmodifier { get; set; }
}
