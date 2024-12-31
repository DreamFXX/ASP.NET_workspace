using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EverydayMuseApp.Pages;

public class RecipesPageModel : PageModel
{
    [BindProperty]
    public string RecipeName { get; set; }
    [BindProperty]
    public string Ingredients { get; set; }
    [BindProperty]
    public string Instructions { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Zde mùžeš pøidat kód pro uložení informací o receptu do databáze nebo jiného úložištì

        return RedirectToPage("/RecipeBook");
    }
}

