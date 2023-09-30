using CQRS.Model.Model.Response;
using MediatR;

namespace CQRS.Business.MediatR.Query
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeResponse>
    {
        public int Id { get; set; }
    }
}
