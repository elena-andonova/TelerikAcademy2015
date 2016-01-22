namespace BullsAndCowsPrep.Services.Data.Contracts
{
    using BullsAndCowsPrep.Data.Models;
    using BullsAndCowsPrep.Data.Repositories;
    using System.Linq;

    public class GamesService : IGamesService
    {
        private IRepository<Game> games;

        public GamesService(IRepository<Game> games)
        {
            this.games = games;
        }

        public IQueryable<Game> GetPublicGames(int page = 1)
        {
            return this.games
                .All()
                .Where(g => g.GameState == GameState.WaitingForOpponent)
                .OrderBy(g => g.GameState)
                .ThenBy(g => g.DateCreated)
                .ThenBy(g => g.RedUser.Email)
                .Skip((page - 1) * 10)
                .Take(10);
        }
    }
}
