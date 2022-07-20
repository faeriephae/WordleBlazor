using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Models;

namespace Wordle.DAL.Repositories
{
    public interface IStatRepo : IPlayerRepo
    {
        int IStatId { get; set; }
        Task<Stat> GetStatsAsync( int id );
        Task<Stat> CalculateGameStatsAsync( int id );
        Task<Stat> UpdateStatsAsync( int id );
    }
}
