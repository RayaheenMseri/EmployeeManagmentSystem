using System.ComponentModel.DataAnnotations;

namespace EmployeeManagmentSystem.Models
{
    public class EmployeeN
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public double Salary { get; set; }
    }
}
