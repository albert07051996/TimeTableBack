using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class LicenseUserLogEse
{
    public long LogId { get; set; }

    public long SnapshotId { get; set; }

    public byte BatchNum { get; set; }

    public string LogTransId { get; set; } = null!;

    public DateTime LogDate { get; set; }

    public string LicNumber { get; set; } = null!;

    public string DbPath { get; set; } = null!;

    public string LogUsr { get; set; } = null!;

    public DateTime? LogStart { get; set; }

    public DateTime? LogInactive { get; set; }

    public string? LogStatus { get; set; }

    public byte LogBlocked { get; set; }

    public string? LogRoles { get; set; }

    public string? LogDivision { get; set; }

    public DateTime Snapshotcreated { get; set; }

    public DateTime Logcreated { get; set; }
}
