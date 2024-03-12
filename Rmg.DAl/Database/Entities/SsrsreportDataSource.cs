using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SsrsreportDataSource
{
    public Guid Id { get; set; }

    public Guid DataSourceId { get; set; }

    public string Name { get; set; } = null!;

    public Guid ReportId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
