using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
namespace WebApplication1.Pages
{
   
    public class ConvertDistModel : PageModel
    {
        [BindProperty]
        public int txt1 { get; set; }
        public void OnGet()
        {

        }
        public void onPost()
        {
            int dist = txt1 * 1000;
            TempData["res"] = "Distance in meters = " + dist;
        }
    }
}
