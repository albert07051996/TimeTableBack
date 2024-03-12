using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmscreatedDocument
{
    public Guid Id { get; set; }

    public Guid Batch { get; set; }

    public string? DocumentList { get; set; }

    public string? Message { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }
}
