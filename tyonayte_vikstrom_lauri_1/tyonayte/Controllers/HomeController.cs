using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tyonayte.Controllers
{
    public class HomeController : Controller
    {
        public const int aloitusRaha = 300;
        public const String aloitusPaikka = Models.AbstractState.KotiString;
        public const String alasString = "Alas";
        public const String ylosString = "Ylos";
        public const String oikealleString = "Oikealle";
        public const String vasemmalleString = "Vasemmalle";

        public IActionResult Index(String Paikka = aloitusPaikka, int Rahaa = aloitusRaha, String Suunta = alasString)
        {
            Models.Context context = new Models.Context(Paikka, Rahaa);

            switch(Suunta)
            {
                case ylosString:
                    context.MeneYlos();
                    break;
                case oikealleString:
                    context.MeneOikealle();
                    break;
                case vasemmalleString:
                    context.MeneVasemmealle();
                    break;
                default:
                    context.MeneAlas();
                    break;
            }
            
            ViewData["Rahaa"] = context.Rahaa;
            ViewData["Paikka"] = context.GetCurrentState();
            ViewData["YlosString"] = context.GetYlosUri();
            ViewData["AlasString"] = context.GetAlasUri();
            ViewData["OikealleString"] = context.GetOikealleUri();
            ViewData["VasemmalleString"] = context.GetVasemmalleUri();

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
