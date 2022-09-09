namespace Discount.Grpc.Repositories
{
    using Discount.Grpc.Entities;
    using System.Threading.Tasks;

    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);

        Task<bool> CreateDiscount(Coupon coupon);

        Task<bool> UpdateDiscount(Coupon coupon);

        Task<bool> DeleteDiscount(string productName);
    }
}
