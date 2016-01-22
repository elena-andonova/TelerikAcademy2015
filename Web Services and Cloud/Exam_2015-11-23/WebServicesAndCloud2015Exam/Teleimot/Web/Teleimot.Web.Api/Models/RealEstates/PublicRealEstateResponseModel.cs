namespace Teleimot.Web.Api.Models.RealEstates
{
    using AutoMapper;
    using System;
    using Data.Models;
    using Infrastructure.Mappings;

    public class PublicRealEstateResponseModel : IMapFrom<RealEstate>
    {
        public int Id { get; set; }

        public string Title { get; set; }        

        public string SellingPrice { get; set; }

        public string RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }                 
    }
}