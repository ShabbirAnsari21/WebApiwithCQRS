using CQRS.Api.Model;
using CQRS.Domain.IRepository.Employee;
using MediatR;

namespace CQRS.Business.MediatR.Command.Employee
{
    internal class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, PostResponses>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<PostResponses> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _employeeRepository.DeleteEmployeeAsync(request.Id);
            return PostResponses.ResponseMessages(request.Id, true, "Employee Deleted");
        }
    }
}
