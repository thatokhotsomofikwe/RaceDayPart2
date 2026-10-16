using RaceDay.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        public int OrganiserID { get; set; }
        [ForeignKey("OrganiserID")]
        public User? Organiser { get; set; }

        [Required, StringLength(150)]
        public string EventName { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required, StringLength(150)]
        public string Location { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string EventType { get; set; } = string.Empty; // Running, Walking, Cycling

        [Required, StringLength(20)]
        public string Status { get; set; } = "Upcoming"; // Upcoming, Open, Completed, Cancelled

        // Navigation properties
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Enrolment> Enrolments { get; set; } = new List<Enrolment>();
        public Route? Route { get; set; }
    }
}