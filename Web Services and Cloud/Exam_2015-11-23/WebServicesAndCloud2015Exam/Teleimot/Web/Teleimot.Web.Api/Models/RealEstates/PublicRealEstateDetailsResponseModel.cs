namespace Teleimot.Web.Api.Models.RealEstates
{
    using System;
    using AutoMapper;
    using Infrastructure.Mappings;
    using Data.Models;

    public class PublicRealEstateDetailsResponseModel : IMapFrom<RealEstate>, IHaveCustomMappings
    {
        //{
        //   "CreatedOn": "2015-11-22T16:06:27.97",
        //    "ConstructionYear": 2005,
        //    "Address": "Mladost 1A, Telerik Academy building",
        //    "RealEstateType": "Office",
        //    "Description": "You will love it. The view is great!",
        //    "Id": 1,
        //    "Title": "Some very interesting office",
        //    "SellingPrice": 120000,
        //    "RentingPrice": 500,
        //    "CanBeSold": true,
        //    "CanBeRented": true
        //}

        public DateTime CreatedOn { get; set; }

        public string ConstructionYear { get; set; }

        public string Address { get; set; }

        public string RealEstateType { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public string SellingPrice { get; set; }

        public string RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<RealEstate, PublicRealEstateDetailsResponseModel>()
                        .ForMember(re => re.RealEstateType, opts => opts.MapFrom(re => re.RealEstateType.ToString()));
        }
    }
}