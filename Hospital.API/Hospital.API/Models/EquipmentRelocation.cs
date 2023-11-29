using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.API.Models
{
    public class EquipmentRelocation
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public int RoomFromId { get; set; }
        public Room RoomFrom { get; set; }
        public int RoomToId { get; set; }
        public Room RoomTo { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime Start { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime End { get; set; }
    }
}
