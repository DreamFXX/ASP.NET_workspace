using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EverydayMuseApp.Pages;
public class IdeasModel : PageModel
{
    private readonly IHostEnvironment _environment;

    public string Title { get; set; }
    public void OnGet()
    {
    }
}
