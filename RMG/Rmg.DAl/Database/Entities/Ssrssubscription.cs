using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ssrssubscription
{
    public Guid Id { get; set; }

    public Guid? ScheduleId { get; set; }

    public string ReportPath { get; set; } = null!;

    public string? ParameterValues { get; set; }

    public string? Description { get; set; }

    public string ExtensionSettings { get; set; } = null!;

    public Guid? SsrssubscriptionId { get; set; }

    public bool Deployed { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }
}
