using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupDemo.Models
{
    public class PlayerInfo
    {
        public int PlayerInfoId { get; set; }
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Player Player { get; set; }
    }
}