using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class LicenseUserSnapshot
{
    public long SnapshotId { get; set; }

    public string LogTransId { get; set; } = null!;

    public DateTime LogDate { get; set; }

    public string LicNumber { get; set; } = null!;

    public string DbPath { get; set; } = null!;

    public byte LogBatchTotal { get; set; }

    public byte LogProcessTotal { get; set; }

    public short LogSource { get; set; }

    public DateTime Syscreated { get; set; }

    public DateTime? Sysmodified { get; set; }
}
