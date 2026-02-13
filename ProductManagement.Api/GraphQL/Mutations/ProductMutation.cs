using ProductManagement.Application.Services;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Api.GraphQL.Mutations
{
    public class ProductMutation
    {
        public async Task<Product> AddProduct(
            string name,
            decimal price,
            [Service] IProductRepository repository)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = name,
                Price = price
            };

            return await repository.AddAsync(product);
        }
    }
}
