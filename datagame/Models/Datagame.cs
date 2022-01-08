using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace datagame.Models
{
    public class Datagame
    {
        [Key]
        
        public string Gamename { get; set; }
        public string GameType { get; set; }
        public string Description { get; set; }

    }
}