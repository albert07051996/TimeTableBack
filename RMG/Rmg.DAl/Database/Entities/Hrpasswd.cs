using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrpasswd
{
    public Guid Id { get; set; }

    public int? Type { get; set; }

    public string? Word { get; set; }

    public short? Division { get; set; }
}
