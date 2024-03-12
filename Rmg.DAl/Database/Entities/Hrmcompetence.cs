using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrmcompetence
{
    public Guid Id { get; set; }

    public Guid? LinkedToId { get; set; }

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public Guid? FieldTypeId { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public string? Notes { get; set; }

    public byte Factor { get; set; }

    public Guid? FieldTypeId2 { get; set; }

    public string Code { get; set; } = null!;

    public short? Division { get; set; }

    public bool PersonalObjectiveHeader { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
