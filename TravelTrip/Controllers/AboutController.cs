using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;
namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        //context sınıfından bir c nesnesi ürettim .bu c nesnesi aracılığı ile contexte bağlı olan hakkkımızdayı çektim
        public ActionResult Index()
        {
            var degerler = c.Hakkımızdas.ToList();
            return View(degerler);
        }
    }
}