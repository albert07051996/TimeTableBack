using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Smspmlset
{
    public Guid Id { get; set; }

    public Guid? Pmtype { get; set; }

    public Guid? Pmschedule { get; set; }

    public Guid? Lineset { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
