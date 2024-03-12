using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class XmltopicsDefinition
{
    public string Topic { get; set; } = null!;

    public int TopicOrder { get; set; }

    public int TermId { get; set; }

    public string? Xmlnode { get; set; }

    public int? FunctionId { get; set; }

    public string? Options { get; set; }

    public string? ProgId { get; set; }

    public string? CsvprogId { get; set; }

    public int PageSize { get; set; }

    public bool CanUpload { get; set; }

    public bool CanDownload { get; set; }

    public bool GlobeImport { get; set; }

    public bool GlobeExport { get; set; }

    public string? SelectionAsp { get; set; }

    public string? SelectionSlc { get; set; }

    public int Mode { get; set; }

    public int Scenario { get; set; }

    public int SecurityLevel { get; set; }

    public short? Division { get; set; }
}
