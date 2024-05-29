using MediatR;
using BolaRoja.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
using Ordering.API.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using static BolaRoja.Services.Ordering.API.Application.Commands.CreateOrderCommand;

namespace BolaRoja.Services.Ordering.API.Application.Commands
{
    public class CreateOrderDraftCommand :  IRequest<OrderDraftDTO>
    {
       
        public string BuyerId { get; private set; }

        public IEnumerable<BasketItem> Items { get; private set; }

        public CreateOrderDraftCommand(string buyerId, IEnumerable<BasketItem> items)
        {
            BuyerId = buyerId;
            Items = items;
        }
    }

}
