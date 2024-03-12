using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DocumentReference
{
    public Guid Document { get; set; }

    public int EntityType { get; set; }

    public Guid Entity { get; set; }
}
