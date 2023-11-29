using System.ComponentModel.DataAnnotations;

namespace Hospital.API.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int? RoomId { get; set; }
        public Room? Room { get; set; }
    }
}
