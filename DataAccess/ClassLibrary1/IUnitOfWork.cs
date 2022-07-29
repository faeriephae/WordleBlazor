using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.DAL.Repositories;

namespace Wordle.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Instance of GamePlayerRepo.
        /// </summary>
        GamePlayerRepo GamePlayerRepo { get; set; }

        /// <summary>
        /// Instance of StatRepo.
        /// </summary>
        StatRepo StatRepo { get; set; }

        /// <summary>
        /// Saves changes.
        /// </summary>
        /// <returns></returns>
        Task CommitAsync();

    }
}
