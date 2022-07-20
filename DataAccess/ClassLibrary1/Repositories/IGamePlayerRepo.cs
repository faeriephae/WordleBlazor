using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Models;

namespace Wordle.DAL.Repositories
{
    public interface IGamePlayerRepo
    {
        /// <summary>
        /// Gets Game.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Game</returns>
        Task<Game> GetGamebyIdAsync( int id );

        /// <summary>
        /// Gets Game.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Game</returns>
        Game GetGameById( int id );

        /// <summary>
        /// Gets all games belonging to one player.
        /// </summary>
        /// <returns>List</returns>
        Task<List<Game>> GetAllGamesByPlayerIdAsync();

        /// <summary>
        /// Gets player belonging to game id.
        /// </summary>
        /// <returns>Player</returns>
        Task<Player> GetPlayerByGameIdAsync();


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
