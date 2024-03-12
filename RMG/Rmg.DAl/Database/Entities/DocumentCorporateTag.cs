using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DocumentCorporateTag
{
    public int Id { get; set; }

    public int TagId { get; set; }

    public Guid DocumentId { get; set; }

    public string Tag { get; set; } = null!;

    public int CreatedBy { get; set; }

    public string? DocVersion { get; set; }

    public DateTime CreatedDate { get; set; }

    public short? Division { get; set; }
}
