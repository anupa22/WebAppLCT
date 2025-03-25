using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
namespace WebApplication1.Pages
{
    public class ConvertMoneyModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(MyInput myobj) {
            int mon = myobj.txt1 * 85;
            TempData["res"] = "Money in rupees = " + mon;
        }
    }
}
