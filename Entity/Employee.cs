using System.ComponentModel.DataAnnotations;

namespace WebApi.Entity
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; } 
        public string? Name { get; set; }

        public DateTime? reated_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateOnly? DOB { get; set; }
        public string? Position { get; set; }
        public string? Department { get; set; }
        public string? Email { get; set; }
    }
}
