using System.ComponentModel.DataAnnotations;

namespace DBRepository
{
    public class Student
    {
        [Required(ErrorMessage = "ID is required, Please enter a valid ID")]
        public int ID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public required string Name { get; set; }
        [Range(10, 50, ErrorMessage = "Age must be between 10 and 50")]
        public int Age { get; set; }
        [MinLength(2, ErrorMessage = "Minimum Length is 2 characters")]
        public string Gender { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public required string Email { get; set; }
        [MinLength(5, ErrorMessage = "Marks must have at least 5 records")]
        public List<string> Marks { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }
    }
}
