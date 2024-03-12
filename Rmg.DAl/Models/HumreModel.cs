using System;
using System.Collections;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class HumreModel
{
    public int? Id { get; set; }
    public int? ResId { get; set; }
    public string? Fullname { get; set; }
    public string? UsrId { get; set; } 
    public int? ReptoId { get; set; }
    public string? EmpStat { get; set; }
    public List <AbsenceModel> AbsenceModel { get; set; }


}

public partial class AbsenceModel
{
    public Guid? Id { get; set; }  

    public int? Type { get; set; }

    public int? EmpId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }


}

public partial class UsersforResponse
{
    public Guid? Id { get; set; }
    public string? Fullname { get; set; }

    public int? Type { get; set; }

    public int? EmpId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? Day8 { get; set; }
    public string? Day9 { get; set; }
    public string? Day10 { get; set; }

    public string? Day11 { get; set; }
    public string? Day12 { get; set; }
    public string? Day13 { get; set; }
    public string? Day14 { get; set; }
    public string? Day15 { get; set; }
    public string? Day16 { get; set; }
    public string? Day17 { get; set; }
    public string? Day18 { get; set; }
    public string? Day19 { get; set; }
    public string? Day20 { get; set; }
    public string? Day21 { get; set; }
    public string? Day22 { get; set; }
    public string? Day23 { get; set; }
    public string? Day24 { get; set; }
    public string? Day25 { get; set; }
    public string? Day26 { get; set; }
    public string? Day27 { get; set; }
    public string? Day28 { get; set; }
    public string? Day29 { get; set; }
    public string? Day30 { get; set; }
    public string? Day31 { get; set; }
    public string? Day1hour { get; set; }
    public string? Day2hour { get; set; }
    public string? Day3hour { get; set; }
    public string? Day4hour { get; set; }
    public string? Day5hour { get; set; }
    public string? Day6hour { get; set; }
    public string? Day7hour { get; set; }
    public string? Day8hour { get; set; }
    public string? Day9hour { get; set; }
    public string? Day10hour { get; set; }
    public string? Day11hour { get; set; }
    public string? Day12hour { get; set; }
    public string? Day13hour { get; set; }
    public string? Day14hour { get; set; }
    public string? Day15hour { get; set; }
    public string? Day16hour { get; set; }
    public string? Day17hour { get; set; }
    public string? Day18hour { get; set; }
    public string? Day19hour { get; set; }
    public string? Day20hour { get; set; }
    public string? Day21hour { get; set; }
    public string? Day22hour { get; set; }
    public string? Day23hour { get; set; }
    public string? Day24hour { get; set; }
    public string? Day25hour { get; set; }
    public string? Day26hour { get; set; }
    public string? Day27hour { get; set; }
    public string? Day28hour { get; set; }
    public string? Day29hour { get; set; }
    public string? Day30hour { get; set; }
    public string? Day31hour { get; set; }
    public double? FullWorkHours { get; set; }
    public double? FullSickHours { get; set; }
    public double? FullVacationHours { get; set; }
    public double? FullUnpaidVacationHours { get; set; }
    public double? FullWeekendDay { get; set; }
    public int? FullWorKDays { get; set; }
    public int? FullVacationDays { get; set; }
    public int? FullIllDay { get; set; }
    public int? FullUnpaidVacationDay { get; set; }



}