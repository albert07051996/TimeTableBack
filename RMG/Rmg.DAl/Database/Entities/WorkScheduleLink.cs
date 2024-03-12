using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WorkScheduleLink
{
    public Guid Id { get; set; }

    public int Resource { get; set; }

    public Guid ShiftId { get; set; }

    public byte SequenceNumber { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int DayStart { get; set; }

    public string? Status { get; set; }

    public string? GroupCode { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
