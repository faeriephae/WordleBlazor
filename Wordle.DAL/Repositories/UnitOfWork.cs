using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private GamePlayerRepo? _gamePlayerRepo;
        private StatRepo? _statRepo;
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

        public StatRepo StatRepo
        {
            get
            {
                return _statRepo ??= new StatRepo(_dataContext);
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
