using MyLandmark.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLandmark.Controllers
{
    public class HomeController : Controller
    {
        MLMContext db = new MLMContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult VMark()
        {
            
            db.Landmarks.Load();
            IEnumerable<Landmark> landmarks = db.Landmarks;
            
            return View();
        }
    }
}