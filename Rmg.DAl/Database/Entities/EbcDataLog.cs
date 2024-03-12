using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcDataLog
{
    public Guid Id { get; set; }

    public Guid Component { get; set; }

    public Guid? Property { get; set; }

    public string DataKey { get; set; } = null!;

    public short Action { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? Comment { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public int? Delegate { get; set; }

    public short? Division { get; set; }
}
