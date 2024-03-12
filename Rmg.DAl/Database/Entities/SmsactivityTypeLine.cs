using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsactivityTypeLine
{
    public Guid Id { get; set; }

    public Guid SmsactivityTypes { get; set; }

    public double? DefaultHourRequired { get; set; }

    public Guid? DefaultHourItem { get; set; }

    public int? Engineer { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
