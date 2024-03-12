using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Prmember
{
    public Guid Idmember { get; set; }

    public string ProjectNr { get; set; } = null!;

    public int? ResId { get; set; }

    public Guid? CmpWwn { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? UntilDate { get; set; }

    public byte IsProjectManager { get; set; }

    public short? Division { get; set; }
}
