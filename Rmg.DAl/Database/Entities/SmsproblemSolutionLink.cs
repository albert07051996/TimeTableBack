using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsproblemSolutionLink
{
    public Guid Id { get; set; }

    public Guid Problem { get; set; }

    public Guid Solution { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
