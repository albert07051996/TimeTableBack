using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ExactLicense
{
    public string CustomerId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte[] Type { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int SequenceNumber { get; set; }

    public byte[] IssueDate { get; set; } = null!;

    public DateTime ActivationDate { get; set; }

    public byte[] ExpirationDate { get; set; } = null!;

    public byte[]? ExpirationDate2 { get; set; }

    public byte[] Checksum { get; set; } = null!;

    public byte[] Certificate { get; set; } = null!;

    public short? Division { get; set; }

    public short? Version { get; set; }
}
