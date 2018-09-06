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
}