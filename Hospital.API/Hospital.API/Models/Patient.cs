using System.ComponentModel.DataAnnotations;

namespace Hospital.API.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string Status { get; set; }
    }
}
