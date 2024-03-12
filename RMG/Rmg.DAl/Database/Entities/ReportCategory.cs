using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ReportCategory
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;

    public Guid? Parent { get; set; }

    public int? Product { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public virtual ICollection<ReportCategory> InverseParentNavigation { get; set; } = new List<ReportCategory>();

    public virtual ReportCategory? ParentNavigation { get; set; }

    public virtual BacoProduct? ProductNavigation { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
