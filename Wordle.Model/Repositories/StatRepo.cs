﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.DAL;
using Wordle.DAL.Repositories;
using Wordle.Model.Model;

namespace Wordle.Model.DAL.Repositories
{
    public class StatRepo : IStatRepo
    {
        private DataContext _dataContext;
        public StatRepo( DataContext dataContext )
        {
            this._dataContext = dataContext;
        }

        public async Task<Stat> GetStatAsync( int id )
        {
            return await _dataContext.Stats.FindAsync(id);
        }

        public async Task<Stat> GetStatAsync( Player player )
        {
            throw new NotImplementedException();
        }

        public async Task<List<Stat>> GetAllStatsAsync()
        {
            throw new NotImplementedException();
        }


        public async Task<List<Stat>> GetAllStatsAsync( int playerId )
        {
            return await _dataContext.Stats.Where(p => p.Player.Id == playerId).ToListAsync();
        }

        //TODO
        public Task<Stat> CalculateGameStatsAsync( int id )
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStat( int id )
        {
            Stat stat = await GetStatAsync(id);
            _dataContext.Remove(stat);
        }

        public async Task AddStatAsync( Stat stat )
        {
            await _dataContext.AddAsync(stat);
        }

        public async Task UpdatePlayerStatsAsync( int id  )
        {
            _dataContext.Stats.UpdateRange(await CalculateGameStatsAsync(id));
        }
    }
}