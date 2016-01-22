namespace Teleimot.Web.Api.Controllers
{
    using Services.Data.Contracts;
    using System.Web.Http;

    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Models.RealEstates;
    using Infrastructure.Validation;
    using Microsoft.AspNet.Identity;

    public class RealEstatesController : ApiController
    {
        private IRealEstatesService realEstates;

        public RealEstatesController(IRealEstatesService realEstates)
        {
            this.realEstates = realEstates;
        }

        public IHttpActionResult Get(int skip = 0, int take = 10)
        {
            var result = this.realEstates.GetPublicRealEstates(skip, take).ProjectTo<PublicRealEstateResponseModel>().ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var realEstate = this.realEstates.GetRealEstateDetails(id);
            object result;

            if (this.User.Identity.IsAuthenticated)
            {
                result = realEstate.ProjectTo<PrivateRealEstateDetailsResponseModel>().FirstOrDefault();
            }
            else
            {
                result = realEstate.ProjectTo<PublicRealEstateDetailsResponseModel>().FirstOrDefault();
            }            

            return this.Ok(result);
        }

        [Authorize]
        [ValidateModel]
        public IHttpActionResult Post(CreateRealEstateRequestModel model)
        {
            var newRealEstate = this.realEstates.CreateRealEstate(
                model.Title,
                model.Description,
                model.Address,
                model.Contact,
                model.ConstructionYear,
                model.SellingPrice,
                model.RentingPrice,
                model.Type,
                this.User.Identity.GetUserId());

            var newRealEstateResult = realEstates
                .GetRealEstateDetails(newRealEstate.Id)
                .ProjectTo<PublicRealEstateResponseModel>()
                .FirstOrDefault();

            return this.Created(
                string.Format("/api/RealEstate/{0}", newRealEstate.Id),
                newRealEstateResult);
        }
    }
}