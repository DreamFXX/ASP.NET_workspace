using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EverydayMuseApp.Pages
{
    public class WorkoutJournalModel : PageModel
    {
        [BindProperty]
        public string Exercise { get; set; }
        [BindProperty]
        public DateTime Date { get; set; }
        [BindProperty]
        public string Notes { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            try
            {
                // Add your form submission logic here
                // For example, save the data to a database

                return RedirectToPage("/Success"); // Redirect to a success page
            }
            catch (Exception ex)
            {
                ErrorMessage = "An error occurred while processing your request: " + ex.Message;
                return Page();
            }
        }
    }
}