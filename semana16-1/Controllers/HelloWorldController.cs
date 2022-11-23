﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace semana16_1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "Esta es la acción de Bienvenida";
        }

        public string Parameters(string name, int edad)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, tu edad es: {edad} años");
        }
    }
}
