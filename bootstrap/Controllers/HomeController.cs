using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using bootstrap.Models;

namespace bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DingerDataContext Db = new DingerDataContext();

            IndexModel Model = new IndexModel();

            Model.PT = new List<getPlayersWithTeamResult>();

            Model.PT = Db.getPlayersWithTeam().ToList();

            return View(Model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}