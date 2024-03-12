using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsserviceActivity
{
    public Guid Id { get; set; }

    public Guid? Absence { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public Guid? Address { get; set; }

    public Guid? Problem { get; set; }

    public Guid? Solution { get; set; }

    public Guid? Pmtype { get; set; }

    public bool? Done { get; set; }

    public Guid? Type { get; set; }

    public string Status { get; set; } = null!;

    public int? LineNumber { get; set; }

    public string? Bedrnr { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
