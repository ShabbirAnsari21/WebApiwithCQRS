using CQRS.Api.Model;
using MediatR;

namespace CQRS.Business.MediatR.Command.Employee
{
    public class DeleteEmployeeCommand : IRequest<PostResponses>
    {
        public int Id { get; set; }
    }
}
