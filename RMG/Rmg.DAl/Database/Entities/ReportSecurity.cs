using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ReportSecurity
{
    public Guid Id { get; set; }

    public int Type { get; set; }

    public Guid Report { get; set; }

    public int? Role { get; set; }

    public int? Resource { get; set; }

    public string? Project { get; set; }

    public int? RoleLevel { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public virtual Prproject? ProjectNavigation { get; set; }

    public virtual Report ReportNavigation { get; set; } = null!;
}
