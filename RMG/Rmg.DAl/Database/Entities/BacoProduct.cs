using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoProduct
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? DescriptionTermId { get; set; }

    public string? Prefix { get; set; }

    public int? Color { get; set; }

    public string? DocDefault { get; set; }

    public string? DocSearch { get; set; }

    public string? DocNews { get; set; }

    public string? DocReports { get; set; }

    public string? DocMaintenance { get; set; }

    public string? DocOrganization { get; set; }

    public short? Division { get; set; }

    public virtual ICollection<ReportCategory> ReportCategories { get; set; } = new List<ReportCategory>();
}
