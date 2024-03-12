using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class RequestField
{
    public int Id { get; set; }

    public bool UseField { get; set; }

    public int Position { get; set; }

    public int Columns { get; set; }

    public bool Front { get; set; }

    public string Name { get; set; } = null!;

    public int TermId { get; set; }

    public string? NameSuffix { get; set; }

    public int? TermIdsuffix { get; set; }

    public string Property { get; set; } = null!;

    public bool VisibleNew { get; set; }

    public bool VisibleOpen { get; set; }

    public bool VisibleApproved { get; set; }

    public bool VisibleRealized { get; set; }

    public bool VisibleProcessed { get; set; }

    public bool EditOpen { get; set; }

    public bool EditApproved { get; set; }

    public bool EditRealized { get; set; }

    public bool EditProcessed { get; set; }

    public bool MandatoryOpen { get; set; }

    public bool MandatoryApproved { get; set; }

    public bool MandatoryRealized { get; set; }

    public bool MandatoryProcessed { get; set; }

    public string? DefaultString { get; set; }

    public int? DefaultInt { get; set; }

    public DateTime? DefaultDate { get; set; }

    public double? DefaultDouble { get; set; }

    public short DefaultOption { get; set; }

    public short? Division { get; set; }
}
