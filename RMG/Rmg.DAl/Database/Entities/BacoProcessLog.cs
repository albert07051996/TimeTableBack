using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoProcessLog
{
    public int LogId { get; set; }

    public DateTime LogDate { get; set; }

    public int HumresId { get; set; }

    public string ProcessName { get; set; } = null!;

    public int LogType { get; set; }

    public string? LogText { get; set; }

    public string? CommandLine { get; set; }

    public string? Server { get; set; }

    public short? Division { get; set; }
}
