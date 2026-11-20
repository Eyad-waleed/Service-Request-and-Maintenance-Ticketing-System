using System.ComponentModel.DataAnnotations;

namespace Service_Request_and_Maintenance_Ticketing_System.Model; // change to .Models if needed

public class TicketStatusHistory
{
    public int Id { get; set; }

    [Required]
    public int TicketId { get; set; }
    public Ticket? Ticket { get; set; }

    [Required]
    [StringLength(30)]
    public string OldStatus { get; set; } = string.Empty;

    [Required]
    [StringLength(30)]
    public string NewStatus { get; set; } = string.Empty;

    [Required]
    public string ChangedById { get; set; } = string.Empty;
    public ApplicationUser? ChangedBy { get; set; }

    public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

    [StringLength(500)]
    public string? Note { get; set; }
}