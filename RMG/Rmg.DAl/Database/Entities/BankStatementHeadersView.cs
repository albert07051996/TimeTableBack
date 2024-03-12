using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankStatementHeadersView
{
    public string? OwnBankAccount { get; set; }

    public string BankAccountIncludingMask { get; set; } = null!;

    public string? Tccode { get; set; }

    public string? StatementNumber { get; set; }

    public DateTime? StatementDate { get; set; }

    public string? CompanyCode { get; set; }

    public string? BankName { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string BankAccountType { get; set; } = null!;

    public int Id { get; set; }
}
