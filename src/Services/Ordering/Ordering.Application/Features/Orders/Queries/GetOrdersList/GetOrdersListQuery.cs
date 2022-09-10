namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    using MediatR;
    using System;
    using System.Collections.Generic;

    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public string UserName { get; set; }

        public GetOrdersListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
