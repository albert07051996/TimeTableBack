using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankStatementHeadersExView
{
    public int? StatusMark { get; set; }

    public string? Status { get; set; }

    public DateTime? StatementDate { get; set; }

    public string? BankName { get; set; }

    public string? OwnBankAccount { get; set; }

    public string? StatementNumber { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string BankAccountType { get; set; } = null!;

    public int Id { get; set; }
}
