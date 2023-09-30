namespace CQRS.Domain.IRepository.Employee
{
    public interface IEmployeeRepository
    {
        Task CreateEmployeeAsync(Entity.Employee employee);
        Task UpdateEmployeeAsync(Entity.Employee employee);
        Task DeleteEmployeeAsync(int employeeID);
        Task<Entity.Employee?> GetEmployeeByIDAsync(int employeeID);
        Task<List<Entity.Employee>> GetAllEmployeesAsync();
    }
}
