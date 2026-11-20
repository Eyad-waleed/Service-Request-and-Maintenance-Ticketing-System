using System.ComponentModel.DataAnnotations;
namespace Service_Request_and_Maintenance_Ticketing_System.Model
{
    

    public class TicketCategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; } = true;
    }
}
