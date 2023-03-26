using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace THA_W4_Calvin_T
{
    internal class Team
    {
        public string TeamName { get; set; }
        public string TeamCountry { get; set; }
        public string TeamCity { get; set; }
        public List<Player> Players = new List<Player>();

    }
}


   
