using PracticaTaller.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaTaller.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Menu()
        {
            PersonaViewModel personaVM = new PersonaViewModel();
            return View(personaVM);
        }
    }
}