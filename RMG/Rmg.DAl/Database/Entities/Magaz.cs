using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Magaz
{
    public int Id { get; set; }

    public string? Magcode { get; set; }

    public string? Naam { get; set; }

    public byte Blokkeer { get; set; }

    public string? LandIso { get; set; }

    public string? IntRegio { get; set; }

    public string? LocIntake { get; set; }

    public string? LocIssue { get; set; }

    public string? AdrAddressLine1 { get; set; }

    public string? AdrAddressLine2 { get; set; }

    public string? AdrAddressLine3 { get; set; }

    public string? AdrPostCode { get; set; }

    public string? AdrCity { get; set; }

    public string? AdrStateCode { get; set; }

    public string? AdrLandcode { get; set; }

    public string? AdrPhone { get; set; }

    public string? AdrFax { get; set; }

    public int AdrCntpResid { get; set; }

    public string? CompanyCode { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
