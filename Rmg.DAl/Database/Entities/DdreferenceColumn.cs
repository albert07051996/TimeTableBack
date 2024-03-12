using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DdreferenceColumn
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string ReferenceName { get; set; } = null!;

    public int SeqNr { get; set; }
}
