using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Setting
{
    public string SettingGroup { get; set; } = null!;

    public string SettingName { get; set; } = null!;

    public int ValueType { get; set; }

    public byte? BitValue { get; set; }

    public int? LongValue { get; set; }

    public double? DblValue { get; set; }

    public DateTime? DateValue { get; set; }

    public string? StringValue { get; set; }

    public byte[]? BinaryValue { get; set; }

    public byte? Editable { get; set; }

    public string? Description { get; set; }

    public int? TermId { get; set; }

    public string? Category { get; set; }

    public string? Profile { get; set; }

    public short? Division { get; set; }
}
