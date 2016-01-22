namespace Teleimot.Web.Api.Models.RealEstates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using AutoMapper;
    using Teleimot.Data.Models;
    using Teleimot.Web.Api.Infrastructure.Mappings;
    using System.ComponentModel.DataAnnotations;
    using Common.Validation;

    public class CreateRealEstateRequestModel : IValidatableObject
    {
    //    {
    //      "Title": "Some very interesting office",
    //      "Description": "You will love it. The view is great!",
    //      "Address": "Mladost 1A, Telerik Academy building",
    //      "Contact": "0888-888-888",
    //      "ConstructionYear": 2005,
    //      "SellingPrice": 120000,
    //      "RentingPrice": 500,
    //      "Type": 2
    //    }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string ConstructionYear { get; set; }

        public string SellingPrice { get; set; }

        public string RentingPrice { get; set; }

        public int Type { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (int.Parse(this.ConstructionYear) < 1800)
            {
                yield return new ValidationResult("Real estate construction year is minimum 1800!");
            }

            if (ValidateRentingAndSellingPrice.CanBeRentOrSold(SellingPrice) 
                && ValidateRentingAndSellingPrice.CanBeRentOrSold(RentingPrice))
            {
                yield return new ValidationResult("Real estate can be published only for renting, only for selling or for both, but not without any of the two options!");
            }
        }
    }
}