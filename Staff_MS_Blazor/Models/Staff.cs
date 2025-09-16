using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Staff_MS_Blazor.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Student Name")]
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
