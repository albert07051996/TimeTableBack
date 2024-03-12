using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfaspControl
{
    public string Code { get; set; } = null!;

    public string AspCode { get; set; } = null!;

    public int? SqlColumnType { get; set; }

    public string? AspSearchCode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
