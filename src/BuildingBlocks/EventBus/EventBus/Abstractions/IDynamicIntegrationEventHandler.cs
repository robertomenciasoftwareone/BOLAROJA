using System.Threading.Tasks;

namespace BolaRoja.BuildingBlocks.EventBus.Abstractions
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
