using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WroldCupDemo.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int Appearances { get; set; }
        public int Titles { get; set; }
        public int Rank { get; set; }
    }
}