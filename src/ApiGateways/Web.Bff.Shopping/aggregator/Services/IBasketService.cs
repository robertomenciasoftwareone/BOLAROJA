using BolaRoja.Web.Shopping.HttpAggregator.Models;
using System.Threading.Tasks;

namespace BolaRoja.Web.Shopping.HttpAggregator.Services
{
    public interface IBasketService
    {
        Task<BasketData> GetById(string id);

        Task UpdateAsync(BasketData currentBasket);
    }
}
