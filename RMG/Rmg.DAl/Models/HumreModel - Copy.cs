using System;
using System.Collections;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class MyModel
{
    public int? Id { get; set; }
  
    public string? Fullname { get; set; }
   
    public List <AbsenceModel2> AbsenceModel { get; set; }


}

public partial class AbsenceModel2
{
    public Guid? Id { get; set; }  

    public int? Type { get; set; }

    public int? EmpId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }


}