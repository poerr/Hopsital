using System.ComponentModel.DataAnnotations;

namespace Hospital.API.Models
{
    public class Building
    {
        [Key]
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public string Name { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string? Description { get; set; }
    }
}
