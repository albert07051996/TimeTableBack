using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SearchTemplate
{
    public Guid Id { get; set; }

    public short? Division { get; set; }

    public string SearchCode { get; set; } = null!;

    public int? Resource { get; set; }

    public string Description { get; set; } = null!;

    public int? SalesCycleId { get; set; }

    public byte TemplateType { get; set; }

    public DateTime? Syscreated { get; set; }

    public int? Syscreator { get; set; }
}
