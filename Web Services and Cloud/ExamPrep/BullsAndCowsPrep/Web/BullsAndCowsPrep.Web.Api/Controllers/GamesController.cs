namespace BullsAndCowsPrep.Web.Api.Controllers
{
    using Services.Data.Contracts;
    using System.Web.Http;

    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Models.Games;

    public class GamesController : ApiController
    {
        private IGamesService games;

        public GamesController(IGamesService games)
        {
            this.games = games;
        }

        public IHttpActionResult Get(int page = 1)
        {
            if (this.User.Identity.IsAuthenticated)
            {

            }

            var result = this.games.GetPublicGames(page).ProjectTo<ListedGamesResponseModel>().ToList();

            return this.Ok(result);
        }
    }
}