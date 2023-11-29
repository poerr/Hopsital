using System.ComponentModel.DataAnnotations;

namespace Hospital.API.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string? Description { get; set; }
    }
}
