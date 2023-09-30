using CQRS.Api.Model;
using CQRS.Domain.IRepository.Employee;
using MediatR;

namespace CQRS.Business.MediatR.Command.Employee
{
    internal class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, PostResponses>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<PostResponses> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIDAsync(request.EmployeeId);
            if (employee == null)
                return default;

            employee.UpdateEmployeeDetails(request.FirstName, request.LastName, request.DateOfBirth, request.Gender, request.Email, request.Phone, request.Address, request.HireDate, request.Salary);

            await _employeeRepository.UpdateEmployeeAsync(employee);

            return PostResponses.ResponseMessages(employee.EmployeeID, true, "Employee Updated");

        }
    }
}
