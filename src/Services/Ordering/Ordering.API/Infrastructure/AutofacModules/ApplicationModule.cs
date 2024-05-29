using Autofac;
using BolaRoja.BuildingBlocks.EventBus.Abstractions;
using BolaRoja.Services.Ordering.API.Application.Commands;
using BolaRoja.Services.Ordering.API.Application.Queries;
using BolaRoja.Services.Ordering.Domain.AggregatesModel.BuyerAggregate;
using BolaRoja.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
using BolaRoja.Services.Ordering.Infrastructure.Idempotency;
using BolaRoja.Services.Ordering.Infrastructure.Repositories;
using System.Reflection;

namespace BolaRoja.Services.Ordering.API.Infrastructure.AutofacModules
{

    public class ApplicationModule
        :Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.Register(c => new OrderQueries(QueriesConnectionString))
                .As<IOrderQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BuyerRepository>()
                .As<IBuyerRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<OrderRepository>()
                .As<IOrderRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RequestManager>()
               .As<IRequestManager>()
               .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CreateOrderCommandHandler).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));

        }
    }
}
