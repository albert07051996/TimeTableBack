using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmpersonalObjective
{
    public Guid Id { get; set; }

    public Guid ProfileId { get; set; }

    public Guid HeaderId { get; set; }

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DateCreated { get; set; }

    public string? Remark { get; set; }

    public string? StringValue { get; set; }

    public double? DoubleValue { get; set; }

    public DateTime? DateValue { get; set; }

    public bool? YesNoValue { get; set; }

    public short? SelectionValue { get; set; }

    public Guid? GuidValue { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
