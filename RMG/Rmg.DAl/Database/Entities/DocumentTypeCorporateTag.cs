using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DocumentTypeCorporateTag
{
    public int Id { get; set; }

    public int TypeId { get; set; }

    public string Tag { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public short? Division { get; set; }
}
