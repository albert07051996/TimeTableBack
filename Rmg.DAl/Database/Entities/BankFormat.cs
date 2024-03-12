using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankFormat
{
    public int Id { get; set; }

    public string FormatType { get; set; } = null!;

    public string LandIsonr { get; set; } = null!;

    public string FormatName { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string? FormatFileName { get; set; }

    public string? FormatSystem { get; set; }

    public byte OneCurrencyPerBatch { get; set; }

    public byte OneOffsetPerBatch { get; set; }

    public byte OneAccountPerBatch { get; set; }

    public byte OneDatePerBatch { get; set; }

    public string? MatchingCriteria1 { get; set; }

    public string? MatchingCriteria2 { get; set; }

    public string ProgId { get; set; } = null!;

    public string? Mask { get; set; }

    public int? DataModuleId { get; set; }

    public string? Description { get; set; }

    public int TotalPackageCount { get; set; }

    public int DatePackageCount { get; set; }

    public DateTime? LastPackageDate { get; set; }

    public byte OneBatchDatePerFile { get; set; }

    public byte EurbatchesInSeparateFile { get; set; }

    public byte MultiCurrency { get; set; }

    public string? ExtraMatchingDelimiter { get; set; }

    public string? ExtraMatchingCriteria1 { get; set; }

    public string? ExtraMatchingCriteria2 { get; set; }

    public string? ExtraMatchingCriteria3 { get; set; }

    public string? Assembly { get; set; }

    public string? AssemblyClass { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
