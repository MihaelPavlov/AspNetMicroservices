namespace Shopping.Aggregator.Services
{
    using Shopping.Aggregator.Models;
    using System.Threading.Tasks;

    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
