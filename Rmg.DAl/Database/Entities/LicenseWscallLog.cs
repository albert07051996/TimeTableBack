using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class LicenseWscallLog
{
    public int LogId { get; set; }

    public DateTime LogDate { get; set; }

    public int HumresId { get; set; }

    public string WebServiceName { get; set; } = null!;

    public string WebServiceResult { get; set; } = null!;

    public string? LicenseContractNumber { get; set; }

    public string? ChamberOfCommerceNumber { get; set; }

    public string? ProductSource { get; set; }

    public string? OperationName { get; set; }

    public string? TransactionId { get; set; }

    public string? Release { get; set; }

    public string? ServicePack { get; set; }
}
