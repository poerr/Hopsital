using System.ComponentModel.DataAnnotations;

namespace Hospital.API.Models
{
    public class Floor
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public string? Description { get; set; }
    }
}
