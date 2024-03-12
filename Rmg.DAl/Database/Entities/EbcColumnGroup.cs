using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcColumnGroup
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string? Description { get; set; }

    public int? TermId { get; set; }

    public string? Suffix { get; set; }

    public int? SuffixId { get; set; }
}
