namespace Ordering.BackgroundTasks.Events
{
    using BolaRoja.BuildingBlocks.EventBus.Events;

    public class GracePeriodConfirmedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public GracePeriodConfirmedIntegrationEvent(int orderId) =>
            OrderId = orderId;
    }
}
