using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmactivityCompetenceLink
{
    public Guid Id { get; set; }

    public string JobActivity { get; set; } = null!;

    public Guid CompetenceGroup { get; set; }

    public Guid Competence { get; set; }

    public int JobLevel { get; set; }

    public bool Active { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
