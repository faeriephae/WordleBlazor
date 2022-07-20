using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Models;

namespace Wordle.DAL.Repositories
{
    public interface IPlayerRepo
    {
        /// <summary>
        /// Adds Player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        Task AddPlayerAsync ( Player player );

        /// <summary>
        /// Gets all players.
        /// </summary>
        /// <returns>A list of players. </returns>
        Task<List<Player>> GetAllPlayersAsync ();

        /// <summary>
        /// Gets player by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Player</returns>
        Task<Player> GetPlayerByIdAsync( int id );

        /// <summary>
        /// Deletes player.
        /// </summary>
        /// <param name="id"></param>
        void DeletePlayerByIdAsync ( int id );

        /// <summary>
        /// Gets a player by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Player </returns>
        Player GetPlayerById( int id );
    }
}
