using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AccountStatus
{
    public string Status { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? TermId { get; set; }

    public short? Division { get; set; }

    public int Syscreator { get; set; }

    public DateTime Syscreated { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Sysmodified { get; set; }
}
