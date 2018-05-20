using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupDemo.Models
{
    public class PlayerInfo
    {
        [Key]
        public int PlayerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
    }
}