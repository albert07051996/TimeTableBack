using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TaxSchedule
{
    public int Id { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }

    public string? Postcode { get; set; }

    public int? TaxItemClassification { get; set; }

    public string? Type { get; set; }

    public string? TaxCode1 { get; set; }

    public string? TaxCode2 { get; set; }

    public string? TaxCode3 { get; set; }

    public string? TaxCode4 { get; set; }

    public string? TaxCode5 { get; set; }

    public Guid? Account { get; set; }

    public string? ItemCode { get; set; }

    public double? TaxPerUnit1 { get; set; }

    public double? TaxPerUnit2 { get; set; }

    public double? TaxPerUnit3 { get; set; }

    public double? TaxPerUnit4 { get; set; }

    public double? TaxPerUnit5 { get; set; }

    public short? Division { get; set; }

    public string? CompanyCode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
