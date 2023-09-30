using System.ComponentModel.DataAnnotations;

namespace CQRS.Model.Model.Request
{
    public class UpdateEmployeeRequest
    {
        [Required(ErrorMessage = "EmployeeId is required")]
        public int EmployeeId { get; set; }
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
