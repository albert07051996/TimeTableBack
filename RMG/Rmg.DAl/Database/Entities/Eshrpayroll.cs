using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Eshrpayroll
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

    public double TaxPercEmpl { get; set; }

    public double TaxBonusAmt { get; set; }

    public double TaxReducIrrEmpl { get; set; }

    public byte TaxMoveJobNy { get; set; }

    public double TaxAssAmt { get; set; }

    public double TaxAliPensionAmt { get; set; }

    public double TaxAliAmt { get; set; }

    public string? TaxFamilySit { get; set; }

    public string? TaxNifPart { get; set; }

    public string? TaxDisabled { get; set; }

    public string? TaxSplitChild { get; set; }

    public string? Sliptext1 { get; set; }

    public string? Sliptext2 { get; set; }

    public string? Sliptext3 { get; set; }

    public string? TaxException { get; set; }

    public byte Tax190TrabExtNy { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
