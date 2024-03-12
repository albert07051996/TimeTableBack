using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WordSynonym
{
    public int Id { get; set; }

    public int Word { get; set; }

    public Guid SynonymGroup { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }
}
