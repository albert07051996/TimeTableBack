using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SsrsreportGroup
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Customer { get; set; }

    public bool? Reseller { get; set; }

    public bool Hidden { get; set; }

    public bool Deployed { get; set; }

    public int Module { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int NameTermId { get; set; }

    public bool AllowWord { get; set; }

    public bool AllowExcel { get; set; }

    public bool AllowPdf { get; set; }

    public bool AllowPrint { get; set; }

    public virtual ICollection<Ssrsreport> Ssrsreports { get; set; } = new List<Ssrsreport>();
}
