using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Service_Request_and_Maintenance_Ticketing_System.Model;
using Service_Request_and_Maintenance_Ticketing_System.Data;

namespace Service_Request_and_Maintenance_Ticketing_System.Pages.TicketCategoryPages;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<TicketCategory> TicketCategory { get; set; } = default!;

    public async Task OnGetAsync()
    {
        TicketCategory = await _context.TicketCategory.ToListAsync();
    }
}
