
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dt191g_mom1.Pages
{
    public class RazorModel : PageModel
    {
         public string CurrentDateTime { get; private set; }

       
    
     //   public string DayOfTheWeek { get; set; }
        public void OnGet()
        {

                // Sätt datum och tid som en egenskap
        CurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    

            //Hur göra kollen ang fredag?
            /*
            DayOfTheWeek = "friday";
            if (DateTime.Now == "friday")
            {
                DayOfTheWeek = "friday";
            }
            else
            {
j
            }
    */
    
        }
    
    }
}

