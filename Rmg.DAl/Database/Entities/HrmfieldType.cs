using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmfieldType
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public string? DefaultStringValue { get; set; }

    public double? DefaultDoubleValue { get; set; }

    public DateTime? DefaultDateValue { get; set; }

    public bool? DefaultYesNoValue { get; set; }

    public short? DefaultSelectionValue { get; set; }

    public Guid? DefaultGuidValue { get; set; }

    public byte Decimals { get; set; }

    public string Module { get; set; } = null!;

    public short? Division { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
