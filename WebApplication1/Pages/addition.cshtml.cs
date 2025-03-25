using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class additionModel : PageModel
    {
        [BindProperty]
        public int x {  get; set; }
        [BindProperty]
        public int y { get; set; }
        public void OnGet()
        {
        }
        public void onPost()
        {
            x = Convert.ToInt32(Request.Form["txt1"].ToString());
            y = Convert.ToInt32(Request.Form["txt2"].ToString());
            int z = x + y;
            TempData["res"] = "Sum is " + z;
        }
    }
}
