using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsresponseTime
{
    public Guid Id { get; set; }

    public double? Number { get; set; }

    public string? TimeUnit { get; set; }

    public string? Bedrnr { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
