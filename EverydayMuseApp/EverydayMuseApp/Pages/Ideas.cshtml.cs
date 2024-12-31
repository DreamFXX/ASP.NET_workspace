using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EverydayMuseApp.Pages;
public class IdeasModel : PageModel
{
    private readonly IHostEnvironment _environment;

    [BindProperty]
    public string? Title { get; set; }
    [BindProperty]
    public string? Description { get; set; }
    [BindProperty]
    public IFormFile? Picture { get; set; }

    public void OnGet()
    {
    }
}
