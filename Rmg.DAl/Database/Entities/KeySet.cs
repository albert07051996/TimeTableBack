using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class KeySet
{
    public int Id { get; set; }

    public Guid InitializationVector { get; set; }

    public Guid EncryptionKey { get; set; }
}
