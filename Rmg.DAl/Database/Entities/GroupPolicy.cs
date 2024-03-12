using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class GroupPolicy
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }

    public int PolicyType { get; set; }

    public string Value { get; set; } = null!;
}
