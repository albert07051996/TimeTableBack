using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Dehrpayroll
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public short Contract { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Country { get; set; }

    public string? Description { get; set; }

    public int ResId { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? LohnartSoll { get; set; }

    public string? Pauschalsteuersatz { get; set; }

    public DateTime? Einstufungsdatum { get; set; }

    public DateTime? VersorgungBeginn { get; set; }

    public double KinderfreibetragKug { get; set; }

    public double VersorgungBemessungLfd { get; set; }

    public double VersorgungBemessungEga { get; set; }

    public double Sollentgelt { get; set; }

    public double Kinderfreibetraege { get; set; }

    public double GrundlohnSfn { get; set; }

    public double UeberstdProzent { get; set; }

    public double FreibetragMonth { get; set; }

    public double FreibetragYear { get; set; }

    public double KrankenversPrivat { get; set; }

    public double PflegeversPrivat { get; set; }

    public double ZuverdienstgrenzeRente { get; set; }

    public double JahreseinkommenAbweich { get; set; }

    public byte Lohnsteuerjahresausgleich { get; set; }

    public byte Lohnsteuerbescheinigung { get; set; }

    public byte KinderPv { get; set; }

    public short? Steuerklasse { get; set; }

    public short? SteuerklasseKug { get; set; }

    public short? PauschaleKirchensteuer { get; set; }

    public short? Beitragsgruppe { get; set; }

    public short? UebernahmeSvAg { get; set; }

    public string? Bundesland { get; set; }

    public string? Lohnsteuertabelle { get; set; }

    public string? ArbeitskammerLand { get; set; }

    public string? KrankenversFreiw { get; set; }

    public string? PflegeversFreiw { get; set; }

    public string? Rentenbezug { get; set; }

    public string? MehrfachBeschaeftigt { get; set; }

    public string? BeitragsgrenzeAbweichung { get; set; }

    public string? Arbeitnehmergruppe { get; set; }

    public string? SvKennzeichen { get; set; }

    public string? SollentgeldArt { get; set; }

    public string? GrundlohnSfnFormel { get; set; }

    public string? SvUnterbrechung { get; set; }

    public string? Deuevstatus { get; set; }

    public string? Konfession { get; set; }

    public string? KonfessionEhegatte { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] TimeStamp { get; set; } = null!;
}
