using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SearchTemplateField
{
    public Guid Id { get; set; }

    public Guid Template { get; set; }

    public short? Division { get; set; }

    public int FieldType { get; set; }

    public string Field { get; set; } = null!;

    public string? Value { get; set; }
}
