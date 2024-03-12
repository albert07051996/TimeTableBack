using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcOperationType
{
    public int OperationTypeId { get; set; }

    public string Description { get; set; } = null!;
}
