using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using NewsAPI;
using GoogleSearchApi;
using System.Web;
using NewsAPI.Models;
using System.Web.Mvc;
using GoogleCSE;
using NewsAPI.Constants;
using System.Web.Query;
using News.Web.Models;

namespace News.Web.Controllers
{
    //  [RequireHttps]
    //  [Authorize]

    public class NewsController : Controller
    {
        //News.Model.Entity.Model1 m = new News.Model.Entity.Model1();

        // GET: News
        [AllowAnonymous]
        public ActionResult Index()
        {

            /*לא עובד בינתיים.....*/
            /*Object reference not set to an instance of an object.
Description: An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code. 

Exception Details: System.NullReferenceException: Object reference not set to an instance of an object.*/
            #region
            //          var  client = GoogleSearchApi.GoogleSearchClient.Search("Israel",1,true);
            string result = "";
            #endregion
            /* עובד */
            #region
            using (var web = new WebClient())
            {
                result = web.DownloadString("https://newsapi.org/v2/everything?q=israel&apiKey=3d52d9ae14c4462f96f8c449fb9f991c");

            }
            #endregion

            return View();
        }
        public ActionResult RealEstate()
        {
            return View();
        }
        public ActionResult Add()
        {

            return View();
        }
        [AllowAnonymous]
        public ActionResult business()
        {

            return View();

        }
        public ActionResult restaurants()
        {
            restaurant l = new restaurant();
            l.addr = "ההסתדרות 4, פתח תקווה";
            l.menu.Add(new meal { name = "falafel in pita ", price = 17 });
            l.menu.Add(new meal { name = "drink 0.5l ", price = 8 });
            List<restaurant> r = new List<restaurant>();
            r.Add(l);
            l = null;
            //       l.addr = "ההסתדרות 4, פתח תקווה";
            //     l.menu.Add(new meal { name = "falafel in pita ", price = 17 });
            //   l.menu.Add(new meal { name = "drink 0.5l ", price = 8 });
            return View(r);
        }
        [AllowAnonymous]
        public ActionResult cyber()
        {

            return View();

        }
    }
}