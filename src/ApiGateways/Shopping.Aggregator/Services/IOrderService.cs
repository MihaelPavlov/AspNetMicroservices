namespace Shopping.Aggregator.Services
{
    using Shopping.Aggregator.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
