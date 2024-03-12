using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsconfigurationChildrenView
{
    public Guid? Id { get; set; }

    public Guid? Parent { get; set; }

    public Guid? Item { get; set; }

    public Guid? SerialNumber { get; set; }

    public Guid? MainParentId { get; set; }
}
