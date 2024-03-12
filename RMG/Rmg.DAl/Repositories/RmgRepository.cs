using Microsoft.EntityFrameworkCore;
using Rmg.DAL.Database;
using Rmg.DAL.DataBase.Entities;
using Rmg.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rmg.DAL.Repositories
{
    public class RmgRepository : IRmgRepository
    {
        private readonly _710Context db;

        public RmgRepository(_710Context db)
        {
            this.db = db;
        }

        public async Task<Humre> GetUserClaims(string fullName)
        {
            var result = await db.Humres.Where(x => x.UsrId == fullName).FirstOrDefaultAsync();
           
            return result;
            
        }

        public async Task<IEnumerable<Humre>> GetsubordinateUsers(int res_id)
        {
            var subordinateUsers = await db.Humres.Where(x => x.ReptoId == res_id && x.EmpStat=="A").ToListAsync();

            return subordinateUsers;

        }
        public async Task<IEnumerable<Absence>> GetUsersAbsence(int res_id, DateTime date)
        {
            var userAbsence = await db.Absences.Where(x => x.EmpId == res_id).ToListAsync();
             
            return userAbsence;

        }
    }
}
