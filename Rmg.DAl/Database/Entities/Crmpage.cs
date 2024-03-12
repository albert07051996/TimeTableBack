using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Crmpage
{
    public Guid Id { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
