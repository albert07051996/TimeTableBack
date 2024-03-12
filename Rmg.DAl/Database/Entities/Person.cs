using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Person
{
    public Guid Id { get; set; }

    public string? Affix { get; set; }

    public string Title { get; set; } = null!;

    public string? Initials { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public string Gender { get; set; } = null!;

    public string? Language { get; set; }

    public string? Nationality { get; set; }

    public byte[]? Picture { get; set; }

    public string? PictureFileName { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? BirthAffix { get; set; }

    public string? BirthMiddleName { get; set; }

    public string? BirthLastName { get; set; }

    public string? BirthSuffix { get; set; }

    public string? BirthCity { get; set; }

    public string? BirthCountry { get; set; }

    public string? SocialSecurityNumber { get; set; }

    public string? LinkedIn { get; set; }

    public string? Twitter { get; set; }

    public string? Skype { get; set; }

    public string? Msn { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
