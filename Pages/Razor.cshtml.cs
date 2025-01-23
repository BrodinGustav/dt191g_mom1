
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace moment1.Pages
{
    public class RazorModel : PageModel
    {
        public string DayOfTheWeek { get; set; }
        public void OnGet()
        {

            //Hur göra kollen ang fredag?
            /*
            DayOfTheWeek = "friday";
            if (DateTime.Now == "friday")
            {
                DayOfTheWeek = "friday";
            }
            else
            {
                //Dölj
            }
    */
        }
    
    }
}

