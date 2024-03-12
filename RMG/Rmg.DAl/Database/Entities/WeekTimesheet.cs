using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WeekTimesheet
{
    public Guid Id { get; set; }

    public Guid TimesheetRequestId { get; set; }

    public Guid? RequestId { get; set; }

    public byte Status { get; set; }

    public int Approver { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
