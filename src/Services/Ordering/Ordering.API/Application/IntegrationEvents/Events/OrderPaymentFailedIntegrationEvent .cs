namespace Ordering.API.Application.IntegrationEvents.Events
{
    using BolaRoja.BuildingBlocks.EventBus.Events;

    public class OrderPaymentFailedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public OrderPaymentFailedIntegrationEvent(int orderId) => OrderId = orderId;
    }
}