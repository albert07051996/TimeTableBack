using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrfreeField
{
    public Guid Id { get; set; }

    public string CompanyNr { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string? TextField1 { get; set; }

    public string? TextField2 { get; set; }

    public string? TextField3 { get; set; }

    public string? TextField4 { get; set; }

    public string? TextField5 { get; set; }

    public string? DateField1 { get; set; }

    public string? DateField2 { get; set; }

    public string? DateField3 { get; set; }

    public string? DateField4 { get; set; }

    public string? DateField5 { get; set; }

    public string? NumberField1 { get; set; }

    public string? NumberField2 { get; set; }

    public string? NumberField3 { get; set; }

    public string? NumberField4 { get; set; }

    public string? NumberField5 { get; set; }

    public string? YesNoField1 { get; set; }

    public string? YesNoField2 { get; set; }

    public string? YesNoField3 { get; set; }

    public string? YesNoField4 { get; set; }

    public string? YesNoField5 { get; set; }

    public short? Division { get; set; }
}
