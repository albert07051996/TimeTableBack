using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionFixedGroup
{
    public Guid Id { get; set; }

    public string Description { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public byte SystemType { get; set; }
}
