using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wordle.Models;

namespace Wordle.DAL.Repositories
{
    public class GamePlayerRepo : IGamePlayerRepo
    {
        private DataContext _dataContext;
        public GamePlayerRepo( DataContext dataContext )
        {
            _dataContext = dataContext;
        }

        public async Task AddPlayerAsync( Player player )
        {
            await _dataContext.Players.AddAsync(player);
        }

        public async void DeletePlayerByIdAsync( int id )
        {
            _dataContext.Remove(await GetPlayerByIdAsync(id));
        }

        public async Task<List<Player>> GetAllPlayersAsync()
        {
            return await _dataContext.Players.ToListAsync();
        }

        public async Task<Player> GetPlayerByIdAsync( int id )
        {
            return await _dataContext.Players.FindAsync(id);
        }

        public Player GetPlayerById( int id )
        {
            return _dataContext.Players.Find(id);
        }

        public Task<Game> GetGamebyIdAsync( int id )
        {
            throw new NotImplementedException();
        }

        public Game GetGameById( int id )
        {
            throw new NotImplementedException();
        }

        public Task<List<Game>> GetAllGamesByPlayerIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetPlayerByGameIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
