using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.DAL.Repositories;

namespace Wordle.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private GamePlayerRepo? _gamePlayerRepo;
        private StatService? _statRepo;
        private DataContext _dataContext;

        public GamePlayerRepo GamePlayerRepo
        {
            get
            {
                //If null --> assign
                return _gamePlayerRepo ??= new GamePlayerRepo(_dataContext);
            }
            set { _gamePlayerRepo = value; }
        }

        public StatService StatRepo
        {
            get
            {
                return _statRepo ??= new StatService(_dataContext);
            }
            set { _statRepo = value; }
        }

        //Save
        public async Task CommitAsync()
        {
            await _dataContext.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await _dataContext.DisposeAsync();
        }
    }
}
