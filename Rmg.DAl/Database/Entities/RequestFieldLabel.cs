using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestFieldLabel
{
    public int Id { get; set; }

    public int RequestType { get; set; }

    public Guid? FieldIdguid { get; set; }

    public int FieldId { get; set; }

    public int TermId { get; set; }

    public string? Xmlvalue { get; set; }
}
