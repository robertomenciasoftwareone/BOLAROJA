namespace BolaRoja.Services.Locations.API.Infrastructure.Services
{
    using BolaRoja.Services.Locations.API.Model;
    using BolaRoja.Services.Locations.API.ViewModel;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILocationsService
    {
        Task<Locations> GetLocationAsync(int locationId);

        Task<UserLocation> GetUserLocationAsync(string id);

        Task<List<Locations>> GetAllLocationAsync();

        Task<bool> AddOrUpdateUserLocationAsync(string userId, LocationRequest locRequest);
    }
}
