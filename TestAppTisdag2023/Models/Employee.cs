using System.ComponentModel.DataAnnotations;

namespace TestAppTisdag2023.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
