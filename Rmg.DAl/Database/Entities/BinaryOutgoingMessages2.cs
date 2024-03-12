using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BinaryOutgoingMessages2
{
    public Guid MessageId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int Id { get; set; }
}
