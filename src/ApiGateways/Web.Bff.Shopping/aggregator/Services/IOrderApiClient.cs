using BolaRoja.Web.Shopping.HttpAggregator.Models;
using System.Threading.Tasks;

namespace BolaRoja.Web.Shopping.HttpAggregator.Services
{
    public interface IOrderApiClient
    {
        Task<OrderData> GetOrderDraftFromBasketAsync(BasketData basket);
    }
}
