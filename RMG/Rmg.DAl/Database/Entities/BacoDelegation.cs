using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDelegation
{
    public int DelegatedFrom { get; set; }

    public int DelegatedTo { get; set; }

    public bool Enabled { get; set; }

    public short? Division { get; set; }
}
