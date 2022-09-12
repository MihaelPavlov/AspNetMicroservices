namespace Shopping.Aggregator.Services
{
    using Shopping.Aggregator.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICatalogService
    {
        Task<IEnumerable<CatalogModel>> GetCatalog();
        Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category);
        Task<CatalogModel> GetCatalog(string id);
    }
}
