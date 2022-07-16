using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdventureGame.Models
{
    public class GameDTO
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? locationId { get; set; }
    }
}