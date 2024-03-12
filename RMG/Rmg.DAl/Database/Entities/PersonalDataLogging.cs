using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PersonalDataLogging
{
    public Guid Id { get; set; }

    public int BatchId { get; set; }

    public int ActionType { get; set; }

    public int ClassificationId { get; set; }

    public string? Category { get; set; }

    public Guid PersonGuid { get; set; }

    public int PersonId { get; set; }

    public string? AccountCode { get; set; }

    public byte Processed { get; set; }

    public string? LogText { get; set; }

    public DateTime DateStarted { get; set; }

    public DateTime DateProcessed { get; set; }

    public int ProcessedBy { get; set; }
}
