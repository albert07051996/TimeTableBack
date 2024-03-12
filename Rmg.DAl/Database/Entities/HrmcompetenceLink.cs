using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmcompetenceLink
{
    public Guid Id { get; set; }

    public Guid? CompetenceId { get; set; }

    public Guid? ProfileId { get; set; }

    public Guid? FormElementId { get; set; }

    public string? StringValue { get; set; }

    public double? DoubleValue { get; set; }

    public DateTime? DateValue { get; set; }

    public bool? YesNoValue { get; set; }

    public short? SelectionValue { get; set; }

    public Guid? GuidValue { get; set; }

    public double? Weight { get; set; }

    public short GroupSequenceNr { get; set; }

    public short? Division { get; set; }

    public Guid? ParentId { get; set; }

    public byte? Level { get; set; }

    public string? Frequency { get; set; }

    public string? Remark { get; set; }

    public int? SequenceNumber { get; set; }

    public Guid? CardLayoutId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
