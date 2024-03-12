using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoAppLogHour
{
    public DateTime Day { get; set; }

    public int Hour { get; set; }

    public int PageViews { get; set; }

    public int PageViewsEmployees { get; set; }

    public int PageViewsResellers { get; set; }

    public int PageViewsCustomers { get; set; }

    public int PageViewsPublic { get; set; }

    public short? Division { get; set; }
}
