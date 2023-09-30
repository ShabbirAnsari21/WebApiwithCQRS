using CQRS.Api.Model;
using CQRS.Domain.IRepository.Employee;
using MediatR;

namespace CQRS.Business.MediatR.Command.Employee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, PostResponses>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<PostResponses> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var createEmployee = Domain.Entity.Employee.CreateEmployee(request.FirstName, request.LastName, request.DateOfBirth, request.Gender, request.Email, request.Phone, request.Address, request.HireDate, request.Salary);

            await _employeeRepository.CreateEmployeeAsync(createEmployee);

            return PostResponses.ResponseMessages(createEmployee.EmployeeID, true, "Employee Added");

        }
    }
}
