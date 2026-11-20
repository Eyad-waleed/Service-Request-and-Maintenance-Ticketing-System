using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Service_Request_and_Maintenance_Ticketing_System.Model;
using Service_Request_and_Maintenance_Ticketing_System.Data;

namespace Service_Request_and_Maintenance_Ticketing_System.Pages.TicketCategoryPages;

public class DetailsModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public DetailsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public TicketCategory TicketCategory { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var ticketcategory = await _context.TicketCategory.FirstOrDefaultAsync(m => m.Id == id);
        if (ticketcategory is null)
        {
            return NotFound();
        }
        else
        {
            TicketCategory = ticketcategory;
        }

        return Page();
    }
}
