using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Service_Request_and_Maintenance_Ticketing_System.Model;
using Service_Request_and_Maintenance_Ticketing_System.Data;

namespace Service_Request_and_Maintenance_Ticketing_System.Pages.TicketCategoryPages;

public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public CreateModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public TicketCategory TicketCategory { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.TicketCategory.Add(TicketCategory);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
