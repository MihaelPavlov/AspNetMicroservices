namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    using AutoMapper;
    using MediatR;
    using Microsoft.Extensions.Logging;
    using Ordering.Application.Contracts.Persistence;
    using Ordering.Application.Exceptions;
    using Ordering.Domain.Entities;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateOrderCommandHandler> _logger;

        public UpdateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, ILogger<UpdateOrderCommandHandler> logger)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var orderToUpdate = await this._orderRepository.GetByIdAsync(request.Id);

            if (orderToUpdate == null)
            {
                throw new NotFoundException(nameof(Order), request.Id);
            }

            this._mapper.Map(request, orderToUpdate, typeof(UpdateOrderCommand), typeof(Order));

            await this._orderRepository.UpdateAsync(orderToUpdate);

            this._logger.LogInformation($"Order {orderToUpdate.Id} is successfully updated.");

            return Unit.Value;
        }
    }
}
