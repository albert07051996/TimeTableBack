using Microsoft.AspNetCore.Mvc;
using Rmg.DAL.DataBase.Entities;
using Rmg.DAL.Repositories;
using Rmg.DAL.Repositories.Interfaces;
using System.Timers;

namespace Rmg.WEB.Controllers
{

    [Route("api/Rmg")]
    [ApiController]
    public class RmgController : ControllerBase
    {
        private readonly IRmgRepository rmgRepository;
        public RmgController(IRmgRepository rmgRepository
          )
        { this.rmgRepository = rmgRepository; }

        private static System.Timers.Timer aTimer;

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        [HttpGet]
        [Route("user")]
        public async Task<IEnumerable<UsersforResponse>> GetAllSecondAsync([FromQuery] FilterModel filter)
        {
            SetTimer();

            var mydate = filter.date.Value.AddDays(1);
            var result = await rmgRepository.GetUserClaims(filter.usr_id);
            if (result==null)
            {
                return new List<UsersforResponse>();
            }
            var subUser = await rmgRepository.GetsubordinateUsers(result.ResId);
            var workhour = "სთ";
            int year = mydate.Year;
            int month = mydate.Month;
            var weekendDays = "დასვენება";
            var ill = "ს/ფ";
            var UnpaidVacation = "უ/შ";

            string wkd = weekendDays.ToString();


            var startDate = DateTime.Now;
            var first = new DateTime(year, month, 1);
            List<DateTime> weekends = new List<DateTime>();
            for (int i = 0; i <= DateTime.DaysInMonth(year, month); i++)
            {
                var nextDay = first.AddDays(i);
                if (nextDay.DayOfWeek == DayOfWeek.Saturday || nextDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekends.Add(nextDay);
                }
            }

            var usforResponse = new List<UsersforResponse>();
            var vacation = 'შ';
            string il = ill.ToString();
            string wh = workhour.ToString();
            string vc = vacation.ToString();
            string uv = UnpaidVacation.ToString();
            var userFulname = "";
            var absid = Guid.NewGuid();
            var dy1 = "";
            var dy2 = "";
            var dy3 = "";
            var dy4 = "";
            var dy5 = "";
            var dy6 = "";
            var dy7 = "";
            var dy8 = "";
            var dy9 = "";
            var dy10 = "";
            var dy11 = "";
            var dy12 = "";
            var dy13 = "";
            var dy14 = "";
            var dy15 = "";
            var dy16 = "";
            var dy17 = "";
            var dy18 = "";
            var dy19 = "";
            var dy20 = "";
            var dy21 = "";
            var dy22 = "";
            var dy23 = "";
            var dy24 = "";
            var dy25 = "";
            var dy26 = "";
            var dy27 = "";
            var dy28 = "";
            var dy29 = "";
            var dy30 = "";
            var dy31 = "";
            var dy1hour = "";
            var dy2hour = "";
            var dy3hour = "";
            var dy4hour = "";
            var dy5hour = "";
            var dy6hour = "";
            var dy7hour = "";
            var dy8hour = "";
            var dy9hour = "";
            var dy10hour = "";
            var dy11hour = "";
            var dy12hour = "";
            var dy13hour = "";
            var dy14hour = "";
            var dy15hour = "";
            var dy16hour = "";
            var dy17hour = "";
            var dy18hour = "";
            var dy19hour = "";
            var dy20hour = "";
            var dy21hour = "";
            var dy22hour = "";
            var dy23hour = "";
            var dy24hour = "";
            var dy25hour = "";
            var dy26hour = "";
            var dy27hour = "";
            var dy28hour = "";
            var dy29hour = "";
            var dy30hour = "";
            var dy31hour = "";
            double? sumworkHours = 0;
            double? sumVacationHours = 0;
            double? sumIllHours = 0;
            double? sumUnpaidVacationHours = 0;
            int sumworkDays = 0;
            int sumIllDay = 0;
            int sumUnpaidVacationDay = 0;
            int sumVacationdays = 0;
            foreach (var user in subUser)
            {
                //absMod= new List<AbsenceModel>();
                var absences = await rmgRepository.GetUsersAbsence(user.ResId, filter.date.Value);
                if (userFulname!=user.Fullname)
                {


                    dy1=null;
                    dy2=null;
                    dy3=null;
                    dy4=null;
                    dy5=null;
                    dy6=null;
                    dy7=null;
                    dy8=null;
                    dy9=null;
                    dy10=null;
                    dy11=null;
                    dy12=null;
                    dy13=null;
                    dy14=null;
                    dy15=null;
                    dy16=null;
                    dy17=null;
                    dy18=null;
                    dy19=null;
                    dy20=null;
                    dy21=null;
                    dy22=null;
                    dy23=null;
                    dy24=null;
                    dy25=null;
                    dy26=null;
                    dy27=null;
                    dy28=null;
                    dy29=null;
                    dy30=null;
                    dy31=null;
                    dy1hour=null;
                    dy2hour=null;
                    dy3hour=null;
                    dy4hour=null;
                    dy5hour=null;
                    dy6hour=null;
                    dy7hour=null;
                    dy8hour=null;
                    dy9hour=null;
                    dy10hour=null;
                    dy11hour=null;
                    dy12hour=null;
                    dy13hour=null;
                    dy14hour=null;
                    dy15hour=null;
                    dy16hour=null;
                    dy17hour=null;
                    dy18hour=null;
                    dy19hour=null;
                    dy20hour=null;
                    dy21hour=null;
                    dy22hour=null;
                    dy23hour=null;
                    dy24hour=null;
                    dy25hour=null;
                    dy26hour=null;
                    dy27hour=null;
                    dy28hour=null;
                    dy29hour=null;
                    dy30hour=null;
                    dy31hour=null;
                    sumworkHours=0;
                    sumVacationHours = 0;
                    sumIllHours = 0;
                    sumUnpaidVacationHours = 0;
                    sumworkDays = 0;
                    sumIllDay = 0;
                    sumUnpaidVacationDay = 0;
                    sumVacationdays = 0;
                }

                foreach (var abs in absences)
                {
                    absid= abs.Id;
                    string work = abs.Hours.ToString();
                    if (abs.StartDate.Value.Year == year)
                    {

                        if (abs.StartDate.Value.Month == month)
                        {
                            if (abs.Type==139)
                            {
                                if (abs.EndDate.Value.Month > month)
                                {
                                    int lastday = DateTime.DaysInMonth(year, month);
                                    DateTime date = new DateTime(year, month, lastday);
                                    abs.EndDate = date;
                                }
                                    int thisdays = (abs.EndDate.Value - abs.StartDate.Value).Days;
                                List<DateTime> mydeys = new List<DateTime>();

                                for (int i = abs.StartDate.Value.Day; i <= abs.EndDate.Value.Day; i++)
                                {
                                    var nextDay = first.AddDays(i);                                   
                                    mydeys.Add(nextDay);
                                    
                                }
                                sumworkDays = mydeys.Count;
                                sumworkHours = sumworkHours+(abs.Hours*(thisdays+1));
                            }

                            if (abs.Type==140)
                            {
                                if (abs.EndDate.Value.Month > month)
                                {
                                    int lastday = DateTime.DaysInMonth(year, month);
                                    DateTime date = new DateTime(year, month, lastday);
                                    abs.EndDate = date;
                                }

                                List<DateTime> mydeys = new List<DateTime>();
                                
                                for (int i = abs.StartDate.Value.Day; i <= abs.EndDate.Value.Day; i++)
                                {
                                    var nextDay = first.AddDays(i);
                                    if (nextDay.DayOfWeek != DayOfWeek.Saturday && nextDay.DayOfWeek != DayOfWeek.Sunday)
                                    {
                                        mydeys.Add(nextDay);
                                    }
                                }

                                sumUnpaidVacationDay=mydeys.Count;
                                int mydeysCount = mydeys.Count;

                                sumUnpaidVacationHours = sumUnpaidVacationHours+(8*mydeysCount);
                            }
                            if (abs.Type==10)
                            {
                                if (abs.EndDate.Value.Month > month)
                                {
                                    int lastday = DateTime.DaysInMonth(year, month);
                                    DateTime date = new DateTime(year, month, lastday);
                                    abs.EndDate = date;
                                }
                                List<DateTime> mydeys = new List<DateTime>();

                                for (int i = abs.StartDate.Value.Day-1; i <= abs.EndDate.Value.Day; i++)
                                {
                                    var nextDay = first.AddDays(i);
                                    if (nextDay.DayOfWeek != DayOfWeek.Saturday && nextDay.DayOfWeek != DayOfWeek.Sunday)
                                    {
                                        mydeys.Add(nextDay);
                                    }
                                }

                                sumVacationdays=mydeys.Count;

                                int mydeysCount = mydeys.Count;

                                sumVacationHours = sumVacationHours+(8*(mydeysCount));
                            }
                            if (abs.Type==11)
                            {
                                if (abs.EndDate.Value.Month > month)
                                {
                                    int lastday = DateTime.DaysInMonth(year, month);
                                    DateTime date = new DateTime(year, month, lastday);
                                    abs.EndDate = date;
                                }
                                List<DateTime> mydeys = new List<DateTime>();

                                for (int i = abs.StartDate.Value.Day; i <= abs.EndDate.Value.Day; i++)
                                {
                                    var nextDay = first.AddDays(i);
                                    if (nextDay.DayOfWeek != DayOfWeek.Saturday && nextDay.DayOfWeek != DayOfWeek.Sunday)
                                    {
                                        mydeys.Add(nextDay);
                                    }
                                }
                                sumIllDay=mydeys.Count;

                                int mydeysCount = mydeys.Count;
                                sumIllHours = sumIllHours+(8*(mydeysCount));
                            }



                            //

                            for (var i = abs.StartDate.Value.Day; i<=abs.EndDate.Value.Day; i++)
                            {

                                switch (i)
                                {
                                    case 1:

                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy1=uv;
                                                break;
                                            case 10:
                                                dy1=vc;
                                                break;
                                            case 11:
                                                dy1=il;
                                                break;
                                            case 139:
                                                dy1=wh;
                                                dy1hour=work;
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy2=uv;
                                                break;
                                            case 10:
                                                dy2=vc;
                                                break;
                                            case 11:
                                                dy2=il;
                                                break;
                                            case 139:
                                                dy2hour=work;
                                                dy2=wh;
                                                break;
                                        }
                                        break;
                                    case 3:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy3=uv;
                                                break;
                                            case 10:
                                                dy3=vc;
                                                break;
                                            case 11:
                                                dy3=il;
                                                break;
                                            case 139:
                                                dy3hour=work;
                                                dy3=wh;
                                                break;
                                        }
                                        break;
                                    case 4:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy4=uv;
                                                break;
                                            case 10:
                                                dy4=vc;
                                                break;
                                            case 11:
                                                dy4=il;
                                                break;
                                            case 139:
                                                dy4hour=work;
                                                dy4=wh;
                                                break;
                                        }
                                        break;
                                    case 5:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy5=uv;
                                                break;
                                            case 10:
                                                dy5=vc;
                                                break;
                                            case 11:
                                                dy5=il;
                                                break;
                                            case 139:
                                                dy5hour=work;
                                                dy5=wh;
                                                break;
                                        }
                                        break;
                                    case 6:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy6=uv;
                                                break;
                                            case 10:
                                                dy6=vc;
                                                break;
                                            case 11:
                                                dy6=il;
                                                break;
                                            case 139:
                                                dy6hour=work;
                                                dy6=wh;
                                                break;
                                        }
                                        break;
                                    case 7:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy7=uv;
                                                break;
                                            case 10:
                                                dy7=vc;
                                                break;
                                            case 11:
                                                dy7=il;
                                                break;
                                            case 139:
                                                dy7hour=work;
                                                dy7=wh;
                                                break;
                                        }
                                        break;
                                    case 8:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy8=uv;
                                                break;
                                            case 10:
                                                dy8=vc;
                                                break;
                                            case 11:
                                                dy8=il;
                                                break;
                                            case 139:
                                                dy8hour=work;
                                                dy8=wh;
                                                break;
                                        }
                                        break;
                                    case 9:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy9=uv;
                                                break;
                                            case 10:
                                                dy9=vc;
                                                break;
                                            case 11:
                                                dy9=il;
                                                break;
                                            case 139:
                                                dy9hour=work;
                                                dy9=wh;
                                                break;
                                        }
                                        break;
                                    case 10:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy10=uv;
                                                break;
                                            case 10:
                                                dy10=vc;
                                                break;
                                            case 11:
                                                dy10=il;
                                                break;
                                            case 139:
                                                dy10hour=work;
                                                dy10=wh;
                                                break;
                                        }
                                        break;
                                    case 11:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy11=uv;
                                                break;
                                            case 10:
                                                dy11=vc;
                                                break;
                                            case 11:
                                                dy11=il;
                                                break;
                                            case 139:
                                                dy11hour=work;
                                                dy11=wh;
                                                break;
                                        }
                                        break;
                                    case 12:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy12=uv;
                                                break;
                                            case 10:
                                                dy12=vc;
                                                break;
                                            case 11:
                                                dy12=il;
                                                break;
                                            case 139:
                                                dy12hour=work;
                                                dy12=wh;
                                                break;
                                        }
                                        break;
                                    case 13:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy13=uv;
                                                break;
                                            case 10:
                                                dy13=vc;
                                                break;
                                            case 11:
                                                dy13=il;
                                                break;
                                            case 139:
                                                dy13hour=work;
                                                dy13=wh;
                                                break;
                                        }
                                        break;
                                    case 14:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy14=uv;
                                                break;
                                            case 10:
                                                dy14=vc;
                                                break;
                                            case 11:
                                                dy14=il;
                                                break;
                                            case 139:
                                                dy14hour=work;
                                                dy14=wh;
                                                break;
                                        }
                                        break;
                                    case 15:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy15=uv;
                                                break;
                                            case 10:
                                                dy15=vc;
                                                break;
                                            case 11:
                                                dy15=il;
                                                break;
                                            case 139:
                                                dy15hour=work;
                                                dy15=wh;
                                                break;
                                        }
                                        break;
                                    case 16:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy16=uv;
                                                break;
                                            case 10:
                                                dy16=vc;
                                                break;
                                            case 11:
                                                dy16=il;
                                                break;
                                            case 139:
                                                dy16hour=work;
                                                dy16=wh;
                                                break;
                                        }
                                        break;
                                    case 17:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy17=uv;
                                                break;
                                            case 10:
                                                dy17=vc;
                                                break;
                                            case 11:
                                                dy17=il;
                                                break;
                                            case 139:
                                                dy17hour=work;
                                                dy17=wh;
                                                break;
                                        }
                                        break;
                                    case 18:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy18=uv;
                                                break;
                                            case 10:
                                                dy18=vc;
                                                break;
                                            case 11:
                                                dy18=il;
                                                break;
                                            case 139:
                                                dy18hour=work;
                                                dy18=wh;
                                                break;
                                        }
                                        break;
                                    case 19:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy19=uv;
                                                break;
                                            case 10:
                                                dy19=vc;
                                                break;
                                            case 11:
                                                dy19=il;
                                                break;
                                            case 139:
                                                dy19hour=work;
                                                dy19=wh;
                                                break;
                                        }
                                        break;
                                    case 20:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy20=uv;
                                                break;
                                            case 10:
                                                dy20=vc;
                                                break;
                                            case 11:
                                                dy20=il;
                                                break;
                                            case 139:
                                                dy20hour=work;
                                                dy20=wh;
                                                break;
                                        }
                                        break;
                                    case 21:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy21=uv;
                                                break;
                                            case 10:
                                                dy21=vc;
                                                break;
                                            case 11:
                                                dy21=il;
                                                break;
                                            case 139:
                                                dy21hour=work;
                                                dy21=wh;
                                                break;
                                        }
                                        break;
                                    case 22:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy22=uv;
                                                break;
                                            case 10:
                                                dy22=vc;
                                                break;
                                            case 11:
                                                dy22=il;
                                                break;
                                            case 139:
                                                dy22hour=work;
                                                dy22=wh;
                                                break;
                                        }
                                        break;
                                    case 23:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy23=uv;
                                                break;
                                            case 10:
                                                dy23=vc;
                                                break;
                                            case 11:
                                                dy23=il;
                                                break;
                                            case 139:
                                                dy23hour=work;
                                                dy23=wh;
                                                break;
                                        }
                                        break;
                                    case 24:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy24=uv;
                                                break;
                                            case 10:
                                                dy24=vc;
                                                break;
                                            case 11:
                                                dy24=il;
                                                break;
                                            case 139:
                                                dy24hour=work;
                                                dy24=wh;
                                                break;
                                        }
                                        break;
                                    case 25:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy25=uv;
                                                break;
                                            case 10:
                                                dy25=vc;
                                                break;
                                            case 11:
                                                dy25=il;
                                                break;
                                            case 139:
                                                dy25hour=work;
                                                dy25=wh;
                                                break;
                                        }
                                        break;
                                    case 26:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy26=uv;
                                                break;
                                            case 10:
                                                dy26=vc;
                                                break;
                                            case 11:
                                                dy26=il;
                                                break;
                                            case 139:
                                                dy26hour=work;
                                                dy26=wh;
                                                break;
                                        }
                                        break;
                                    case 27:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy27=uv;
                                                break;
                                            case 10:
                                                dy27=vc;
                                                break;
                                            case 11:
                                                dy27=il;
                                                break;
                                            case 139:
                                                dy27hour=work;
                                                dy27=wh;
                                                break;
                                        }
                                        break;
                                    case 28:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy28=uv;
                                                break;
                                            case 10:
                                                dy28=vc;
                                                break;
                                            case 11:
                                                dy28=il;
                                                break;
                                            case 139:
                                                dy28hour=work;
                                                dy28=wh;
                                                break;
                                        }
                                        break;
                                    case 29:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy29=uv;
                                                break;
                                            case 10:
                                                dy29=vc;
                                                break;
                                            case 11:
                                                dy29=il;
                                                break;
                                            case 139:
                                                dy29hour=work;
                                                dy29=wh;
                                                break;
                                        }
                                        break;
                                    case 30:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy30=uv;
                                                break;
                                            case 10:
                                                dy30=vc;
                                                break;
                                            case 11:
                                                dy30=il;
                                                break;
                                            case 139:
                                                dy30hour=work;
                                                dy30=wh;
                                                break;
                                        }
                                        break;
                                    case 31:
                                        switch (abs.Type)
                                        {
                                            case 140:
                                                dy31=uv;
                                                break;
                                            case 10:
                                                dy31=vc;
                                                break;
                                            case 11:
                                                dy31=il;
                                                break;
                                            case 139:
                                                dy31hour=work;
                                                dy31=wh;
                                                break;
                                        }
                                        break;
                                }

                            }






                            //
                            //if (abs.Type==140)
                            //{
                            //    for (var i = abs.StartDate.Value.Day; i<=abs.EndDate.Value.Day; i++)
                            //    {

                            //        switch (i)
                            //        {
                            //            case 1:

                            //                dy1=uv;
                            //                break;
                            //            case 2:
                            //                dy2=uv;
                            //                break;
                            //            case 3:
                            //                dy3=uv;
                            //                break;
                            //            case 4:
                            //                dy4=uv;
                            //                break;
                            //            case 5:
                            //                dy5=uv;
                            //                break;
                            //            case 6:
                            //                dy6=uv;
                            //                break;
                            //            case 7:
                            //                dy7=uv;
                            //                break;
                            //            case 8:
                            //                dy8=uv;
                            //                break;
                            //            case 9:
                            //                dy9=uv;
                            //                break;
                            //            case 10:
                            //                dy10=uv;
                            //                break;
                            //            case 11:
                            //                dy11=uv;
                            //                break;
                            //            case 12:
                            //                dy12=uv;
                            //                break;
                            //            case 13:
                            //                dy13=uv;
                            //                break;
                            //            case 14:
                            //                dy14=uv;
                            //                break;
                            //            case 15:
                            //                dy15=uv;
                            //                break;
                            //            case 16:
                            //                dy16=uv;
                            //                break;
                            //            case 17:
                            //                dy17=uv;
                            //                break;
                            //            case 18:
                            //                dy18=uv;
                            //                break;
                            //            case 19:
                            //                dy19=uv;
                            //                break;
                            //            case 20:
                            //                dy20=uv;
                            //                break;
                            //            case 21:
                            //                dy21=uv;
                            //                break;
                            //            case 22:
                            //                dy22=uv;
                            //                break;
                            //            case 23:
                            //                dy23=uv;
                            //                break;
                            //            case 24:
                            //                dy24=uv;
                            //                break;
                            //            case 25:
                            //                dy25=uv;
                            //                break;
                            //            case 26:
                            //                dy26=uv;
                            //                break;
                            //            case 27:
                            //                dy27=uv;
                            //                break;
                            //            case 28:
                            //                dy28=uv;
                            //                break;
                            //            case 29:
                            //                dy29=uv;
                            //                break;
                            //            case 30:
                            //                dy30=uv;
                            //                break;
                            //            case 31:
                            //                dy31=uv;
                            //                break;
                            //        }

                            //    }
                            //}
                            //        if (abs.Type==11)
                            //        {
                            //            for (var i = abs.StartDate.Value.Day; i<=abs.EndDate.Value.Day; i++)
                            //            {

                            //                switch (i)
                            //                {
                            //                    case 1:

                            //                        dy1=il;
                            //                        break;
                            //                    case 2:
                            //                        dy2=il;
                            //                        break;
                            //                    case 3:
                            //                        dy3=il;
                            //                        break;
                            //                    case 4:
                            //                        dy4=il;
                            //                        break;
                            //                    case 5:
                            //                        dy5=il;
                            //                        break;
                            //                    case 6:
                            //                        dy6=il;
                            //                        break;
                            //                    case 7:
                            //                        dy7=il;
                            //                        break;
                            //                    case 8:
                            //                        dy8=il;
                            //                        break;
                            //                    case 9:
                            //                        dy9=il;
                            //                        break;
                            //                    case 10:
                            //                        dy10=il;
                            //                        break;
                            //                    case 11:
                            //                        dy11=il;
                            //                        break;
                            //                    case 12:
                            //                        dy12=il;
                            //                        break;
                            //                    case 13:
                            //                        dy13=il;
                            //                        break;
                            //                    case 14:
                            //                        dy14=il;
                            //                        break;
                            //                    case 15:
                            //                        dy15=il;
                            //                        break;
                            //                    case 16:
                            //                        dy16=il;
                            //                        break;
                            //                    case 17:
                            //                        dy17=il;
                            //                        break;
                            //                    case 18:
                            //                        dy18=il;
                            //                        break;
                            //                    case 19:
                            //                        dy19=il;
                            //                        break;
                            //                    case 20:
                            //                        dy20=il;
                            //                        break;
                            //                    case 21:
                            //                        dy21=il;
                            //                        break;
                            //                    case 22:
                            //                        dy22=il;
                            //                        break;
                            //                    case 23:
                            //                        dy23=il;
                            //                        break;
                            //                    case 24:
                            //                        dy24=il;
                            //                        break;
                            //                    case 25:
                            //                        dy25=il;
                            //                        break;
                            //                    case 26:
                            //                        dy26=il;
                            //                        break;
                            //                    case 27:
                            //                        dy27=il;
                            //                        break;
                            //                    case 28:
                            //                        dy28=il;
                            //                        break;
                            //                    case 29:
                            //                        dy29=il;
                            //                        break;
                            //                    case 30:
                            //                        dy30=il;
                            //                        break;
                            //                    case 31:
                            //                        dy31=il;
                            //                        break;
                            //                }

                            //            }
                            //        }

                            //        if (abs.Type==10)
                            //        {
                            //            for (var i = abs.StartDate.Value.Day; i<=abs.EndDate.Value.Day; i++)
                            //            {

                            //                switch (i)
                            //                {
                            //                    case 1:
                            //                        dy1=vc;
                            //                        break;
                            //                    case 2:
                            //                        dy2=vc;
                            //                        break;
                            //                    case 3:
                            //                        dy3=vc;
                            //                        break;
                            //                    case 4:
                            //                        dy4=vc;
                            //                        break;
                            //                    case 5:
                            //                        dy5=vc;
                            //                        break;
                            //                    case 6:
                            //                        dy6=vc;
                            //                        break;
                            //                    case 7:
                            //                        dy7=vc;
                            //                        break;
                            //                    case 8:
                            //                        dy8=vc;
                            //                        break;
                            //                    case 9:
                            //                        dy9=vc;
                            //                        break;
                            //                    case 10:
                            //                        dy10=vc;
                            //                        break;
                            //                    case 11:
                            //                        dy11=vc;
                            //                        break;
                            //                    case 12:
                            //                        dy12=vc;
                            //                        break;
                            //                    case 13:
                            //                        dy13=vc;
                            //                        break;
                            //                    case 14:
                            //                        dy14=vc;
                            //                        break;
                            //                    case 15:
                            //                        dy15=vc;
                            //                        break;
                            //                    case 16:
                            //                        dy16=vc;
                            //                        break;
                            //                    case 17:
                            //                        dy17=vc;
                            //                        break;
                            //                    case 18:
                            //                        dy18=vc;
                            //                        break;
                            //                    case 19:
                            //                        dy19=vc;
                            //                        break;
                            //                    case 20:
                            //                        dy20=vc;
                            //                        break;
                            //                    case 21:
                            //                        dy21=vc;
                            //                        break;
                            //                    case 22:
                            //                        dy22=vc;
                            //                        break;
                            //                    case 23:
                            //                        dy23=vc;
                            //                        break;
                            //                    case 24:
                            //                        dy24=vc;
                            //                        break;
                            //                    case 25:
                            //                        dy25=vc;
                            //                        break;
                            //                    case 26:
                            //                        dy26=vc;
                            //                        break;
                            //                    case 27:
                            //                        dy27=vc;
                            //                        break;
                            //                    case 28:
                            //                        dy28=vc;
                            //                        break;
                            //                    case 29:
                            //                        dy29=vc;
                            //                        break;
                            //                    case 30:
                            //                        dy30=vc;
                            //                        break;
                            //                    case 31:
                            //                        dy31=vc;
                            //                        break;
                            //                }

                            //            }
                            //        }
                            //        if (abs.Type==139)
                            //        {

                            //            for (var i = abs.StartDate.Value.Day; i<=abs.EndDate.Value.Day; i++)
                            //            {

                            //                switch (i)
                            //                {
                            //                    case 1:
                            //                        dy1=wh;
                            //                        break;
                            //                    case 2:
                            //                        dy2=wh;
                            //                        break;
                            //                    case 3:
                            //                        dy3=wh;
                            //                        break;
                            //                    case 4:
                            //                        dy4=wh;
                            //                        break;
                            //                    case 5:
                            //                        dy5=wh;
                            //                        break;
                            //                    case 6:
                            //                        dy6=wh;
                            //                        break;
                            //                    case 7:
                            //                        dy7=wh;
                            //                        break;
                            //                    case 8:
                            //                        dy8=wh;
                            //                        break;
                            //                    case 9:
                            //                        dy9=wh;
                            //                        break;
                            //                    case 10:
                            //                        dy10=wh;
                            //                        break;
                            //                    case 11:
                            //                        dy11=wh;
                            //                        break;
                            //                    case 12:
                            //                        dy12=wh;
                            //                        break;
                            //                    case 13:
                            //                        dy13=wh;
                            //                        break;
                            //                    case 14:
                            //                        dy14=wh;
                            //                        break;
                            //                    case 15:
                            //                        dy15=wh;
                            //                        break;
                            //                    case 16:
                            //                        dy16=wh;
                            //                        break;
                            //                    case 17:
                            //                        dy17=wh;
                            //                        break;
                            //                    case 18:
                            //                        dy18=wh;
                            //                        break;
                            //                    case 19:
                            //                        dy19=wh;
                            //                        break;
                            //                    case 20:
                            //                        dy20=wh;
                            //                        break;
                            //                    case 21:
                            //                        dy21=wh;
                            //                        break;
                            //                    case 22:
                            //                        dy22=wh;
                            //                        break;
                            //                    case 23:
                            //                        dy23=wh;
                            //                        break;
                            //                    case 24:
                            //                        dy24=wh;
                            //                        break;
                            //                    case 25:
                            //                        dy25=wh;
                            //                        break;
                            //                    case 26:
                            //                        dy26=wh;
                            //                        break;
                            //                    case 27:
                            //                        dy27=wh;
                            //                        break;
                            //                    case 28:
                            //                        dy28=wh;
                            //                        break;
                            //                    case 29:
                            //                        dy29=wh;
                            //                        break;
                            //                    case 30:
                            //                        dy30=wh;
                            //                        break;
                            //                    case 31:
                            //                        dy31=wh;
                            //                        break;
                            //                }


                            //            }

                            //}

                        }

                    }
                    foreach (var wkD in weekends)
                    {


                        switch (wkD.Day)
                        {

                            case 1:
                                if (dy1!="სთ")
                                    dy1=wkd;
                                break;
                            case 2:
                                if (dy2!="სთ")
                                    dy2=wkd;
                                break;
                            case 3:
                                if (dy3!="სთ")
                                    dy3=wkd;
                                break;
                            case 4:
                                if (dy4!="სთ")
                                    dy4=wkd;
                                break;
                            case 5:
                                if (dy5!="სთ")
                                    dy5=wkd;
                                break;
                            case 6:
                                if (dy6!="სთ")
                                    dy6=wkd;
                                break;
                            case 7:
                                if (dy7!="სთ")
                                    dy7=wkd;
                                break;
                            case 8:
                                if (dy8!="სთ")
                                    dy8=wkd;
                                break;
                            case 9:
                                if (dy9!="სთ")
                                    dy9=wkd;
                                break;
                            case 10:
                                if (dy10!="სთ")
                                    dy10=wkd;
                                break;
                            case 11:
                                if (dy11!="სთ")
                                    dy11=wkd;
                                break;
                            case 12:
                                if (dy12!="სთ")
                                    dy12=wkd;
                                break;
                            case 13:
                                if (dy13!="სთ")
                                    dy13=wkd;
                                break;
                            case 14:
                                if (dy14!="სთ")
                                    dy14=wkd;
                                break;
                            case 15:
                                if (dy15!="სთ")
                                    dy15=wkd;
                                break;
                            case 16:
                                if (dy16!="სთ")
                                    dy16=wkd;
                                break;
                            case 17:
                                if (dy17!="სთ")
                                    dy17=wkd;
                                break;
                            case 18:
                                if (dy18!="სთ")
                                    dy18=wkd;
                                break;
                            case 19:
                                if (dy19!="სთ")
                                    dy19=wkd;
                                break;
                            case 20:
                                if (dy20!="სთ")
                                    dy20=wkd;
                                break;
                            case 21:
                                if (dy21!="სთ")
                                    dy21=wkd;
                                break;
                            case 22:
                                if (dy22!="სთ")
                                    dy22=wkd;
                                break;
                            case 23:
                                if (dy23!="სთ")
                                    dy23=wkd;
                                break;
                            case 24:
                                if (dy24!="სთ")
                                    dy24=wkd;
                                break;
                            case 25:
                                if (dy25!="სთ")
                                    dy25=wkd;
                                break;
                            case 26:
                                if (dy26!="სთ")
                                    dy26=wkd;
                                break;
                            case 27:
                                if (dy27!="სთ")
                                    dy27=wkd;
                                break;
                            case 28:
                                if (dy28!="სთ")
                                    dy28=wkd;
                                break;
                            case 29:
                                if (dy29!="სთ")
                                    dy29=wkd;
                                break;
                            case 30:
                                if (dy30!="სთ")
                                    dy30=wkd;
                                break;
                            case 31:
                                if (dy31!="სთ")
                                    dy31=wkd;
                                break;
                        }

                    }
                    //absMod.Add(new AbsenceModel
                    //{
                    //    Id= abs.Id,
                    //    EmpId=abs.EmpId,
                    //    EndDate=abs.EndDate,
                    //    StartDate=abs.StartDate,
                    //    Type = abs.Type,

                    //});
                    //}


                    //}

                    //data.Add(new HumreModel
                    //{
                    //    UsrId=user.UsrId,
                    //    Fullname=user.Fullname,
                    //    Id=user.Id,
                    //    ResId=user.ResId,
                    //    EmpStat=user.EmpStat,
                    //    ReptoId=user.ReptoId,
                    //    AbsenceModel=absMod
                    //});
                }



                userFulname=user.Fullname;
                usforResponse.Add(new UsersforResponse
                {
                    Id=absid,
                    Fullname=user.Fullname,
                    Day1=dy1,
                    Day2=dy2,
                    Day3=dy3,
                    Day4=dy4,
                    Day5=dy5,
                    Day6=dy6,
                    Day7=dy7,
                    Day8=dy8,
                    Day9=dy9,
                    Day10=dy10,
                    Day11=dy11,
                    Day12=dy12,
                    Day13=dy13,
                    Day14=dy14,
                    Day15=dy15,
                    Day16=dy16,
                    Day17=dy17,
                    Day18=dy18,
                    Day19=dy19,
                    Day20=dy20,
                    Day21=dy21,
                    Day22=dy22,
                    Day23=dy23,
                    Day24=dy24,
                    Day25=dy25,
                    Day26=dy26,
                    Day27=dy27,
                    Day28=dy28,
                    Day29=dy29,
                    Day30=dy30,
                    Day31=dy31,
                    Day1hour=dy1hour,
                    Day2hour=dy2hour,
                    Day3hour=dy3hour,
                    Day4hour=dy4hour,
                    Day5hour=dy5hour,
                    Day6hour=dy6hour,
                    Day7hour=dy7hour,
                    Day8hour=dy8hour,
                    Day9hour=dy9hour,
                    Day10hour=dy10hour,
                    Day11hour=dy11hour,
                    Day12hour=dy12hour,
                    Day13hour=dy13hour,
                    Day14hour=dy14hour,
                    Day15hour=dy15hour,
                    Day16hour=dy16hour,
                    Day17hour=dy17hour,
                    Day18hour=dy18hour,
                    Day19hour=dy19hour,
                    Day20hour=dy20hour,
                    Day21hour=dy21hour,
                    Day22hour=dy22hour,
                    Day23hour=dy23hour,
                    Day24hour=dy24hour,
                    Day25hour=dy25hour,
                    Day26hour=dy26hour,
                    Day27hour=dy27hour,
                    Day28hour=dy28hour,
                    Day29hour=dy29hour,
                    Day30hour=dy30hour,
                    Day31hour=dy31hour,
                    FullWorkHours=sumworkHours,
                    FullSickHours=sumIllHours,
                    FullVacationHours=sumVacationHours,
                    FullUnpaidVacationHours=sumUnpaidVacationHours,
                    FullWeekendDay=weekends.Count,
                    FullWorKDays=sumworkDays,
                    FullVacationDays=sumVacationdays,
                    FullIllDay=sumIllDay,
                    FullUnpaidVacationDay=sumUnpaidVacationDay,

                });;


                aTimer.Stop();
                aTimer.Dispose();

            }
            return usforResponse;

        }

    }
}

