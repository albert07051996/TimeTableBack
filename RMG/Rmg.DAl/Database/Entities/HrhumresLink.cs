using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrhumresLink
{
    public int Id { get; set; }

    public int ResId { get; set; }

    public int ChildId { get; set; }

    public string? Type { get; set; }

    public bool MainLink { get; set; }

    public DateTime? LinkedDate { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
