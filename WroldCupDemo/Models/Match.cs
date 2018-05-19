using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupDemo.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int TeamA { get; set; }
        public int TeamB { get; set; }

        public int GoalsA { get; set; }
        public int GoalsB { get; set; }

        public int Index { get; set; }
        public DateTime Date { get; set; }

        public int StadiumId { get; set; }
    }
}