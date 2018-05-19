﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupDemo.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public PlayerInfo PlayerInfo { get; set; }
    }
}