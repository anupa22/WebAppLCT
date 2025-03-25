using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    
   
    public class MultiplicationModel : PageModel
    {
        [BindProperty]
        public MyProp mydata { get; set; }
        public void OnGet()
        {
        }
        public void OnPost() {

            int z = mydata.txt1 + mydata.txt2;
            TempData["res"] = "Product is " + z;
        }
    }
}
