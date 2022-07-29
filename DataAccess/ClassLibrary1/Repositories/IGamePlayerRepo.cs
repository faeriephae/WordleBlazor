using Wordle.Models;

namespace Wordle.DAL.Repositories
{
    public interface IGamePlayerRepo
    {
        /// <summary>
        /// Gets a (new) game.
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        Task<Game> GetGameAsync();

        /// <summary>
        /// Updates Game.
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        void UpdateGame( Game game );


        /// <summary>
        /// Gets Game by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Game</returns>
        Task<Game> GetGameByIdAsync( int id );

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
        Task<List<Game>> GetAllGamesByPlayerIdAsync( int id );

        /// <summary>
        /// Gets player belonging to game id.
        /// </summary>
        /// <returns>Player</returns>
        Task<Player> GetPlayerByGameIdAsync( int id );


        /// <summary>
        /// Adds Player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        Task AddPlayerAsync( Player player );

        /// <summary>
        /// Gets all players.
        /// </summary>
        /// <returns>A list of players. </returns>
        Task<List<Player>> GetAllPlayersAsync();

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
        void DeletePlayerByIdAsync( int id );

        /// <summary>
        /// Gets a player by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Player </returns>
        Player GetPlayerById( int id );
    }
}
