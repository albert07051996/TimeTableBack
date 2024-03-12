using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ddtable
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public int? TermId { get; set; }

    public string? Abbr { get; set; }

    public string? Description { get; set; }

    public string? ReportOptions { get; set; }

    public string? Uid { get; set; }

    public int Flags { get; set; }

    public int GroupId { get; set; }

    public int UserLevel { get; set; }

    public string? SecurityLevelField { get; set; }

    public string? Suffix { get; set; }

    public int? SuffixId { get; set; }
}
