using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsconfigurationHeader
{
    public Guid Id { get; set; }

    public string ConfigurationCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool? Blocked { get; set; }

    public string? Location { get; set; }

    public int? Engineer { get; set; }

    public string? Project { get; set; }

    public string? Remarks { get; set; }

    public string? TextField1 { get; set; }

    public string? TextField2 { get; set; }

    public string? TextField3 { get; set; }

    public string? TextField4 { get; set; }

    public string? TextField5 { get; set; }

    public int? NumberIntField1 { get; set; }

    public int? NumberIntField2 { get; set; }

    public int? NumberIntField3 { get; set; }

    public int? NumberIntField4 { get; set; }

    public int? NumberIntField5 { get; set; }

    public bool? BoolField1 { get; set; }

    public bool? BoolField2 { get; set; }

    public bool? BoolField3 { get; set; }

    public bool? BoolField4 { get; set; }

    public bool? BoolField5 { get; set; }

    public double? NumberField1 { get; set; }

    public double? NumberField2 { get; set; }

    public double? NumberField3 { get; set; }

    public double? NumberField4 { get; set; }

    public double? NumberField5 { get; set; }

    public DateTime? DateField1 { get; set; }

    public DateTime? DateField2 { get; set; }

    public DateTime? DateField3 { get; set; }

    public DateTime? DateField4 { get; set; }

    public DateTime? DateField5 { get; set; }

    public Guid Account { get; set; }

    public Guid Address { get; set; }

    public string? Bedrnr { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
