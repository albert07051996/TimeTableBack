using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfruleDeployment
{
    public Guid Id { get; set; }

    public int? RuleId { get; set; }

    public int Type { get; set; }

    public int RequestType { get; set; }

    public int? Status { get; set; }

    public string Description { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public int Priority { get; set; }

    public bool? StopIfTrue { get; set; }

    public string? RuleSql { get; set; }

    public string? ResourceSelection { get; set; }

    public string? Message { get; set; }

    public string? Remarks { get; set; }

    public byte Active { get; set; }

    public string? RemarkSql { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
