using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BinaryOutgoingMessage
{
    public Guid MessageId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int Id { get; set; }
}
