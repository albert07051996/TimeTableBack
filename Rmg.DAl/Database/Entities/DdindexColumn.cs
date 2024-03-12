using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DdindexColumn
{
    public int Id { get; set; }

    public string Tablename { get; set; } = null!;

    public string IndexName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public int SeqNr { get; set; }
}
