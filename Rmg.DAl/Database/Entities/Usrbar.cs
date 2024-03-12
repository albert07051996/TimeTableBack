using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Usrbar
{
    public int ResId { get; set; }

    public int MnuId { get; set; }

    public string? Type { get; set; }

    public short? Division { get; set; }
}
