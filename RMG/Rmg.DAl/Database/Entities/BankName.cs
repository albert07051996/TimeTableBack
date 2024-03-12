using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankName
{
    public int Id { get; set; }

    public string LandIsonr { get; set; } = null!;

    public string BankName1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? HomePageAddress { get; set; }

    public string? InternetBankingAddress { get; set; }

    public string? BankAccountCheck { get; set; }

    public string? BankAccountMaskPrefix { get; set; }

    public string? BankAccountMask { get; set; }

    public string? Swiftcode { get; set; }

    public string? Biccode { get; set; }

    public string? ProgId { get; set; }

    public string? Status { get; set; }

    public string? MainLogoFileName { get; set; }

    public string? Assembly { get; set; }

    public string? AssemblyClass { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
