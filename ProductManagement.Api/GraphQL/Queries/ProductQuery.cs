using ProductManagement.Application.Services;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Api.GraphQL.Queries
{
    public class ProductQuery
    {
        public async Task<List<Product>> GetProducts(
            [Service] IProductRepository repository)
        {
            return await repository.GetAllAsync();
        }
    }
}
