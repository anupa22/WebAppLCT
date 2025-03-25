using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class ConvertTimeModel : PageModel
    {
        [BindProperty]
        public int z {  get; set; }
        public void OnGet()
        {
        }
        public void OnPost() {
            int z = Convert.ToInt32(Request.Form["txt1"].ToString());
            int time = z * 60 * 60;
            TempData["res"] = "Time in seconds = " + time;
        }
    }
}
