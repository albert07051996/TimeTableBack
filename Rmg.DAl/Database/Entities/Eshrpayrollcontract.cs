using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Eshrpayrollcontract
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public short Contract { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Description { get; set; }

    public string? JobTitle { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public int ResId { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Country { get; set; }

    public string? ConActividad { get; set; }

    public string? ConConvenio { get; set; }

    public string? ConGroup { get; set; }

    public string? ConFunction { get; set; }

    public string? SocContract { get; set; }

    public string? SocEducation { get; set; }

    public byte SocSocialYn { get; set; }

    public string? SocGroupEpi { get; set; }

    public string? SocGroupEpiCalc { get; set; }

    public string? ContrContracto { get; set; }

    public DateTime? ContrDate { get; set; }

    public string? AfiAccion { get; set; }

    public string? AfiDesempl { get; set; }

    public string? AfiSituation { get; set; }

    public DateTime? AfiDate { get; set; }

    public byte AfiMakeYn { get; set; }

    public byte AfiWomanNy { get; set; }

    public byte AfiWarningYn { get; set; }

    public byte FanMoreJob { get; set; }

    public string? FanKindSalary { get; set; }

    public short? AfiAutorizacion { get; set; }

    public DateTime? AfiVigencia { get; set; }

    public string? AfiMaternity { get; set; }

    public DateTime? FecAntiguedad { get; set; }

    public byte AfiIncapReadm { get; set; }

    public byte AfiExcluSocial { get; set; }

    public byte AfiRar { get; set; }

    public byte SocConsejAdmin { get; set; }

    public short? AfiGradoMinusv { get; set; }

    public double AfiFte { get; set; }

    public byte SocFixday { get; set; }

    public DateTime? SocContractStartDate { get; set; }

    public DateTime? SocContractEndDate { get; set; }

    public byte SocOlder60 { get; set; }

    public byte SocOlder65 { get; set; }

    public DateTime? SocOlder60Date { get; set; }

    public DateTime? SocOlder65Date { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
