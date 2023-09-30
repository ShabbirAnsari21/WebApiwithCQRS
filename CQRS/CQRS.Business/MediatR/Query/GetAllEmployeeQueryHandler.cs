using AutoMapper;
using CQRS.Domain.IRepository.Employee;
using CQRS.Model.Model.Response;
using MediatR;

namespace CQRS.Business.MediatR.Query
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetAllEmployeeQueryHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EmployeeResponse>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IList<EmployeeResponse>>(await _employeeRepository.GetAllEmployeesAsync());
             
        }
    }
}
