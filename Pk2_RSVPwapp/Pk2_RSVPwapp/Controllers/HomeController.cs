using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pk2_RSVPwapp.Models;//VAMOS A IMPORTAR ESPACIO DE NOMBRES 

namespace Pk2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?
                "Buenos Dias!!!" : "Buena Tarde!!!";

            return View();
        }
        //Renderear el Link de la forma del RSVP
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //Responde a un Posst: /home/RsvpForm
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse GuestResponse)
        {
            //verificado errores de validacion
            if (ModelState.IsValid)
            {
                //todo:envia respuesta al correo de el organizador
                return View("Agradecimientos", GuestResponse);
            }
            else
            {
                return View();
            }

        }

    }
}
