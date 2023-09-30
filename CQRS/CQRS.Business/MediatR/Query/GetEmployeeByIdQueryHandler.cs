using AutoMapper;
using CQRS.Domain.IRepository.Employee;
using CQRS.Model.Model.Response;
using MediatR;

namespace CQRS.Business.MediatR.Query
{
    internal class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeResponse>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByIdQueryHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<EmployeeResponse> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<EmployeeResponse>(await _employeeRepository.GetEmployeeByIDAsync(request.Id));
        }
    }
}
