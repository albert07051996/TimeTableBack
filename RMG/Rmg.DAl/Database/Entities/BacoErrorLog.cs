using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoErrorLog
{
    public int LogId { get; set; }

    public DateTime LogDate { get; set; }

    public int SessionId { get; set; }

    public int HumresId { get; set; }

    public Guid? CustomerId { get; set; }

    public string? App { get; set; }

    public string? WebServer { get; set; }

    public string? Machine { get; set; }

    public string? LogText { get; set; }

    public short? Division { get; set; }
}
