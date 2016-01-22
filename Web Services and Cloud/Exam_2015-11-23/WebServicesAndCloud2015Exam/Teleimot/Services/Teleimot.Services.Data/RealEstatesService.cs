namespace Teleimot.Services.Data.Contracts
{
    using System;
    using System.Linq;
    using Teleimot.Data.Models;
    using Teleimot.Data.Repositories;
    using Common.Validation;

    public class RealEstatesService : IRealEstatesService
    {
        private IRepository<RealEstate> realEstates;

        public RealEstatesService(IRepository<RealEstate> realEstates)
        {
            this.realEstates = realEstates;
        }

        public IQueryable<RealEstate> GetPublicRealEstates(int skip = 0, int take = 10)
        {
            return this.realEstates
                .All()
                .OrderByDescending(re => re.CreatedOn)
                .Skip(skip * take)
                .Take(take);                      
        }

        public IQueryable<RealEstate> GetRealEstateDetails(int id)
        {
            return this.realEstates
                .All()
                .Where(g => g.Id == id);
        }

        public RealEstate CreateRealEstate(
            string title, 
            string description, 
            string address, 
            string contact, 
            string constructionYear,
            string sellingPrice,
            string rentingPrice,
            int type,
            string userId)
        {
            bool canBeRented = true;

            if (ValidateRentingAndSellingPrice.CanBeRentOrSold(rentingPrice))
            {
                rentingPrice = null;
                canBeRented = false;
            }

            bool canBeSold = true;
            if (ValidateRentingAndSellingPrice.CanBeRentOrSold(sellingPrice))
            {
                sellingPrice = null;
                canBeSold = false;
            }

            var newRealEstate = new RealEstate
            {
                Title = title,
                Description = description,
                Address = address,
                Contact = contact,
                ConstructionYear = constructionYear,
                CanBeSold = canBeSold,
                SellingPrice = sellingPrice,
                CanBeRented = canBeRented,
                RentingPrice = rentingPrice,
                RealEstateType = (RealEstateType)(type),
                CreatedOn = DateTime.UtcNow,
                UserId = userId
            };

            this.realEstates.Add(newRealEstate);
            this.realEstates.SaveChanges();

            return newRealEstate;
        }
    }
}
