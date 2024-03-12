using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ProjectDeliverable
{
    public Guid Id { get; set; }

    public string DeliverableCode { get; set; } = null!;

    public bool IsMain { get; set; }

    public string Description { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? ParentDeliverable { get; set; }

    public string? ParentDeliverableProjectNumber { get; set; }

    public string ProjectNumber { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int State { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
