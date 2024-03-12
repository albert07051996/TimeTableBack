using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrcompetency
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public short? Division { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
