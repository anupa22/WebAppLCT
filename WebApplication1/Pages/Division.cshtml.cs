using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class DivisionModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(MyProp myobj) {
            int z = myobj.txt1 / myobj.txt2;
            TempData["res"] = "Quo is " + z;
        }    
    }
}
