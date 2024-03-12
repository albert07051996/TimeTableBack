using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class XmltopicHistory
{
    public Guid Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public byte[]? TsD { get; set; }

    public byte[]? TsU { get; set; }

    public short? Division { get; set; }
}
