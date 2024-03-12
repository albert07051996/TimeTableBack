using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HreffectivedateDataLog
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public int ResId { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string? Status { get; set; }

    public byte UpdateContractEnd { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
