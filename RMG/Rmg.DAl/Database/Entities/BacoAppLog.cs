using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoAppLog
{
    public Guid Id { get; set; }

    public DateTime Created { get; set; }

    public int SessionId { get; set; }

    public int HumresId { get; set; }

    public int? DelegateId { get; set; }

    public int SecurityLevel { get; set; }

    public Guid? CustomerId { get; set; }

    public string App { get; set; } = null!;

    public string? QueryString { get; set; }

    public string? DataKey { get; set; }

    public string? ServerName { get; set; }

    public string? ServerAddress { get; set; }

    public string? HostName { get; set; }

    public string? ClientAddress { get; set; }

    public int? Duration { get; set; }

    public int? Spid { get; set; }

    public short? Division { get; set; }
}
