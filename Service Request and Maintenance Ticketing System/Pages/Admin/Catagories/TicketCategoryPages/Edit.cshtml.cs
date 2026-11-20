using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Service_Request_and_Maintenance_Ticketing_System.Model;
using Service_Request_and_Maintenance_Ticketing_System.Data;

namespace Service_Request_and_Maintenance_Ticketing_System.Pages.TicketCategoryPages;

public class EditModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public EditModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
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
        TicketCategory = ticketcategory;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(TicketCategory).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TicketCategoryExists(TicketCategory.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool TicketCategoryExists(int id)
    {
        return _context.TicketCategory.Any(e => e.Id == id);
    }
}
