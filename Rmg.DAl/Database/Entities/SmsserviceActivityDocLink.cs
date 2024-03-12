using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsserviceActivityDocLink
{
    public Guid Id { get; set; }

    public Guid ServiceActivityId { get; set; }

    public Guid DocumentId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
