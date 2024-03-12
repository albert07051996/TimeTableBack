using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoSearchTemplateField
{
    public Guid Id { get; set; }

    public Guid TemplateId { get; set; }

    public int FieldType { get; set; }

    public string Field { get; set; } = null!;

    public string? Value { get; set; }

    public short? Division { get; set; }
}
