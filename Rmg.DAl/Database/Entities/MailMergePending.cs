using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class MailMergePending
{
    public Guid Id { get; set; }

    public int Hid { get; set; }

    public string ReportType { get; set; } = null!;

    public string? Subject { get; set; }

    public string? AttachmentName { get; set; }

    public string? Sqlquery { get; set; }

    public Guid? ReportLayout { get; set; }

    public int Status { get; set; }

    public DateTime? DateProcessed { get; set; }

    public Guid? LogId { get; set; }

    public string? SenderMail { get; set; }

    public string? Email { get; set; }

    public string? ReportName { get; set; }

    public string? AddressType { get; set; }

    public DateTime? ReferenceDate { get; set; }

    public string? Parameters { get; set; }

    public DateTime? DateStarted { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
