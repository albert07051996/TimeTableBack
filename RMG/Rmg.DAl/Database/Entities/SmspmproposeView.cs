using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmspmproposeView
{
    public string Status { get; set; } = null!;

    public int? RequestId { get; set; }

    public Guid? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public Guid ContractId { get; set; }

    public string ContractNumber { get; set; } = null!;

    public Guid AddressId { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public Guid Configuration { get; set; }

    public string ConfigurationDescription { get; set; } = null!;

    public int? Engineer { get; set; }

    public string? EngineerName { get; set; }

    public double? Duration { get; set; }

    public Guid ContractAgreement { get; set; }

    public Guid? ContractLink { get; set; }

    public DateTime? AgreementStartDate { get; set; }

    public DateTime? AgreementEndDate { get; set; }

    public string? AgreementDescription { get; set; }

    public DateTime? ActivityStartTime { get; set; }

    public string? ActivityTypeDescription { get; set; }

    public string? StartNextRequest { get; set; }

    public bool? UseTimeInterval { get; set; }

    public double? TimeInterval { get; set; }

    public string? TimeUnit { get; set; }

    public Guid? Pmtype { get; set; }

    public DateTime? GeneratedUntilDate { get; set; }

    public DateTime? OldGeneratedUntilDate { get; set; }

    public string? Division { get; set; }
}
