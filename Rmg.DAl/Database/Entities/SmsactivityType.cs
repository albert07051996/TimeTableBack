using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsactivityType
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Note { get; set; }

    public string? Bedrnr { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
