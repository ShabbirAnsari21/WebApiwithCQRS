using CQRS.Model.Model.Response;
using MediatR;

namespace CQRS.Business.MediatR.Query
{
    public class GetAllEmployeeQuery : IRequest<IEnumerable<EmployeeResponse>>
    {
    }
}
