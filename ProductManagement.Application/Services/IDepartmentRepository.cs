using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Services
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(Guid id);
        Task<Department> AddAsync(Department department);
        Task<Department> UpdateAsync(Department department);
        Task DeleteAsync(Guid id);
    }
}
