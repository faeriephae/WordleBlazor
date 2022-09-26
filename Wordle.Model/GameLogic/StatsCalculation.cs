using Wordle.DAL;
using Wordle.DAL.Repositories;
using Wordle.Model;

namespace Wordle.Model.GameLogic
{
    public class StatsCalculation
    {
        private DataContext? _dataContext = new DataContext();

        private UnitOfWork? uow;

        private int gamesPlayed;
        private int gamesWon;
        private int streak;
        private int maxStreak;
        private float winPercentage;

        public int GamesPlayed
        {
            get { return gamesPlayed; }
        }

        public int GamesWon
        {
            get { return gamesWon; }
        }
        public int Streak
        {
            get { return streak; }
        }

        public int MaxStreak
        {
            get { return maxStreak; }
        }

        public float WinPercentage
        {
            get { return winPercentage; }
        }

        public StatsCalculation()
        {
            uow = new UnitOfWork( _dataContext );
        }

        /// <summary>
        /// Calculate statistic.
        /// </summary>
        /// <param name="hasWon"></param>
        public void CalculateStats( bool hasWon )
        {
            gamesPlayed++;

            if( hasWon )
            {
                gamesWon++;
                streak++;

                //set max streak
                if( streak > maxStreak )
                {
                    maxStreak = streak;
                }
            }

            //reset streak on loss
            else
            {
                streak = 0;
            }

            //average
            winPercentage = gamesWon / gamesPlayed * 100;
        }
    }
}
