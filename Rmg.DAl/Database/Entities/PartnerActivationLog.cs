using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PartnerActivationLog
{
    public Guid ActlogId { get; set; }

    public int ActlogCode { get; set; }

    public Guid ActrequestId { get; set; }

    public int NextLogId { get; set; }

    public Guid NextActivationId { get; set; }

    public int? AppliedLogId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
