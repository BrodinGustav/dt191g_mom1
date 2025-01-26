
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dt191g_mom1.Pages
{
    public class RazorModel : PageModel
    {
        //Property som lagrar aktuellt datum och tid
        public string CurrentDateTime { get; private set; }

        //Lista över lästa kurser
        public List<string> Courses = new List<string>
        {
        "Datateknik GR (A), Introduktion till programmering i JavaScript - DT084G",
        "Datateknik GR (A), Webbutveckling I - DT057G",
        "Datateknik GR (A), Grafisk teknik för webb - DT200G",
        "Datateknik GR (B), Webbanvändbarhet - DT068G",
        "Datateknik GR (B), Frontend-baserad webbutveckling - DT211G",
        "Datateknik GR (A), Databaser - DT003G",
        "Datateknik GR (B), Programmering i TypeScript - DT208G",
        "Datateknik GR (B), Backend-baserad webbutveckling - DT207G",
        "Informatik GR (A), Projektledning - IK060G",
        "Datateknik GR (A), Programmering i C#.NET - DT071G",
        "Datateknik GR (B), Webbutveckling för WordPress - DT209G",
        "Datateknik GR (B), Fullstack-utveckling med ramverk - DT193G"
        };


         //Metod som körs när sidan laddas
        public void OnGet()
        {

            //Lagrar aktuell tid enligt format  "ÅÅÅÅ-MM-DD HH:MM:SS"
            CurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        //Kontroll om aktuell dag är fredag
        public string CheckIfFriday()
        {


            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return "Det är fredag !";
            }
            else
            {
                return "Det är inte fredag";
            }

        }

    }
}

