using BolaRoja.Mobile.Shopping.HttpAggregator.Models;
using System.Threading.Tasks;

namespace BolaRoja.Mobile.Shopping.HttpAggregator.Services
{
    public interface IOrderingService
    {
        Task<OrderData> GetOrderDraftAsync(BasketData basketData);
    }
}