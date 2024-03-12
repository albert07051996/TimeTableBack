using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SsrsdrillthroughParameter
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid DrillthroughId { get; set; }

    public virtual Ssrsdrillthrough Drillthrough { get; set; } = null!;
}
