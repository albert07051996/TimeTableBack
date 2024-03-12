using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SsrsreportParameter
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid Idreport { get; set; }

    public string ValueType { get; set; } = null!;

    public string? DefaultValue { get; set; }

    public int GetValueFrom { get; set; }

    public bool Mode { get; set; }

    public string? Prompt { get; set; }

    public int? PromptTermId { get; set; }

    public int? ParamIndex { get; set; }

    public string? StandardBrowser { get; set; }

    public string? Dependency { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual Ssrsreport IdreportNavigation { get; set; } = null!;
}
