using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ExactLicenseBackup
{
    public string CustomerId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short Type { get; set; }

    public string Number { get; set; } = null!;

    public int SequenceNumber { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime ActivationDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public string? ExpirationDate2 { get; set; }

    public int Checksum { get; set; }

    public byte[] Certificate { get; set; } = null!;

    public short? Division { get; set; }
}
