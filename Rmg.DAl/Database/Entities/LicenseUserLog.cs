using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class LicenseUserLog
{
    public long LogId { get; set; }

    public long SnapshotId { get; set; }

    public byte BatchNum { get; set; }

    public string LogUsr { get; set; } = null!;

    public DateTime? LogStart { get; set; }

    public DateTime? LogInactive { get; set; }

    public string? LogStatus { get; set; }

    public byte LogBlocked { get; set; }

    public string? LogRoles { get; set; }

    public string? LogDivision { get; set; }

    public DateTime Syscreated { get; set; }
}
