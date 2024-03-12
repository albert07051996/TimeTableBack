using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Report
{
    public Guid Id { get; set; }

    public short ReportSource { get; set; }

    public int? BireportId { get; set; }

    public int Hid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Content { get; set; }

    public string ContentName { get; set; } = null!;

    public string? Parameters { get; set; }

    public Guid? Category { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public virtual ReportCategory? CategoryNavigation { get; set; }

    public virtual ICollection<ReportSecurity> ReportSecurities { get; set; } = new List<ReportSecurity>();
}
