using HotChocolate;
using HotChocolate.Types;
using ProductManagement.Application.Services;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Api.GraphQL.Mutations
{
    [ExtendObjectType("Mutation")]
    public class DepartmentMutation
    {
        public async Task<Department> AddDepartment(
            string name,
            string location,
            [Service] IDepartmentRepository repository)
        {
            var department = new Department
            {
                Id = Guid.NewGuid(),
                Name = name,
                Location = location
            };

            return await repository.AddAsync(department);
        }
    }
}
