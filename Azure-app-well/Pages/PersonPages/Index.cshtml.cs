using Azure_app_well.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Azure_app_well.Pages.PersonPages;
public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<Person> Person { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Person = await _context.Persons.ToListAsync();
    }
}
