using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Taal
{
    public int Id { get; set; }

    public string? Taalcode { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public string? OmsOrg { get; set; }

    public byte Active { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
