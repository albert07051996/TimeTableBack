using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrmpersonalObjectiveHeader
{
    public Guid Id { get; set; }

    public Guid ProfileId { get; set; }

    public Guid CompetenceId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
