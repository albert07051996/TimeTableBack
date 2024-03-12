using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ProjectDeliverableVersion
{
    public Guid VersionId { get; set; }

    public double VersionNumber { get; set; }

    public string VersionDescription { get; set; } = null!;

    public DateTime VersionCreatedDate { get; set; }

    public string? ParentDeliverable { get; set; }

    public string DeliverableCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string ProjectNumber { get; set; } = null!;

    public string SnapshotProject { get; set; } = null!;

    public string? ItemCode { get; set; }

    public bool IsMain { get; set; }

    public int State { get; set; }

    public string? WbsrevenueCurrency { get; set; }

    public double? Wbsrevenue { get; set; }

    public string? WbscostCurrency { get; set; }

    public double? Wbscost { get; set; }

    public double? Margin { get; set; }

    public string? ParentDelvProjectNr { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
