using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using bootstrap.Models;
using System.Threading.Tasks;

namespace bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return null;
        }

        public ActionResult TeamFinder()
        {
            DingerDataContext Db = new DingerDataContext();

            TeamFinderModels Model = new TeamFinderModels();

            Model.TF = new List<ShowTeamListResult>();

            Model.TF = Db.ShowTeamList().ToList();

            return View(Model);
        }

        public ActionResult About()
        {
            DingerDataContext Db = new DingerDataContext();

            PlayerSeachViewModel Model = new PlayerSeachViewModel();

            Model.SC = new List<PlayerSearchResult>();

            Model.SearchCriteria = "";

            Model.SC = Db.PlayerSearch(Model.SearchCriteria).ToList();

            return View(Model);
        }
        [HttpPost]
        
        [ValidateAntiForgeryToken]
        public ActionResult About(PlayerSeachViewModel model)
        {
            DingerDataContext Db = new DingerDataContext();

            if (ModelState.IsValid)
            {
                if (model.SearchCriteria == null)
                {
                    model.SearchCriteria = "";
                }
                model.SC = Db.PlayerSearch(model.SearchCriteria).ToList();
            }

            
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PlayerPage(int PlayerID)
        {
            DingerDataContext Db = new DingerDataContext();

            PlayerPageViewModel Model = new PlayerPageViewModel();

            Model.BP = new List<BatterPlayerPageResult>();
           
            Model.BP = Db.BatterPlayerPage(PlayerID).ToList();

            Model.PP = new List<PitcherPlayerPageResult>();

            Model.PP = Db.PitcherPlayerPage(PlayerID).ToList();

            return View(Model);
        }

        public ActionResult LeagueLeaders()
        {
            DingerDataContext Db = new DingerDataContext();

            LeagueLeadersViewModel Model = new LeagueLeadersViewModel();

            Model.LL = new List<LeagueLeadersResult>();

            Model.LL = Db.LeagueLeaders().ToList();

            return View(Model);
        }
    }
}