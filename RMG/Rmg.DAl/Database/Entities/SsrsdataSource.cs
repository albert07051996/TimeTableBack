using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SsrsdataSource
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Extension { get; set; }

    public string? ConnectionString { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Domain { get; set; }

    public bool Hidden { get; set; }

    public bool Deployed { get; set; }

    public string? ServerName { get; set; }

    public string? DatabaseName { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
