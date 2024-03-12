using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Dehrpayrollcontract
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public short Contract { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Country { get; set; }

    public int ResId { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Description { get; set; }

    public string? JobTitle { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public string? Vertragsart { get; set; }

    public byte LohnEintritt { get; set; }

    public byte AustrittDurchTod { get; set; }

    public string? Arbeitnehmergruppe { get; set; }

    public string? Personengruppe { get; set; }

    public int? Taetigkeitsschluessel { get; set; }

    public string? AuslandArt { get; set; }

    public string? Leistungsgruppe { get; set; }

    public string? Beschaeftigungsart { get; set; }

    public DateTime? GekuendigtAm { get; set; }

    public DateTime? GekuendigtZum { get; set; }

    public DateTime? BefristetBis { get; set; }

    public string? Befristungsgrund { get; set; }

    public string? Kuendigungsgrund { get; set; }

    public string? KuendigungDurch { get; set; }

    public DateTime? AusbildungsPruefungstermin { get; set; }

    public string? Ausbildungsziel { get; set; }

    public string? Ausbildungsart { get; set; }

    public byte AusbildungBestanden { get; set; }

    public byte AusbildungVerkuerzt { get; set; }

    public double AusbildungsWochenstunden { get; set; }

    public double AusbildungsMonatsentgelt { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
