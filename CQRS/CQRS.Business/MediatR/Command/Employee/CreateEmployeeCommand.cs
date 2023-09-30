using CQRS.Api.Model;
using MediatR;

namespace CQRS.Business.MediatR.Command.Employee
{
    public class CreateEmployeeCommand : IRequest<PostResponses>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}
