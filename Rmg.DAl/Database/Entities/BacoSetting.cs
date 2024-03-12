using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoSetting
{
    public int SettingType { get; set; }

    public string SettingGroup { get; set; } = null!;

    public string SettingName { get; set; } = null!;

    public int ValueType { get; set; }

    public string? StringValue { get; set; }

    public int? LongValue { get; set; }

    public double? DoubleValue { get; set; }

    public DateTime? DateValue { get; set; }

    public string? Xmlvalue { get; set; }

    public short? Division { get; set; }
}
