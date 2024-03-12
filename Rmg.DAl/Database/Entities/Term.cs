using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Term
{
    public int Id { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? Description { get; set; }

    public short? Division { get; set; }
}
