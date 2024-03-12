using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestNotification
{
    public int Id { get; set; }

    public Guid RequestId { get; set; }

    public int ResourceId { get; set; }

    public DateTime Created { get; set; }
}
