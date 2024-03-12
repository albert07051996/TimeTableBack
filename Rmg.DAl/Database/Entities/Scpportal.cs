using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Scpportal
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Division { get; set; }

    public string GlobeServer { get; set; } = null!;

    public string GlobeDatabase { get; set; } = null!;

    public string GlobeServiceHostName { get; set; } = null!;

    public int GlobeServiceHostPortNumber { get; set; }

    public string InstallationFolder { get; set; } = null!;

    public string VirtualDirectory { get; set; } = null!;
}
