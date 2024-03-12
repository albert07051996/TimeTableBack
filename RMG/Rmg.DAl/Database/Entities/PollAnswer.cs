using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PollAnswer
{
    public Guid Id { get; set; }

    public Guid PollId { get; set; }

    public int Sequence { get; set; }

    public string Answer { get; set; } = null!;

    public int Syscreator { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Syscreated { get; set; }

    public DateTime Sysmodified { get; set; }
}
