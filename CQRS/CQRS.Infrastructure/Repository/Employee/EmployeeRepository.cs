using CQRS.Domain.Entity;
using CQRS.Domain.IRepository.Employee;
using CQRS.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly ApplicationDbContext _context;

    public EmployeeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // Create a new employee
    public async Task CreateEmployeeAsync(Employee employee)
    {
        await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();
    }

    // Update an existing employee
    public async Task UpdateEmployeeAsync(Employee employee)
    {
        _context.Employees.Update(employee);
        await _context.SaveChangesAsync();
    }

    // Delete an employee by ID
    public async Task DeleteEmployeeAsync(int employeeID)
    {
        var employee = await _context.Employees.FindAsync(employeeID);
        if (employee != null)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }

    // Retrieve an employee by ID
    public async Task<Employee?> GetEmployeeByIDAsync(int employeeID)
    {
        return await _context.Employees.FindAsync(employeeID);
    }

    // Retrieve all employees
    public async Task<List<Employee>> GetAllEmployeesAsync()
    {
        return await _context.Employees.ToListAsync();
    }
}
