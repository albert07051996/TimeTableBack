using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsjobHeader
{
    public Guid Id { get; set; }

    public Guid? Absence { get; set; }

    public Guid? ServiceItem { get; set; }

    public Guid? ServiceSerialNumber { get; set; }

    public Guid? Contract { get; set; }

    public Guid? PmcontractOrigin { get; set; }

    public Guid? PmscheduleOrigin { get; set; }

    public Guid? PmtypeOrigin { get; set; }

    public Guid? Pmbatch { get; set; }

    public bool? Preventive { get; set; }

    public Guid? PartItem { get; set; }

    public Guid? PartSerialNumber { get; set; }

    public Guid? RootConfiguration { get; set; }

    public Guid? PartConfiguration { get; set; }

    public Guid? Problem { get; set; }

    public Guid? Solution { get; set; }

    public string? Notes { get; set; }

    public bool? Done { get; set; }

    public bool? NoContract { get; set; }

    public bool? NoConfigurationPart { get; set; }

    public Guid? ServiceActivity { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
