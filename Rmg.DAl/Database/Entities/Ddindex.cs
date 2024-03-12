using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ddindex
{
    public int Id { get; set; }

    public string IndexName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public int Type { get; set; }

    public int SeqNr { get; set; }

    public int GroupId { get; set; }
}
