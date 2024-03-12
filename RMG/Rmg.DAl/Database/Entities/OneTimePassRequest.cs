using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OneTimePassRequest
{
    public int Id { get; set; }

    public string RequestId { get; set; } = null!;

    public Guid AccountId { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string LicenseName { get; set; } = null!;

    public string LicenseNumber { get; set; } = null!;

    public DateTime IssueDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public string CustomerLocation { get; set; } = null!;

    public int Assortment { get; set; }

    public DateTime Otpexpiration { get; set; }

    public int Counter { get; set; }

    public string SourceLicenseNumber { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
