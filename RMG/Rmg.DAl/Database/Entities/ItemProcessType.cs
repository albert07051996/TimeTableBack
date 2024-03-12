using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemProcessType
{
    public int Type { get; set; }

    public string? Description { get; set; }

    public int? DocGroup { get; set; }

    public string? DocCategory { get; set; }

    public string? DocSubCategory { get; set; }

    public int DocSecurity { get; set; }

    public int TaskPrio { get; set; }

    public int DocumentType { get; set; }

    public short? Division { get; set; }
}
