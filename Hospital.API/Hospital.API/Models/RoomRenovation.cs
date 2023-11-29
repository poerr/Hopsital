using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.API.Models
{
    public class RoomRenovation
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime Start {  get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime End { get; set; }
        public string NewRoom1Name { get; set; }
        public string NewRoom1Description { get; set; }
        public string NewRoom1Type { get; set; }
        public string? NewRoom2Name { get; set; }
        public string? NewRoom2Description { get; set; }
        public string? NewRoom2Type { get; set; }
    }
}
