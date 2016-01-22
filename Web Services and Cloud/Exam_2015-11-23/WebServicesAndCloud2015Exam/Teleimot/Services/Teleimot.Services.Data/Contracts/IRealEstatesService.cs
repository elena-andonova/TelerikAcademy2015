
namespace Teleimot.Services.Data.Contracts
{
    using Teleimot.Data.Models;
    using System.Linq;

    public interface IRealEstatesService
    {
        // Add all methods which the service will require
        IQueryable<RealEstate> GetPublicRealEstates(int skip = 0, int take = 10);

        IQueryable<RealEstate> GetRealEstateDetails(int id);

        RealEstate CreateRealEstate(
            string title,
            string description,
            string address,
            string contact,
            string constructionYear,
            string sellingPrice,
            string rentingPrice,
            int type,
            string userId);        
    }
}
