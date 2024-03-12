using Rmg.DAL.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rmg.DAL.Repositories.Interfaces
{
    public interface IRmgRepository
    {
        Task<Humre> GetUserClaims(string usr_id);
        Task<IEnumerable<Humre>> GetsubordinateUsers(int res_id);
        Task<IEnumerable<Absence>> GetUsersAbsence(int res_id, DateTime date);

    }
}
