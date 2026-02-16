using HotChocolate;
using HotChocolate.Types;
using ProductManagement.Application.Services;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Api.GraphQL.Queries
{
    [ExtendObjectType("Query")]
    public class DepartmentQuery
    {
        public async Task<List<Department>> GetDepartments(
            [Service] IDepartmentRepository repository)
        {
            return await repository.GetAllAsync();
        }
    }
}
