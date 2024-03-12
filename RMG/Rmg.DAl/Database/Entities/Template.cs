using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Template
{
    public Guid Id { get; set; }

    public bool SystemType { get; set; }

    public int? Resource { get; set; }

    public string Topic { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DescriptionTermId { get; set; }

    public string? Xmlvalue { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }
}
