using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding
 int a=12,b,c;
            b=a*minutos;
            DateTime loqsea = DateTime.Today;
            TimeSpan p=ProximoCumple-loqsea;
            
            int fecha=p.Days;
            c=b*fecha;

            ViewBag.Dias = fecha;
            ViewBag.Botellas = c;

            return View();
        }

    }
}
