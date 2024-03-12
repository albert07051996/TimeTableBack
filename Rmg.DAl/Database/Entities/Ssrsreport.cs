using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ssrsreport
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid IdreportGroup { get; set; }

    public Guid? IdparentReport { get; set; }

    public string? Description { get; set; }

    public byte[]? Rdlcontent { get; set; }

    public string? RdlfileName { get; set; }

    public string Path { get; set; } = null!;

    public int? ParametersPerRow { get; set; }

    public bool? Customer { get; set; }

    public bool? Reseller { get; set; }

    public Guid? PolicyDocumentId { get; set; }

    public bool? WebPart { get; set; }

    public bool Hidden { get; set; }

    public bool Deployed { get; set; }

    public bool InheritRolesFromGroup { get; set; }

    public string? LanguageCode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int NameTermId { get; set; }

    public long NumberOfViews { get; set; }

    public bool AllowWord { get; set; }

    public bool AllowExcel { get; set; }

    public bool AllowPdf { get; set; }

    public bool AllowPrint { get; set; }

    public virtual Ssrsreport? IdparentReportNavigation { get; set; }

    public virtual SsrsreportGroup IdreportGroupNavigation { get; set; } = null!;

    public virtual ICollection<Ssrsreport> InverseIdparentReportNavigation { get; set; } = new List<Ssrsreport>();

    public virtual ICollection<SsrsreportParameter> SsrsreportParameters { get; set; } = new List<SsrsreportParameter>();
}
