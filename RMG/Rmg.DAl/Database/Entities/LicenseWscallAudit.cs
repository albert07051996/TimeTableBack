using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class LicenseWscallAudit
{
    public Guid AuditId { get; set; }

    public DateTime LogDate { get; set; }

    public int LogId { get; set; }

    public byte[] FromLdata { get; set; } = null!;

    public byte[]? ToLdata { get; set; }

    public Guid? FromAccountId { get; set; }

    public Guid? ToAccountId { get; set; }
}
