using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupDemo.Models
{
    public class Stadium
    {
        [Key]
        [MaxLength(6)]
        public string Code { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(60)]
        public string City { get; set; }
    }
}