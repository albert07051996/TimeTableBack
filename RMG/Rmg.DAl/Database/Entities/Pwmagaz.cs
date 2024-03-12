using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Pwmagaz
{
    public int Id { get; set; }

    public int ResId { get; set; }

    public string? Magcode { get; set; }

    public short? Division { get; set; }
}
