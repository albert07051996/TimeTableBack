using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class LastAction
{
    public Guid CustomerId { get; set; }

    public Guid? ContactId { get; set; }

    public short? Division { get; set; }

    public DateTime Created { get; set; }
}
