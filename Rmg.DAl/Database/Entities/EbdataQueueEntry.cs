using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbdataQueueEntry
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int DataType { get; set; }

    public DateTime DateImported { get; set; }

    public string OriginalName { get; set; } = null!;

    public DateTime? OriginalDate { get; set; }

    public byte[] Data { get; set; } = null!;

    public byte[] Timestamp { get; set; } = null!;

    public int BankFormatId { get; set; }

    public int? HumanResourceId { get; set; }

    public string? Bedrnr { get; set; }

    public int QtyTransactions { get; set; }

    public int QtyStatements { get; set; }

    public double TotalAmountDc { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
