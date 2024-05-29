using BolaRoja.Mobile.Shopping.HttpAggregator.Models;
using System.Threading.Tasks;

namespace BolaRoja.Mobile.Shopping.HttpAggregator.Services
{
    public interface IOrderApiClient
    {
        Task<OrderData> GetOrderDraftFromBasketAsync(BasketData basket);
    }
}
