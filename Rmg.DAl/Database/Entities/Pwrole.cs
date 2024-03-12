using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Pwrole
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? Descr64 { get; set; }

    public int RbId { get; set; }

    public string? JobGroup { get; set; }

    public byte Visible { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
