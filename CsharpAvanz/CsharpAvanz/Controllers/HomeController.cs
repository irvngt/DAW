using System;
using CsharpAvanz.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CsharpAvanz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        public ViewResult AutoProperty()
        {

            //Crear un nuevo objeto
            //de la clase
            Product myProduct = new Product
            {
                ProductID=12,
                Name="kayak",
                Description = "KIOSTECA BLUE",
                Categoriy = "sports",
                Price = 12.5f,
            };

            //Establecer el valor de la propiedad
            /* myProduct.ProductID = 12;
             myProduct.Name = "Katay";
             myProduct.Description = "KIOSTECA BLUE";
             myProduct.Categoriy = "sports";
             myProduct.Price = 12.5f;*/

            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                 myProduct.ProductID,
             myProduct.Name,
             myProduct.Description,
             myProduct.Categoriy,
             myProduct.Price);

            return View("Results",
                (object)salida);



        }
        public ViewResult CreateCollection()
        {

            string[] stringArray = { "manzana", "naranja", "lima" };

            List<int> intList = new List<int> { 10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int>{
            {"Manzana",10},
            {"Naranja",20},
            {"Lima",30}
            };
            return View("Results", (object)myDict["Lima"].ToString());


        }
        public ViewResult UseExtension() { 
        //creacion e inicializacion de shopping cart
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>{
            new Product{Name ="Kayak",Price=3250.0f},
            new Product{Name ="Lentes",Price=1500.0f},
            new Product{Name ="Balon Football",Price=50.0f},
            new Product{Name ="disco volador",Price=130.0f},
            }
            };
            
            //OBTENIENDO EL TOTAL DE LA COMPRA
            double total =cart.TotalPrice();

            //RENDERANDO VISTA
            return View("Results",
                (object)String.Format("Total:{0:c}", total));


        }
        

    }
}
