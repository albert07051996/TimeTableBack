using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ReportParameter
{
    public Guid Id { get; set; }

    public Guid Report { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DescriptionTermId { get; set; }

    public int Type { get; set; }

    public int Browser { get; set; }

    public string? DefaultValue { get; set; }

    public byte Visible { get; set; }

    public short? Division { get; set; }
}
