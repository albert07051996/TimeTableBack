using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AbsenceMainType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int DescriptionTermId { get; set; }

    public string? TypeCaption { get; set; }

    public int TypeCaptionTermId { get; set; }

    public int ViewType { get; set; }

    public int ViewOrder { get; set; }

    public int? ViewColumn1 { get; set; }

    public int? ViewColumn2 { get; set; }

    public int? ViewColumn3 { get; set; }

    public int? ViewColumn4 { get; set; }

    public int? ViewColumn5 { get; set; }

    public int? ViewColumn6 { get; set; }

    public int? ViewColumn7 { get; set; }

    public int? ViewColumn8 { get; set; }

    public int? ViewColumn9 { get; set; }

    public int? ViewColumn10 { get; set; }

    public short? Division { get; set; }

    public bool AbsenceBalance { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
