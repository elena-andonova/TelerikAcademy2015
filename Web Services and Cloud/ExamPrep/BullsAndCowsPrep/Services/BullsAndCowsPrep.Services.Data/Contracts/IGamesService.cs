
namespace BullsAndCowsPrep.Services.Data.Contracts
{
    using BullsAndCowsPrep.Data.Models;
    using System.Linq;

    public interface IGamesService
    {
        // Add all methods which the service will require
        IQueryable<Game> GetPublicGames(int page = 0);
    }
}
