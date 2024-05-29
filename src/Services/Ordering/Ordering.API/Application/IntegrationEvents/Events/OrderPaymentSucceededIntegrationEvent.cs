namespace Ordering.API.Application.IntegrationEvents.Events
{
    using BolaRoja.BuildingBlocks.EventBus.Events;

    public class OrderPaymentSucceededIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public OrderPaymentSucceededIntegrationEvent(int orderId) => OrderId = orderId;
    }
}