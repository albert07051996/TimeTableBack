using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PollVote
{
    public Guid Id { get; set; }

    public Guid PollId { get; set; }

    public Guid AnswerId { get; set; }

    public int ResourceId { get; set; }

    public int Syscreator { get; set; }

    public int Sysmodifier { get; set; }

    public DateTime Syscreated { get; set; }

    public DateTime Sysmodified { get; set; }
}
