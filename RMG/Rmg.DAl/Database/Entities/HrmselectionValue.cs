using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmselectionValue
{
    public Guid Id { get; set; }

    public Guid? FieldTypeId { get; set; }

    public short SequenceNumber { get; set; }

    public short Value { get; set; }

    public string? DisplayValue { get; set; }

    public string? Description { get; set; }

    public double? Weight { get; set; }

    public double? Maximum { get; set; }

    public double? Minimum { get; set; }

    public string? Notes { get; set; }

    public short? Division { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
