using Auctions.Models;

namespace Auctions.Data.Services;

// This interface is used to get data from the Listings table in the database.
public interface IListingService
{
    IQueryable<Listing> GetAll();
}
