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
        // Zde m��e� p�idat k�d pro ulo�en� informac� o receptu do datab�ze nebo jin�ho �lo�i�t�

        return RedirectToPage("/RecipeBook");
    }
}

