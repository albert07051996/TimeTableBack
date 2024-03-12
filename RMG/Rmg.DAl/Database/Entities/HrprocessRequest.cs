using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrprocessRequest
{
    public int Id { get; set; }

    public int SequenceNumber { get; set; }

    public string? ProcessDescription { get; set; }

    public int? RequestType { get; set; }

    public int? EmpId { get; set; }

    public string? Description { get; set; }

    public int? UseRequest { get; set; }

    public int? PreviousRequest { get; set; }

    public int? Status { get; set; }

    public int? UseDate { get; set; }

    public double Days { get; set; }

    public double DurationInDays { get; set; }

    public int Frequency { get; set; }

    public int NumberFrequency { get; set; }

    public int Maximum { get; set; }

    public bool Overdue { get; set; }

    public Guid? Freefield1 { get; set; }

    public Guid? Freefield2 { get; set; }

    public string? FreeTextField1 { get; set; }

    public string? FreeTextField2 { get; set; }

    public bool? FreeBoolField1 { get; set; }

    public bool? FreeBoolField2 { get; set; }

    public double? FreeNumberField1 { get; set; }

    public double? FreeNumberField2 { get; set; }

    public int? FreeIntField1 { get; set; }

    public int? FreeIntField2 { get; set; }

    public int ProcessTypesId { get; set; }

    public bool Active { get; set; }

    public bool Blocked { get; set; }

    public short? Division { get; set; }

    public string? Remark { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
