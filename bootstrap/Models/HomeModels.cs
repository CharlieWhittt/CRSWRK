using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using bootstrap.Models;

namespace bootstrap.Models
{
    public class IndexModel
    {
        public List<getPlayersWithTeamResult> PT { get; set; }


    }
    public class TeamFinderModels
    {
        public List<ShowTeamListResult> TF { get; set; }


    }
    public class PlayerSeachViewModel
    {
        public string SearchCriteria { get; set; }

        public List<PlayerSearchResult> SC { get; set; }
    }
    public class PlayerPageViewModel
    {
        public string PlayerID { get; set; }

        public List<BatterPlayerPageResult> BP { get; set; }
        public List<PitcherPlayerPageResult> PP { get; set; }
    }
}