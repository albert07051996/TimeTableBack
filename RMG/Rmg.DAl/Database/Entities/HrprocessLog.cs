using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HrprocessLog
{
    public Guid Id { get; set; }

    public int ProcessRequestsId { get; set; }

    public DateTime ReferenceDate { get; set; }

    public Guid RequestId { get; set; }

    public Guid? OriginalRequest { get; set; }

    public int? HreffectiveDateDataLogId { get; set; }

    public int EmpId { get; set; }

    public string? FieldName { get; set; }

    public int RunNumber { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
