namespace Teleimot.Web.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using Services.Data.Contracts;
    using AutoMapper.QueryableExtensions;
    using Models.Users;
    using Models.Ratings;

    public class UsersController : ApiController
    {
        private IUsersService users;

        public UsersController(IUsersService users)
        {
            this.users = users;
        }

        [HttpGet]
        [Route("api/Users/{userName}")]
        [Authorize]
        public IHttpActionResult Get(string userName)
        {
            var result = this.users.GetUserDetails(userName).ProjectTo<UserDetailsResponseModel>().FirstOrDefault();

            return this.Ok(result);
        }

        [HttpPut]
        [Route("api/Users/Rate")]
        [Authorize]
        public IHttpActionResult Put(RatingRequestModel model)
        {
            this.users.RateUser(model.UserId, model.Value);

            return this.Ok();
        }
    }
}