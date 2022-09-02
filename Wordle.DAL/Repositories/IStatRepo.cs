using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model;

namespace Wordle.DAL.Repositories
{
    public interface IStatRepo
    {

        /// <summary>
        /// Deletes Stat.
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        Task DeleteStat( int id );

        /// <summary>
        /// Adds Stat.
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        Task AddStatAsync( Stat stat );

        /// <summary>
        /// Gets all Stats.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List</returns>
        Task<List<Stat>> GetAllStatsAsync();

        /// <summary>
        /// Gets Stat by Stat.Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Stat</returns>
        Task<Stat> GetStatAsync( int statId );

        /// <summary>
        /// Calculates Stats.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Stat> CalculateGameStatsAsync( int id );

        /// <summary>
        /// Updates Stats.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task UpdatePlayerStatsAsync( int id );
    }
}
