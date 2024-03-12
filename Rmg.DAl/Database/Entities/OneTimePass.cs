using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OneTimePass
{
    public int OtprequestId { get; set; }

    public Guid Id { get; set; }

    public int Assortment { get; set; }

    public string Otpvalue { get; set; } = null!;

    public string ValidityDate { get; set; } = null!;

    public string Counter { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
