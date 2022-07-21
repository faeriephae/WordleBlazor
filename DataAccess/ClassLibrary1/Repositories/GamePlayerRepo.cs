﻿using System;
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
            this._dataContext = dataContext;
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

        public async Task<Game> GetGamebyIdAsync( int id )
        {
            return await _dataContext.Games.FindAsync(id);
        }

        public Game GetGameById( int id )
        {
            return _dataContext.Games.Find(id);
        }

        public async Task<List<Game>> GetAllGamesByPlayerIdAsync( int id )
        {
            var games =  from g in await _dataContext.Players.Where(p => p.Id == id).ToListAsync()
                        select g.Games;

            return (List<Game>)games;
        }

        public async Task<Player> GetPlayerByGameIdAsync( int id )
        {
            var player = from p in await _dataContext.Games.Where(g => g.Id == id).ToListAsync()
                         select p.Player;

            return (Player)player;
        }
    }
}