using System.ComponentModel.DataAnnotations;

namespace Service_Request_and_Maintenance_Ticketing_System.Model; // change to .Models if needed

public class Ticket
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    [Display(Name = "Ticket Number")]
    public string TicketNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(150, MinimumLength = 3)]
    public string Subject { get; set; } = string.Empty;

    [Required]
    [StringLength(2000, MinimumLength = 5)]
    public string Description { get; set; } = string.Empty;

    // Foreign Key -> TicketCategory
    [Required]
    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    public TicketCategory? Category { get; set; }

    //requester
    [Required]
    public string RequesterId { get; set; } = string.Empty;
    public ApplicationUser? Requester { get; set; }

    //assigned agent
    [Display(Name = "Assigned Agent")]
    public string? AssignedAgentId { get; set; }
    public ApplicationUser? AssignedAgent { get; set; }

    [Required]
    [StringLength(20)]
    public string Priority { get; set; } = "Medium"; // Low, Medium, High, Urgent

    [Required]
    [StringLength(30)]
    public string Status { get; set; } = "Open"; // Open, In Progress, Waiting for Requester, Resolved, Closed

    [StringLength(2000)]
    [Display(Name = "Resolution Summary")]
    public string? ResolutionSummary { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ResolvedAt { get; set; }

    // Navigation Collections
    public ICollection<TicketComment> Comments { get; set; } = new List<TicketComment>();
    public ICollection<TicketAttachment> Attachments { get; set; } = new List<TicketAttachment>();
    public ICollection<TicketStatusHistory> StatusHistory { get; set; } = new List<TicketStatusHistory>();
}