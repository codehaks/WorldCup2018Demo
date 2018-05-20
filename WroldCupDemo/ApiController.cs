using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupDemo.Data;
using WorldCupDemo.Models;

namespace WorldCupDemo
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

        [Route("player")]
        [HttpGet]
        public IActionResult GetPlayers()
        {
            return Ok(_db.Set<Player>().ToList());
        }

        [Route("player/team")]
        [HttpGet]
        public IActionResult GetPlayersWithTeams()
        {
            return Ok(_db.Players.Include(p => p.Team).ToList());
        }
    }
}