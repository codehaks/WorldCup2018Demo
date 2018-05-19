using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [Route("player")]
        public IActionResult GetPlayers()
        {
            return Ok(_db.Set<Player>().Include(p => p.Team));
        }

        [Route("team")]
        public IActionResult GetTeams()
        {
            return Ok(_db.Teams);
        }

        [Route("Stadium")]
        public IActionResult GetStadiums()
        {
            return Ok(_db.Set<Stadium>().ToList());
        }

        [Route("Stadium")]
        [HttpPost]
        public IActionResult PostStadiums(Stadium model)
        {
            _db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _db.SaveChanges();
            return Ok();
        }
    }
}