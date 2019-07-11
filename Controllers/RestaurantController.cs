using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Web.Controllers
{
    public class RestaurantController : Controller
    {
        List<News.Web.Models.restaurant> RESTS = new List<Models.restaurant>();

        // GET: Restaurant
        public ActionResult Index()
        {
            RESTS.Add
                (
                new Models.restaurant
                {
                    addr = "ההסתדרות 4, פתח תקווה. ",
                    l = Models.restaurant.type.falafel,
                    menu = new List<Models.meal>
                    { new Models.meal
                    {
                        name = "מנת פלאפל",
                        price = 17
                    },
                        new Models.meal
                        {
                            name = "קולה חצי ליטר",
                            price = 7
                        }
                    }
                }
                );
            RESTS.Add
               (
               new Models.restaurant
               {
                   l = Models.restaurant.type.sushi,
                   name = "frangelico",

                   addr = "העצמאות 65, פתח תקווה",

                   menu = new List<Models.meal>
                   { new Models.meal
                    {
                        name = "מאקי דג בהרכבה",
                        price = 26
                    },
                       new Models.meal
                    {
                        name = "I/O בהרכבה",
                        price = 30
                    },
                        new Models.meal
                        {
                            name = "קולה חצי ליטר",
                            price = 9
                        }
                   }
               }
               );
            return View(RESTS);
        }
        public ActionResult add()
        {
            RESTS.Add(
                new Models.restaurant
                {
                    name = Request["name"]
                    
                }
                );
            return View("Index", RESTS);
        }
    }
}