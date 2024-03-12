using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Xmlreplication
{
    public Guid Id { get; set; }

    public string Topic { get; set; } = null!;

    public Guid Source { get; set; }

    public Guid? Account { get; set; }

    public string? Division { get; set; }

    public short? DivisionX { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
