using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Service_Request_and_Maintenance_Ticketing_System.Model; 

public class ApplicationUser : IdentityUser
{
    [Required]
    [StringLength(100)]
    [Display(Name = "Full Name")]
    public string FullName { get; set; } = string.Empty;

    [StringLength(100)]
    public string? Department { get; set; }

    [Display(Name = "Active")]
    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}