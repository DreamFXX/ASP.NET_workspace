using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EverydayMuseApp.Pages;
public class IdeasModel : PageModel
{
    private readonly IHostEnvironment _environment;

    [BindProperty]
    public string Title { get; set; }
    [BindProperty]
    public string Description { get; set; }
    [BindProperty]
    public IFormFile Image { get; set; }

    public IdeasModel(IHostEnvironment environment)
    {
        _environment = environment;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (Image != null)
        {
            var filePath = Path.Combine(_environment.ContentRootPath, "wwwroot/images", Image.FileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await Image.CopyToAsync(fileStream);
            }
        }

        // Code for storing the idea into the database or other storage location!

        return RedirectToPage("/Ideas");
    }
}
