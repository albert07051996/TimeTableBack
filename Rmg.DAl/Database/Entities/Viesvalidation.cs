using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Viesvalidation
{
    public Guid Id { get; set; }

    public int Hid { get; set; }

    public string? Viesinput { get; set; }

    public int Status { get; set; }

    public DateTime? DateStarted { get; set; }

    public DateTime? DateProcessed { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
