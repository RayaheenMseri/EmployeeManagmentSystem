using System.ComponentModel.DataAnnotations;

namespace EmployeeManagmentSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        public double Salary { get; set; }
    }
}
