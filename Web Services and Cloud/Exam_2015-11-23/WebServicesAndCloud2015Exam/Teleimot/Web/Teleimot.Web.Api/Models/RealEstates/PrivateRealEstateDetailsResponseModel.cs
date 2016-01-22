namespace Teleimot.Web.Api.Models.RealEstates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Infrastructure.Mappings;
    using Data.Models;
    using AutoMapper;
    using Comments;

    public class PrivateRealEstateDetailsResponseModel : IMapFrom<RealEstate>, IHaveCustomMappings
    {
        //    {
        //"Contact": "0888-888-888",
        //"Comments": [
        //    {
        //        "Content": "Wow, such a bargain! I want to see the place!",
        //        "UserName": "ivaylokenov",
        //        "CreatedOn": "2015-11-22T16:40:03.123"
        //    },
        //    {
        //        "Content": "Lol, why? I like it!",
        //        "UserName": "ivaylokenov",
        //        "CreatedOn": "2015-11-22T16:41:22.733"
        //    }
        //],
        //"CreatedOn": "2015-11-22T16:39:03.74",
        //"ConstructionYear": 1985,
        //"Address": "Dragovishtica",
        //"RealEstateType": null,
        //"Description": "very cheap, no rats!",
        //"Id": 3,
        //"Title": "My house is for sale!",
        //"SellingPrice": 28000,
        //"RentingPrice": null,
        //"CanBeSold": true,
        //"CanBeRented": false
        //    }

        public string Contact { get; set; }

        public IEnumerable<CommentResponseModel> Comments { get; set; }

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
            configuration.CreateMap<RealEstate, PrivateRealEstateDetailsResponseModel>()
                        .ForMember(re => re.RealEstateType, opts => opts.MapFrom(re => re.RealEstateType.ToString()));
                        
        }
    }
}