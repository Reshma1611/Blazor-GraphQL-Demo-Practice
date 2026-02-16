using HotChocolate;
using HotChocolate.Types;
using ProductManagement.Application.Services;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Api.GraphQL.Mutations
{
    [ExtendObjectType("Mutation")]
    public class ProductMutation
    {
        public async Task<Product> AddProduct(
            string name,
            decimal price,
            [Service] IProductRepository repository)
        {
            try
            {
                var product = new Product
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Price = price,
                    CreatedAt = DateTime.UtcNow
                };

                return await repository.AddAsync(product);
            }
            catch (Exception ex)
            {
                throw new GraphQLException(new ErrorBuilder()
                    .SetMessage($"Failed to add product: {ex.Message}")
                    .SetExtension("details", ex.ToString())
                    .Build());
            }
        }
    }
}
