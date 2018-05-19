using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupDemo.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public int Appearances { get; set; }
        public byte Titles { get; set; }
        public int Rank { get; set; }
        public int Finals { get; set; }
    }
}