using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Models;

namespace Wordle.DAL.Repositories
{
    public class StatRepo : IStatRepo
    {
        public Task<Stat> CalculateGameStatsAsync( int id )
        {
            throw new NotImplementedException();
        }

        public Task<List<Stat>> GetStatsAsync( int id )
        {
            throw new NotImplementedException();
        }

        public Task<Stat> UpdateStatsAsync( int id )
        {
            throw new NotImplementedException();
        }
    }
}
