using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SsrsparameterSource
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Idcaption { get; set; }
}
