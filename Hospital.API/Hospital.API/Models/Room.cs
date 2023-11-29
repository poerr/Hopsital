using System.ComponentModel.DataAnnotations;

namespace Hospital.API.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int FloorId { get; set; }
        public Floor Floor { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
    }
}
