using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Portal
{
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public int Type { get; set; }

    public int Priority { get; set; }

    public int? Manager { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Domain { get; set; }

    public string? Keywords { get; set; }

    public string? Language { get; set; }

    public string? Title { get; set; }

    public string? StyleSheet { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int? Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int? Sysmodifier { get; set; }
}
