using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ssrsdrillthrough
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string ParentReportPath { get; set; } = null!;

    public Guid? RedirectReportId { get; set; }

    public Guid ParentReportId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public virtual ICollection<SsrsdrillthroughParameter> SsrsdrillthroughParameters { get; set; } = new List<SsrsdrillthroughParameter>();
}
