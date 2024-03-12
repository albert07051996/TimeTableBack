using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BinaryIncomingMessages2
{
    public Guid MessageId { get; set; }

    public int Id { get; set; }

    public bool Transferred { get; set; }

    public DateTime CreatedDate { get; set; }
}
