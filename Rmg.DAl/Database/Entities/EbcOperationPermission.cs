using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcOperationPermission
{
    public Guid OperationId { get; set; }

    public Guid CompId { get; set; }

    public int OperationTypeId { get; set; }

    public string Context { get; set; } = null!;

    public int? FunctionPoint { get; set; }

    public int Level { get; set; }
}
