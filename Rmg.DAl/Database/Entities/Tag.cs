using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Tag
{
    public int Id { get; set; }

    public string Tag1 { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int UseCount { get; set; }

    public short? Division { get; set; }
}
