using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PortalUsage
{
    public Guid Id { get; set; }

    public Guid? Portal { get; set; }

    public string? NewsLayout { get; set; }

    public string? DivisionGroup { get; set; }

    public string? Division { get; set; }

    public short? DivisionX { get; set; }

    public string? CostcenterGroup { get; set; }

    public string? Costcenter { get; set; }

    public string? Classification { get; set; }

    public string? Sector { get; set; }

    public int? Role { get; set; }

    public string? JobGroup { get; set; }

    public string? JobActivity { get; set; }

    public string? Language { get; set; }

    public DateTime Syscreated { get; set; }

    public int? Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int? Sysmodifier { get; set; }
}
