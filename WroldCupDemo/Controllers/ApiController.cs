using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WorldCupDemo.Data;
using WorldCupDemo.Models;

namespace WorldCupDemo.Controllers
{
    public class ApiController : Controller
    {
        private readonly WorldcupDbContext _db;

        public ApiController(WorldcupDbContext db)
        {
            _db = db;
        }

        [Route("team")]
        [HttpGet]
        public IActionResult GetTeams()
        {
            return Ok(_db.Teams);
        }

        [Route("team")]
        [HttpPost]
        public IActionResult CreateTeam(Team model)
        {
            _db.Teams.Add(model);
            _db.SaveChanges();
            return Ok();
        }

        [Route("player")]
        [HttpGet]
        public IActionResult GetPlayers()
        {
            return Ok(_db.Players);
        }

        [Route("player/team")]
        [HttpGet]
        public IActionResult GetPlayersWithTeam()
        {
            return Ok(_db.Players.Include(p => p.Team));
        }

        [Route("player/team/info")]
        [HttpGet]
        public IActionResult GetPlayersWithTeamWithInfo()
        {
            return Ok(_db.Players);
        }

        [Route("player/info")]
        [HttpGet]
        public IActionResult GetPlayershInfo()
        {
            return Ok(_db.Players.Include(p => p.Team).Include(p => p.PlayerInfo));
        }
    }
}