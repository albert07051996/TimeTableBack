﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoAppLogDay
{
    public DateTime Day { get; set; }

    public int PageViews { get; set; }

    public int PageViewsEmployees { get; set; }

    public int PageViewsResellers { get; set; }

    public int PageViewsCustomers { get; set; }

    public int PageViewsPublic { get; set; }

    public int Resources { get; set; }

    public int Resellers { get; set; }

    public int Customers { get; set; }

    public short? Division { get; set; }

    public int? AverageApplicationDuration { get; set; }
}
