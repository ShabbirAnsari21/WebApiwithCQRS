using System.ComponentModel.DataAnnotations;

namespace CQRS.Domain.Entity
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Gender { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        //public int DepartmentID { get; private set; }
        //public int SupervisorID { get; private set; }
        public DateTime HireDate { get; private set; }
        public decimal Salary { get; private set; }

        public int CalculateAge()
        {
            // Implement logic to calculate age based on DateOfBirth
            // This is a simplified example
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public int CalculateTenure()
        {
            // Implement logic to calculate tenure based on HireDate
            // This is a simplified example
            return DateTime.Now.Year - HireDate.Year;
        }

        public List<string> GetEmployeeBenefits()
        {
            // Implement logic to retrieve employee benefits
            // This is a simplified example
            return new List<string> { "Health Insurance", "401(k) Matching" };
        }


        private Employee()
        {
            // Private constructor to prevent direct object creation.
        }

        public static Employee CreateEmployee(
        string firstName,
        string lastName,
        DateTime dateOfBirth,
        string gender,
        string email,
        string phone,
        string address,
        DateTime hireDate,
        decimal salary)
        {
            // Basic validation for required fields
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("First name and last name are required.");
            }

            return new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Email = email,
                Phone = phone,
                Address = address,
                HireDate = hireDate,
                Salary = salary
            };
        }

        public void UpdateEmployeeDetails(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string gender,
            string email,
            string phone,
            string address,
            DateTime hireDate,
            decimal salary)
        {
            // Basic validation for required fields
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("First name and last name are required.");
            }

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Email = email;
            Phone = phone;
            Address = address;
            HireDate = hireDate;
            Salary = salary;
        }
    }
}
